import serial, threading, time
from datetime import datetime

# FIX ME : if mtype = (2 not 3) take all messages until mtype == 3
# ee_param_descriptor:


DEVICE_TYPE_NAME = ['repeater', 'keypad_2way', 'siren', 'zone', 'keypad_1way', 'keyfob', 'user', 'x10', 'gsm', 'system', 'guard', 'partition', 'hw_zone', 'pir_camera', 'log_event', 'fixed_zone_name', 'custom_zone_name']
P2_TLV_ERROR_CODES = ['VLM_NO_ERR', 'VLM_ERR_INVALID_LENGTH', 'VLM_ERR_INVALID_MTYPE', 'VLM_ERR_INVALID_DCODE', 'VLM_ERR_NOT_LOGIN', 'VLM_ERR_TLV_VALUE_NOT_SUPPORTED', 'VLM_ERR_UNKNOWN_GROUP_MODE', 'VLM_ERR_WRONG_CODE', 'VLM_ERR_TLV_TYPE_NOT_SUPPORTED', 'VLM_ERR_TLV_WRONG_LEN', 'VLM_ERR_TLV_NOT_SUPPORT_MODE', 'VLM_ERR_EE_INDEX_INVALID', 'VLM_ERR_EE_NO_PERMISSION', 'VLM_ERR_DENY_NEW_REQUEST_DURING_TX', 'VLM_ERR_DENY_BY_TASK', 'VLM_ERR_DEVICE_NOT_ACTIVATED', 'VLM_ERR_INVALID_DEVICE']
def chars_to_int(data):
    return int(hexdump(data[::-1]).replace(" ", ""), 16)


def num_to_chars(number, length = 0 , reverse = 1):
    result = ''

    #Converting HEX number
    if number == '' or number is None:
        return '\x00' * length
    if (type(number) is not int):
        #print '"{0}" {1}'.format( number, type(number) )
        #number = int(number, 0)
        number = int(number)
        # because command "setparam35 76 08" have error "invalid literal for int() with base 0: '08'"
    if (length == 0):
        if (number == 0):
            return chr(number)

        while (number > 0):
            result += chr(number % 256)
            number /= 256
    else:
        for i in range(length):
            result += chr(number % 256)
            number /= 256

    #Returning reverse number
    if reverse: return result [::-1]
    return result

def hexdump(s):
    if (type(s) is int):
        s = chr(s)
    elif (s is None):
        return 'NONE'
    return ' '.join(["%02X" % ord(i) for i in s ])

#"123" -> 0x12 0x3F
#numbers only
def str_to_bcd(string, filler='\xFF'):
    # fill with `filler` to get 8 bytes, don't fill in case filler = None
    if(not string.isdigit()):
        return None
    result = ''
    byte = 0
    length = len(string)
    if length > 8:
        length = 8
    for i in range(length):
        if (i+2)%2 == 0:
            byte |= int(string[i])<<4
        else:
            byte |= int(string[i])
            result += chr(byte)
            byte = 0
    if byte != 0:
        byte |= 0x0F
        result += chr(byte)

    if filler is None:
        return result
    #add empty symbols    
    while len(result) < 8:
        result += filler
    return result

def str_to_bcd_ex(string, size=0):
    result = ''
    byte = 0
    length = len(string)
    for i in range(length):
        if (i+2)%2 == 0:
            byte |= int(string[i], 16)<<4
        else:
            byte |= int(string[i], 16)
            result += chr(byte)
            byte = 0
    if byte != 0:
        byte |= 0x0F
        result += chr(byte)
    # print 'size requsted:%d' % size

    while (size != 0) and (len(result) < size):
        result += chr(0xFF) # fill with empty charasters
        # print 'len=%d' % len(result)
    return result

def bcd_to_str(bcd_data):
    result = ''
    for byte in bcd_data:
        # for i in range(1, -1, -1):
        #     if ord(byte) <= 9:
        #         result += str((ord(byte)&((0x0f)<<(4*i)))>>(4*i))
        #     else:
        result += "%02X" % ord(byte)

    return result

class EE_Parameter:
    _index = None
    _value = None
    _ptype = None # Descriptor predefined values

    class Descriptor:
        (
            EE_DESC_ASCII,
            EE_DESC_NIBBLE_BCD,
            EE_DESC_UINT32,
            EE_DESC_UINT16,
            EE_DESC_UINT8,
            EE_DESC_BIT,
            EE_DESC_STRING16,
            EE_DESC_STRING9,
            EE_DESC_STRING15,
            EE_DESC_STRING3,

        )  = range(10)

    def __init__(self, index, type, value=None):
        self._index = index
        self._value = value
        self._ptype = type

    @staticmethod
    def GetTypeByName(type, value, size=0): # FIXME return None value
        if(type == 'bin') or (type == 'default'):
            value = int(value)
            if size == 0:
                while value > 255:
                    value = value/256
                    size += 1
            if size < 2:
                return EE_Parameter.Descriptor.EE_DESC_UINT8
            if size < 4:
                return EE_Parameter.Descriptor.EE_DESC_UINT16
            return EE_Parameter.Descriptor.EE_DESC_UINT32


        if(type == 'str'):
            if size == 0:
                size = len(value)
            if size < 9:
                return EE_Parameter.Descriptor.EE_DESC_STRING3
            if size < 15:
                return EE_Parameter.Descriptor.EE_DESC_STRING9
            if size < 16:
                return EE_Parameter.Descriptor.EE_DESC_STRING15
            return EE_Parameter.Descriptor.EE_DESC_STRING16

        if(type == 'bcd'):
            return EE_Parameter.Descriptor.EE_DESC_NIBBLE_BCD

    def GetBinValue(self, size=None):
        # size or ptype? => size
        if self._ptype == EE_Parameter.Descriptor.EE_DESC_NIBBLE_BCD:
            #print '1', size
            # input - string, output - bcd string
            if size is None:
                print('GetBinValue:length for bcd value is not set.')
                return False
            value = str_to_bcd_ex(self._value, size)

        elif self._ptype == EE_Parameter.Descriptor.EE_DESC_STRING15      \
          or self._ptype == EE_Parameter.Descriptor.EE_DESC_STRING16    \
          or self._ptype == EE_Parameter.Descriptor.EE_DESC_STRING9     \
          or self._ptype == EE_Parameter.Descriptor.EE_DESC_STRING3     \
          or self._ptype == EE_Parameter.Descriptor.EE_DESC_ASCII:
            #print '2', size
            # nothing to do
            if size is None:
                print('GetBinValue:length for str value is not set.')
                return False
            value = self._value
            while len(value) < size:
                value += chr(0)

        elif self._ptype == EE_Parameter.Descriptor.EE_DESC_UINT8:
            #print '3', self._value
            value = num_to_chars(self._value, 1)
        elif self._ptype == EE_Parameter.Descriptor.EE_DESC_UINT16:
            #print '4', size
            value = num_to_chars(self._value, 2)
        elif self._ptype == EE_Parameter.Descriptor.EE_DESC_UINT32:
            #print '5', size
            value = num_to_chars(self._value, 4)

        else:
            print('GetBinValue:Wrong parameter type %d' % self._ptype, 1)
            return False
        return value

    def getValue(self):
        return self._value

    def setValue(self, value):
        self._value = value

       
class P12_API(object):
    _dwnd_code = 'AAAA'
    _port = None
    _debug = False
    _log_file = None
    _stop_reading = False
    _bufer = ''
    _msg_reader = None
    _seq  = 0

    def __init__(self, port, baud, debug, log_file=None, logger=None):
        self.logger = logger
        self._debug = debug
        self._log_file = log_file
        self.msg_pool = []
        self.msg_pool_out = []

        if self._log_file is not None:
            self._log_file = open(log_file, 'w')
       #open port
        if port:
            try:
                self._port = serial.Serial(port, baud, timeout=0.1)
            except Exception:
                pass
        if self._port is None:
            com_settings=open('.\COM.txt', 'r')
            port = com_settings.readline()
            port = port.strip()
            baud = com_settings.readline()
            baud = int(baud)
            com_settings.close()
            port.strip()
            self.debug_out("Can't open port, use defaults in file [%s]." % port, 2)
            self._port = serial.Serial(port, baud, timeout=0.1)
            
        if (self._port): 
    
            self._port.setRTS(False)
            self._port.setDTR(False)

            self._msg_reader = threading.Thread(target=self.extract_p1p2_packet)
            self._msg_reader.start()
        # else:
        #     printmsg("Can't open port")
        #     raise NameError('Can\'t open port')

    def set_download_code(self, code_str):
        self._dwnd_code = code_str

    def stop(self):
        if self._msg_reader is not None:
            self._stop_reading = 1
            self.debug_out("reading thread is stopping...", 2)
            self._msg_reader.join()
            self._port.close()
            if self._log_file is not None:
                self._log_file.close()


    def debug_out(self, string, level=0):
        if self.logger:
            if level == 1: # communication only
                self.logger.trace(2, string)
            elif level == 2:
                self.logger.trace(1, string)

               
        if(self._debug) and level == 1:
            print string
            return

        now = datetime.now().strftime("%d/%m/%y %H:%M:%S")
        microseconds = datetime.now().strftime("%f")
        now += "." + microseconds[:3]    

        if self._log_file is not None:
            if level == 1:
                self._log_file.write("%s > %s\n" % (now, string))
                self._log_file.flush()


    def p2_crc(self, data):
        crc = 0
        for p in data:
            crc += ord(p)
            if (crc > 255):
                crc = (crc & 0xff) + 1
        crc ^= 0xff
        return (crc&0xff)  



    #:0D 02 FD 0A 0D A5 00 04 07 45 00 00 02 04 00 00 43 C0 0A
    def extract_p1p2_packet(self):
        while(not self._stop_reading):
            msg = self.collect_data()
            if msg:
                self.debug_out('[RX]: %s' % hexdump(msg), 0)
                self.debug_out('[RX]: %s' % hexdump(msg), 1)
            if(msg) and (msg[1] != '\x02'):
                if msg[-3] == '\x43':
                    self.send_ack_p2()
                else:
                    self.send_ack()
            if not msg:
                time.sleep(0.02)
                continue
            # debug_out("add to pool:%s" % hexdump(msg))
            self.msg_pool.append(msg)

    def wait_message(self, value, num, timeout, realtime=0):
        self.debug_out("wait 0x%02X at %d" % (value, num))
        #debug_out("pool:")
        #debug_out('\n'.join([hexdump(m) for m in msg_pool]))
        time_stop = time.time() + timeout 
        while time.time() < time_stop:
            i = 0
            while i < len(self.msg_pool):
                msg = self.msg_pool[i]
                #print "cnk %d:%s" % (i,hexdump(msg))
                if msg and num < len(msg):
                    if ord(msg[num]) == value:
                        self.msg_pool.remove(msg)
                        # debug_out("msg removed:%s" % hexdump(msg))
                        return msg
                i += 1
        return None

    def get_flm_msg(self, msg):
        #print "FLM?%s" % hexdump(msg)
        for msg_len in [4, 5, 7, 14, 15, 17]:
            if msg_len <= len(msg):    # short mesage
                #print "%d:%s" % (msg_len,bufer[offset+msg_len-1] == '\x0A')
                if msg[msg_len - 1] == '\x0A':
                    data = msg[1 : msg_len - 2]
                    crc = self.p2_crc(data)
                    #print "p=%s" % hexdump(data)
                    #print "crc = 0x%02X (0x%02X)" % (crc,ord(msg[msg_len - 2]))
                    if crc == ord(msg[msg_len - 2]):
                        packet = msg[:msg_len]
                        # debug_out("got msg=%s[%d]" % (hexdump(packet), msg_len))
                        # debug_out("[RX]:%s" % hexdump(packet), 1)
                        #if(ord(packet[1]) not in [2, 1]):
                        #    send_ack()
                        return packet
        #print "NO"
        return None
    # 0D B0 03 06 02 0D 00 43 F3 0A 
    def get_vlm_msg(self, msg):
        # print "[RX]:%s" % hexdump(msg)
        if len(msg) > 4:    # VLM? message
            msg_len = ord(msg[4])
            #print hexdump(msg)
            if msg_len + 7 < len(msg):
                #print "off=%d, len=%d" % (offset, msg_len)
                #print "msg[msg_len + 7] = %02X" % ord(msg[msg_len + 7])
                if (msg[1] == '\xB0') and (msg[msg_len + 7] == '\x0A'):
                    packet = msg[: msg_len + 8]
                    # debug_out("got VLM=%s" % hexdump(packet))
                    # debug_out("[RX]:%s" % hexdump(packet), 1)
                    #send_ack()
                    return packet
        return None

    def collect_data(self):
        packet_found = False
        while (not packet_found) and (not self._stop_reading):
            data_size = self._port.inWaiting()
            if(data_size != 0):
                add = self._port.read(data_size)
                self._bufer += add
                # debug_out("get:%s[%d]" % (hexdump(add), data_size))
            else:
                if len(self.msg_pool_out) != 0:
                    msg = self.msg_pool_out.pop()
                    self._port.write(msg)
                    self.debug_out('[TX]: %s' % hexdump(msg), 0) 
                    self.debug_out('[TX]: %s' % hexdump(msg), 1)
                time.sleep(0.02)
                continue
            offset = 0
            while offset < len(self._bufer): # check all bufer
                while self._bufer[offset] != '\x0D':
                    offset += 1
                    #print "offset=%d" % offset
                    if offset == len(self._bufer):
                        break
                else:
                    # STM found
                    packet = self.get_vlm_msg(self._bufer[offset:])
                    if packet:
                        packet_found = True
                    else:
                        packet = self.get_flm_msg(self._bufer[offset:])
                        if packet:
                            packet_found = True
                    if packet_found:
                        #crop bufer if packet found
                        #print "pack len = %d, off=%d, buf=%s" %(len(packet), offset, hexdump(bufer))
                        self._bufer = self._bufer[len(packet) + offset:]
                        #print "buf = %s" % hexdump(bufer)
                        time.sleep(0.01)
                        return packet
                offset += 1




    def make_p2_vlm_msg(self, mtype, dcode, data, pid):
        if data:
            data = data + chr(self._seq)
        packet = '\xB0' + chr(mtype) + chr(dcode) + chr(len(data)) + data + chr(pid) 
        packet = '\x0D' + packet  + chr(self.p2_crc(packet)) + '\x0A'

        self._seq = (self._seq + 1)&0xff

        return packet

    def make_p1_msg(self, cmd, data='', pages=0, page=0):
        if data:
            packet = chr(cmd) + chr(pages) + chr(page) + data + chr(self._seq)
        else:
            packet = chr(cmd) + chr(self._seq)
        packet = '\x0D' + packet + chr(self.p2_crc(packet)) + '\x0A'
        self._seq = (self._seq + 1)&0xff
        return packet

    def make_get_tldv(self, mode, page, descriptor, type, value, downloadcode=None):
        # mode 
        # 0 - not relevnt filed.
        # 1 - single device
        # 2 -  group
        # 3 -  all non-portable
        # 4 -  all portable
        # 5 -  all
        if downloadcode is not None:
            data = str_to_bcd_ex(downloadcode)
            # print data
        else:
            data = ''        

        data += chr(mode) + chr(page) + chr(descriptor) + chr(type) + chr(len(value)) + value 
        return data

    def wait_ack(self, timeout=0.5):
        msg = self.wait_message(0x02, 1, timeout)
        #print "after ack wait"
        #print '\n'.join([hexdump(m) for m in msg_pool])
        if(msg):
            # debug_out("ack FOUND")
            return True
        # debug_out("NO ack")
        return False

    def send_cmd(self, msg, acktimeout=0.5):
        # debug_out("sending cmd:%s" % hexdump(msg))
        # debug_out("[TX]:%s" % hexdump(msg), 1)
        # port.write(msg)
        self.msg_pool_out.append(msg)
        ack = self.wait_ack(acktimeout)
        repeat = 3
        
        while not ack:
            self.debug_out("sending # %d time" % (3 - repeat))
            # debug_out("[TX]:%s" % hexdump(msg), 1)
            # port.write(msg)
            self.msg_pool_out.append(msg)
            ack = self.wait_ack()
            time.sleep(0.5)
            repeat -= 1
            #print "repeat # %d" % (10 - repeat)
            if repeat == 0:
                #print "No answer"
                return False
        msg = self.wait_message(0x06, 3, 0.2)
        if msg:
            ecode = ord(msg[5])
            if ecode < len(P2_TLV_ERROR_CODES):
                print 'TLV Error: %s' % P2_TLV_ERROR_CODES[ecode]
            else:
                print 'TLV Error: unknown code'

        return True

    def send_ack(self):
        # unit_id = 0x11
        #print "sending ack"
        ack = "\x0D\x02\xFD\x0A"
        # data = "\x02" + chr(unit_id)
        # ack = '\x0D' + chr(p2_crc(data)) + '\x0A'
        # self.debug_out("send ACK", 0)
        self.debug_out("[TX]: %s" % hexdump(ack), 1)
        self._port.write(ack)
        #time.sleep(1)

    def send_ack_p2(self):
        ack = "\x0D\x02\x43\xBA\x0A"
        self.debug_out("[TX]: %s" % hexdump(ack), 1)
        self._port.write(ack)

    def get_param_as_string(self, data, ptype):
        pvalue = ''
        if ptype == 0x02:
            pvalue = str(chars_to_int(data)&0xffffffff)
        elif ptype == 0x03:
            pvalue = str(chars_to_int(data)&0xffff)
        elif ptype == 0x04:
            pvalue = str(chars_to_int(data)&0xff)
        elif ptype == 1:
            pvalue =  bcd_to_str(data)
        else:
            pvalue =  data # string
        return pvalue

# ============================================ High level API functions ============================================
    # def get_legacy_log_p1(self, usercode = '1222'):
    #     print num_to_chars(usercode , 2, True)
    #     # data = '\x00' + num_to_chars(usercode , 2, True) + chr(0)
    #     data = chr(4) + str_to_bcd(usercode, None) + chr(0)
    #     print 'code and part:' + hexdump(data)
    #     data = data.ljust(8, '\x00')
    #     print 'data: ' + hexdump(data)
        
    #     packet = self.make_p1_msg(0xA1, data, 0, 0)
    #     self.send_cmd(packet)
    #     res = []
    #     ans = self.wait_message(0xA0, 1, 0.2)
    #     size = 0
    #     if ans is not None:
    #         size = ord(ans[2])
    #         print 'Log file size:%d' % size
    #         print 'Byte 11:%d' % ord(ans[10])
    #         print 'Byte 12:%d' % ord(ans[11])

    #     for i in range(size):
    #         ans = self.wait_message(0xA0, 1, 0.2)
    #         year = 1000 + ord(ans[9])
    #         month = ord(ans[8])
    #         day = ord(ans[7])
    #         hour = ord(ans[6])
    #         minute = ord(ans[5])
    #         second = ord(ans[4])
    #         if ans is None:
    #             break
    #         res.append((ans[11], ans[10], datetime(year, month, day, hour, minute, second)))
    #     return res

    def get_log_p2(self, type='standart', timeout=2.0):
        # type = standart | legacy
        # get log event data
        if type.upper() == 'STANDART':
            cmd = 0x2A
        else:
            cmd = 0x36
        pages = []
        result = []
        packet = self.make_p2_vlm_msg(1, cmd, '', 0x43)
        self.send_cmd(packet, timeout) # in case the panel processing command from IPMP
        ans = self.wait_message(cmd, 3, 2.0)
        if ans is None:
                self.debug_out('TIMEOUT during log reading', 2)
                return None
        while ord(ans[2]) == 0x02:
            # print 'page #%d' % ord(ans[5])
            page_len = ord(ans[8])
            pages.append(ans[9: 9 + page_len])
            ans = self.wait_message(cmd, 3, 2.0)
            if ans is None:
                self.debug_out('TIMEOUT during log reading', 2)
                return None
        # print 'WHILE ENDS'
        page_len = ord(ans[8])
        pages.append(ans[9: 9 + page_len])
        for page in pages:
            while len(page) > 9: # last slice operation is page[-1:] brings string with len = 1; last part includes packet end - 4 bytes
                # print 'len = ' + str(len(page))
                # print hexdump(page)
                record  = page[0:11] # first 10 bytes

                page = page[len(record) - 1:]
                # parse log record
                evt_time = datetime.utcfromtimestamp(chars_to_int(record[0:4]))
                src_dev_type = ord(record[4])
                src_num = chars_to_int(record[5:7])
                evt_code = ord(record[7])
                prtn = ord(record[8])
                ind = ord(record[9])
                result.append((evt_time, src_dev_type, src_num, evt_code, prtn, ind))

            # print 'evt_time:' + str(evt_time)
            # print 'src_dev_type:' + str(src_dev_type)
            # print 'src_num:' + str(src_num)
            # print 'evt_code:' + str(evt_code)
            # print 'prtn:' + str(prtn)
            # print 'ind:' + str(ind)
            # print '*'*40
        # print 'len is %d' % len(result)
        return result

    def add_device(self, dev_id, dev_num, lid):
        res_descr = ['Enrollment Completed',
                    'Pre Enroll Data doesn\'t match sync data',
                    'known(old) device is asking to be enrolled',
                    'No enough memory to save the new device',
                    'Enrollment Completed after sync',
                    'Not pre Enrollment Dev failed to sync',
                    'Pmx won\'t accept device other than the type defined in MMI',
                    'Wrong Neds',
                    'Pre Enroll Data saved',
                    'Err: Zero Long ID',
                    'CP isn\'t ready to enroll devices',
                    'Required new_dev_num is already occupied by another device',
                    'Required new_dev_num is invalid',
                    'Rejected from unknown Reason. Should not actually occur.',
                    'Rejected from unknown Reason. Should not actually occur.',
                    'Rejected - incompatible customer ID',
                    'enrolled degraded'
            ]

        # dev_id : 0 -2 
        # lid:  3 - 6
        # dev_num : 7 - 8
        # self.logout()
        # return 
        if not dev_num:
            return False
        value = ('%03d' % dev_id + '%04d' % lid + num_to_chars(dev_num -1, 2, False))

        packet = self.make_p1_msg(0x09)
        self.send_cmd(packet, 5)

        # print value
        data = self.make_get_tldv(1, 0xFF, 0x08, 0xFF, value, self._dwnd_code)
        packet = self.make_p2_vlm_msg(0x00, 0x25, data, 0x43)
        self.send_cmd(packet, 15)
        ans = self.wait_message(0x03, 2, 0.5)
        if ans and ord(ans[3]) == 6:
            # self.logger.warning('Command rejected by remote.')
            self.debug_out('Command rejected by remote.', 1)
            # print 'Command rejected by remote.'
            return False

        # time.sleep(1)
        packet = self.make_p2_vlm_msg(0x01, 0x25, '', 0x43)
        self.send_cmd(packet)
        ans = self.wait_message(0x25, 3, 5)
        if ans:
            res = ord(ans[9]) - 1
            try:
                self.debug_out(res_descr[res], 1)
            except IndexError: pass
        else:
            self.debug_out("timeout", 1)

        # self.logout()
        # data = self.make_get_tldv(1, 0xFF, 0x08, 0xFF, num_to_chars(dev_num -1, 2, False), self._dwnd_code)
        # packet = self.make_p2_vlm_msg(0x04, 0x25, data, 0x43)
        # self.send_cmd(packet)
        self.logout()
        return True

    def remove_device(self, dev_num, dev_type): 
    # 0D 09 F6 0A - instead of login

        if not dev_num:
            return False
        if isinstance(dev_type, basestring) and dev_type in DEVICE_TYPE_NAME:
            dev_type =  DEVICE_TYPE_NAME.index(dev_type)

        # self.login()
        packet = self.make_p1_msg(0x09)
        self.send_cmd(packet, 5)
        # data = self.make_get_tldv(1, 0xFF, 0x08, dev_type, value, self._dwnd_code)
        self.wait_message(0x3c, 1, 1)
        data = str_to_bcd_ex(self._dwnd_code) + '\x01\xFF\x08' + chr(dev_type) + '\x02' + chr(dev_num-1) + '\x00'
        packet = self.make_p2_vlm_msg(0x04, 0x25, data, 0x43)
        self.send_cmd(packet, 15)
        self.logout()

    def get_devices(self, method='enrolled'):
        devices = []
        # 1D, 1F
        # if isinstance(dev_type, basestring) and dev_type in DEVICE_TYPE_NAME:
        #     dev_type =  DEVICE_TYPE_NAME.index(dev_type)
        if method.lower() == 'enrolled':
            cmd = 0x1D
        else:
            cmd = 0x08
        packet = self.make_p2_vlm_msg(0x01, cmd, '\x05', 0x43) # get enrolled device bitmap, all
        self.send_cmd(packet)
        ans = self.wait_message(cmd, 3, 1)
        packet = ans
        while ord(ans[2]) != 0x03:
            self.wait_message(0x1D, 3, 1)
            packet += ans
        data_len = ord(packet[4])
        data = packet[5: 5 + data_len]
        pos = 0
        while True:
            pos = data.find('\xFF\x01', pos)
            if pos == -1: break
            dev_type = ord(data[pos + 2])
            # print 'dev type:%d' % dev_type
            dev_info_len = ord(data[pos + 3])
            dev_info = data[pos + 4 : pos + 4 + dev_info_len ]
            # print 'dev info:%s' % hexdump(dev_info)
            pos += 1
            # take subtype info for this device type
            sdata = '\x02\xFF\x00' + chr(dev_type)
            packet = self.make_p2_vlm_msg(0x01, 0x1F, sdata, 0x43)
            self.send_cmd(packet)
            packet = self.wait_message(0xB0, 1, 5)
            if ord(packet[3]) != 0x1F: continue
            subtype_len = ord(packet[8])

            if ord(packet[7]) != dev_type:
                self.debug_out('Wrong device type %d in answer, %d expected' % (ord(packet[7]) ,dev_type), 2)
                continue
            subtype = packet[9: 9 + subtype_len]
            # print 'subtype info %s' % hexdump(subtype)

            # dev_info - bitmask, dev_subtype - subtype
            for i,val in enumerate(dev_info):
                for bit in range(8):
                    if (ord(val)&(1<<bit)) == (1<<bit):
                        dev_num0 = i*8 + bit
                        dev_subtype = ord(subtype[dev_num0])
                        self.debug_out('Found device [%d:%d] # %d' % (dev_type, dev_subtype, dev_num0 + 1), 2)
                        devices.append((dev_type, dev_subtype, dev_num0 + 1))
        return devices

    def get_preenrolled_devices(self, dev_type):
        if isinstance(dev_type, basestring) and dev_type in DEVICE_TYPE_NAME:
            dev_type =  DEVICE_TYPE_NAME.index(dev_type)



    # def set_keypress_indication(self, mode = 'start', timeout = 10):
    #     # mode, page, descriptor, type, value, downloadcode
    #     dev_number = 0
    #     # timeout in seconds
    #     value = num_to_chars(dev_number, 2) + num_to_chars(timeout, 2)

    #     data = self.make_get_tldv(1, 0xFF, 32, 0x0C, value, self._dwnd_code)
    #     if mode == 'start':
    #         mm = 0x00
    #     else:
    #         mm = 0x04
    #     packet = self.make_p2_vlm_msg(mm, 0x4C, data, 0x43)
    #     return self.send_cmd(packet)
    def keypress_indication(self, mode = 0x00, timeout = 10, key = None):
        # 0x00 - start, 0x04 - stop , 0x01 - send key
        # mode, page, descriptor, type, value, downloadcode
        dev_number = 0
        # timeout in seconds
        if mode == 0x00:
            value = '\x00' + num_to_chars(dev_number, 2) + num_to_chars(timeout, 2)
            data = self.make_get_tldv(1, 0xFF, 8, 0x0C, value, self._dwnd_code)
        elif mode == 0x01:
            value = chr(key)
            data = self.make_get_tldv(1, 0xFF, 8, 0x0C, value)
        elif mode == 0x04:
            value = num_to_chars(dev_number, 2)
            data = self.make_get_tldv(1, 0xFF, 8, 0x0C, value, self._dwnd_code)
            
        packet = self.make_p2_vlm_msg(mode, 0x4C, data, 0x43)
        self.send_cmd(packet)
        store = ''
        if mode == 0x01:
            # wait lcd message
            while True:
                lcd = self.wait_message(0x4c, 3, 1.0)
                if not lcd : continue
                typ = ord(lcd[14])
                length = [1, 4, 32][typ - 1]

                if typ == 3: 
                    store += '\nLCD = %s' % lcd[16:-4].decode('utf16')
                    return store
                if typ == 2:
                    store+= '\nLED = %s' % ','.join(str(ord(bitmask)) for bitmask in lcd[16:16 + length])
                if typ == 1:
                    store += 'KEY = %d' % ord(lcd[16])



    def get_version(self):
        self.debug_out("get_version running", 2)
        #request vesrion
        version = self.make_p2_vlm_msg(0x01, 0x03, '\x00', 0x43)
        self.send_cmd(version)
        answer = ''
        while(not answer):
            answer = self.wait_message(0x03, 3, 1)
            if(answer):
                self.debug_out("version:%02d.%02d" % (ord(answer[5]), ord(answer[6])), 2)
            else:
                answer = ''
        return answer
    '''
    typedef struct
{
    uint16 repeaters;
    uint16 two_way_kpd;
    uint16 sirens;
    uint16 detectors;
    uint16 keypads;
    uint16 keyfobs;
    uint16 users;
    uint16 x10s;
    uint16 gsm_modem;
    uint16 wc;
    uint16 proxy;
    uint16 pgm;
    uint16 panel;
    uint16 guard_type;
    uint16 logfile;    
    uint16 client_partitions;
    uint16 max_fix_zone_names;  // added on protocol version #4
    uint16 max_custom_zone_names;   // added on protocol version #4

}ee_max_units_per_client_t;

    '''    
    def get_max_devices(self, index):
        try:
            index = int(index, 0)
        except ValueError:
            if not index in DEVICE_TYPE_NAME:
                self.debug_out('Unknown device type: %s' % index , 2)
                self.debug_out('Use one of the:' + ' '.join([name for name in DEVICE_TYPE_NAME]), 2) 
                return False
            index = DEVICE_TYPE_NAME.index(index)

        value = '\x00'
        data = self.make_get_tldv(0, 0, 0x08, 0xFF, value)

        packet = self.make_p2_vlm_msg(1, 0x22, data, 0x43)
        # print "packet to be sent:" + hexdump(packet)
        self.send_cmd(packet)
        # self._port.write(packet)
        answer = self.wait_message(0x22, 3, 1)
        if answer is None:
            return  False
        # print "ans:%s" % hexdump(answer)
        data = answer[9:-4]

        if(index != 255) and (index <0 or index >= len(data)/2):
            self.debug_out('Wrong index ,data len = %d' % len(data), 2)
            return False
        res = ''
        if index == 255:
            for idx in range(len(data)/2):
                if res == '':
                    res += str((ord(data[idx*2 + 1])<<8) + (ord(data[idx*2])))
                else:
                    res += ',' + str((ord(data[idx*2 + 1])<<8) + ord(data[idx*2]))
            return res
            
        res = str((ord(data[index*2 + 1])<<8) + ord(data[index*2]))
        return  res

    '''
    const BYTE reporting_offset_tbl[] =
    {
        PP_REPEATER_REPORT_UNIT_NUM ,//REPEATER_TYPE,
        PP_2WKP_REPORT_UNIT_NUM     ,//KEYPAD_2WAY_TYPE 
        PP_SIREN_REPORT_UNIT_NUM    ,//SIREN_TYPE       
        PP_ZONE_REPORT_UNIT_NUM     ,//ZONE_TYPE        
        PP_MCM140_REPORT_UNIT_NUM   ,//KEYPAD_1WAY_TYPE 
        PP_KEYFOB_REPORT_UNIT_NUM   ,//KEYFOB_TYPE      
        PP_USER_REPORT_UNIT_NUM     ,//USERS_TYPE           
        PP_X10_REPORT_UNIT_NUM      ,//X10_TYPE         
        PP_GSM_REPORT_UNIT_NUM      ,//GSM_TYPE             
        PP_PLINK_REPORT_UNIT_NUM    ,//WC_TYPE              
        PP_PROXY_REPORT_UNIT_NUM    ,//PRXY_TYPE        
        PP_PGM_REPORT_UNIT_NUM      ,//PGM_TYPE         
        PP_SYSTEM_REPORT_UNIT_NUM   ,//SYS_TYPE
        PP_GUARD_REPORT_UNIT_NUM    ,  
    };

    '''
    def get_event_offset(self, index=255):
        value = '\x00'
        data = self.make_get_tldv(0, 0, 0x08, 0xFF, value)
        packet = self.make_p2_vlm_msg(1, 0x2B, data, 0x43)
        answer = ''
        self.send_cmd(packet)
        answer = self.wait_message(0x2B, 3, 1)
        if answer is None:
            return False

        data = answer[9:-4]
        # print hexdump(data)
        if (index != 255) and (index <0 or index >= len(data)/2):
            self.debug_out('Wrong index ,data len = %d' % len(data), 2)
            return False
        res = ''
        if index == 255:
            for idx in range(len(data)/2):
                if res == '':
                    res += '%01X%02X' % (ord(data[idx*2 + 1]) , (ord(data[idx*2])))
                else:
                    res += ',' + '%01X%02X' %  (ord(data[idx*2 + 1]) , ord(data[idx*2]))
            return res
            
        res = '%01X%02X' % (ord(data[index*2 + 1]) , ord(data[index*2]))
        return  res
        

    def p2_set_eeprom_param35(self, pnum, value, size, mode):
        # size - size of the parameter in bytes 
        # depend on pnum !!!
        # if size != 0:
        #     size = size / 8

        param = EE_Parameter(pnum, EE_Parameter.GetTypeByName(mode, value, size))
        param.setValue(value)
        #print value
        value_bin = param.GetBinValue(size)
        #print value
        self.debug_out("P2 set eeprom parameter %d = %s" % (pnum, str(value)), 2)
        pnum = num_to_chars(pnum, 2, 0)
        #print value
        # downloadcode = 'AAAA'
        # if args.downloadcode:
        #     downloadcode = args.downloadcode
            
        data = self.make_get_tldv(0x01, 0xFF, 0x08, 0xFF,  pnum + value_bin, self._dwnd_code)
        packet = self.make_p2_vlm_msg(0, 0x35, data, 0x43)
        self.send_cmd(packet)
        # time.sleep(0.2)
        packet = self.make_p2_vlm_msg(0, 0x45, '\x00', 0x43)
        return self.send_cmd(packet)



    def p2_get_eeprom_param35(self, pnum):
        self.debug_out("P2 get eeprom parameter %d" % pnum, 3)
        pnum = num_to_chars(pnum, 2, 0)
        # ptype = chr(86)
        data = self.make_get_tldv(0x01, 0xFF, 0x08, 0xFF, pnum) 
        packet = self.make_p2_vlm_msg(1, 0x35, data, 0x43)
        self.send_cmd(packet)
        answer = ''
        while not answer:
            answer = self.wait_message(0x35, 3, 1)
            if(answer):
                # print "ans:%s" % hexdump(answer)
                pass
            else:
                print "timeout"
                return None
        lenght = ord(answer[8])
        data = answer[9:9 + lenght]
        # print 'data=' + hexdump(data)
        ptype = ord(data[2])
        # pvalue = ''
        # if ptype == 0x02:
        #     pvalue = chars_to_int(data[3:])&0xffffffff
        # elif ptype == 0x03:
        #     pvalue = chars_to_int(data[3:])&0xffff
        # elif ptype == 0x04:
        #     pvalue = chars_to_int(data[3:])&0xff
        # elif ptype == 1:
        #     pvalue =  bcd_to_str(data[3:])
        # else:
        #     pvalue =  data[3:] # string
        # return pvalue
        return self.get_param_as_string(data[3:], ptype)

    def dump_42_data(self, bytes):
        field_names = ['Parameter Index', 'Total items', 'Item length (bits)', 'Items gap', 'Item type', 'Access perm', 
        '1st item index', 'Items count', 'Data']
        field_lens = [2, 2, 2, 2, 1, 1, 2, 2, '*']
        item_type = [
            'ASCII',
            'NIBBLE_BCD',
            'UINT32',
            'UINT16',
            'UINT8',
            'BIT',
            'STRING16',
            'STRING9',
            'STRING15',
            'STRING3']
        offset = 0
        for field_num,name in enumerate(field_names):
            if not isinstance(field_lens[field_num], str):
                value = chars_to_int(bytes[offset:offset + field_lens[field_num]])
                offset += field_lens[field_num]
                if name == 'Item type':
                    value = item_type[value]
                    self.debug_out('%s:%s' % (name,value), 1)
                else:
                    self.debug_out('%s:0x%04X' % (name,value), 1)

            elif field_lens[field_num] == '*':
                self.debug_out( '%s(%d):%s' % (name, len(bytes[offset:]), hexdump(bytes[offset:])), 1)



    def p2_get_eeprom_param42(self, pnum, start, last, mode):
        data = self.make_get_tldv(0x01, 0xFF, 0x0C, 0xFF, num_to_chars(pnum, 2, 0) + num_to_chars(start, 2, 0) + num_to_chars(last, 2, 0))
        packet = self.make_p2_vlm_msg(1, 0x42, data, 0x43)
        self.send_cmd(packet)
        answer = ''
        mtype = 0
        data = ''
        while mtype != 3:
            answer = self.wait_message(0x42, 3, 1)
            if(answer):
                # print "ans:%s" % hexdump(answer)
                mtype = ord(answer[2])
                pass
            else:
                # print "timeout"
                return None
            ptype = ord(answer[17]) 
            data += answer[23: -4]
            self.dump_42_data(answer[9:-4])
        # print "type = %d, data = %s" % (ptype, hexdump(data))
        if mode != 'default':
            if mode == 'bin':
                ptype = 2
                if len(data) <= 4:
                    ptype = [4, 3, 3 ,2][len(data) - 1]

            elif mode == 'str':
                ptype = 0
            elif mode == 'bcd':
                ptype = 1
        return self.get_param_as_string(data, ptype)

    def p2_set_eeprom_param42(self, num, item, value, size, mode):
            # FIX ME : size differs from one parameter to another !!!
            # print "size = %d" % size
            # if size != 0:
            #     size = size / 8

            param = EE_Parameter(num, EE_Parameter.GetTypeByName(mode, value, size))
            param.setValue(value)
            value_bin = param.GetBinValue(size)
            self.debug_out("P2 set eeprom parameter %d[%d] = %s" % (num, item, str(value)), 2)

            num = num_to_chars(num, 2, 0)
            item = num_to_chars(item, 2, 0)
            data = self.make_get_tldv(0x01, 0xFF, 0x08, 0xFF,  num + item + value_bin, self._dwnd_code)
            packet = self.make_p2_vlm_msg(0x00, 0x42, data, 0x43)
            #FIXME: can get back NACK or ERROR message
            self.send_cmd(packet)
               # time.sleep(0.2)
            packet = self.make_p2_vlm_msg(0, 0x45, '\x00', 0x43)
            return self.send_cmd(packet)
            # answer = ''
            # while(not answer):
            #     answer = wait_message(0x42, 3, 1)
            #     if(answer):
            #         print "ans:%s" % hexdump(answer)
            #     else:
            #         answer = wait_message(0x06, 3, 1)
            #         if(answer):
            #             print "unsupported command"



    def p2_get_eeprom_block(self, begin, end):
        # print "P2 getting eeprom from 0x%04x to 0x%04x" % (begin, end)
        begin_str = num_to_chars(begin, 4, 0)
        end_str = num_to_chars(end, 4, 0)
        #value = '\x08\x00\x00\x00' + '\x20\x00\x00\x00'
        value = begin_str + end_str
        data = self.make_get_tldv(0xFF, 0, 1, 0xFF, value)

        packet = self.make_p2_vlm_msg(1, 0x3C, data, 0x43)
        #print "packet to be sent:" + hexdump(packet)
        #port.write(packet)
        self.send_cmd(packet)
        #TODO: put timeout
        # cur_addr_from_packet = 
        answer = ''
        # FIX ME: max packet data size
        if (end - begin) < 176:

            while(not answer):
                answer = self.wait_message(0x3C, 3, 1)
                if(answer):
                    # print "eeprom:%s" % hexdump(answer[13:-4])
                    return answer[13:-4]
                else:
                    answer = ''
        else:
            data_size = 0
            timeout_reached = False
            result = ''
            while (data_size < (end - begin)) and (not timeout_reached):
                answer = self.wait_message(0x3C, 3, 1)
                # TODO is it necessary to send ACK there? 
                if answer:
                    # send_ack(port)
                    # print "packet size: %d, data size: %d" % (len(answer), len(answer[9:-4]))
                    size = ord(answer[8])
                    ad_from = chars_to_int(answer[9:12])
                    # print "%04x == %04X" % (ad_from, begin + data_size)
                    if ad_from != begin + data_size:
                        self.debug_out("!!!!!! error in packet sequence order, expected address=%04X, got %04X" % (begin + data_size, ad_from), 1)
                        return None
                    # print "packet for address : [%04X], size=%d" % (ad_from,size)
                    # print "packet:%s" % hexdump(answer)
                    # print "data: %s" % hexdump(answer[9:-4])
                    result += answer[13: 13 + size - 4]
                    # print "portion [%d]:%s" % (len(answer[13: 13 + size - 4]), hexdump(answer[13: 13 + size - 4]))
                    # print "="*40
                    data_size += size - 4
                else:
                    timeout_reached = True

            # write_to_file(result, 'bin_file', data_size)
            return result


    def back_to_factory(self, opt=0):
        data = self.make_get_tldv(mode=0x01, page=0xFF, descriptor=8, type=0x0C, value=chr(opt), downloadcode=self._dwnd_code)
        packet = self.make_p2_vlm_msg(1, 0x44, data, 0x43)
        return self.send_cmd(packet)  

    def login(self):
        self.debug_out("login running", 2)
        
        packet = "\x24\x00\x00" + str_to_bcd_ex(self._dwnd_code, 2) + "\x00\x00\x00\x00\x00\x00"
        packet = '\x0D' + packet + chr(self.p2_crc(packet)) + '\x0A'
        self.send_cmd(packet)  # enter programming mode

        answer = ''
        while(not answer):
            answer = self.wait_message(0x3C, 1, 1.0)
            if(answer):
                self.debug_out("login successfull", 2)
                return True
            answer = self.wait_message(0x22, 1, 1.0)
            if(answer):
                self.debug_out("login successfull", 2)
                return True
            answer = self.wait_message(0x08,1, 1.0)
            if(answer):
                self.debug_out("access denied", 2)
                return False
            
    def logout(self):
        self.debug_out("logout", 2)
        packet = "\x0F"
        packet = '\x0D' + packet + chr(self.p2_crc(packet)) + '\x0A'
        self.send_cmd(packet)  # exit programming mode
        if self.wait_message(0x02, 1, 1.0):
            return True
        return False


    def p1_get_eeprom(self, address, size):
        self.debug_out("P1 getting eeprom", 2)
        address = num_to_chars(address, 2, 0)
        #           CMD     address     number of pages
        # packet = "\x5A" + address + "\x01\x00" + "\x00\x00\x00\x00\x00\x00"
        packet = "\x5A" + address + num_to_chars(size, 2, 0) + "\x00\x00\x00\x00\x00\x00"
        packet = '\x0D' + packet + chr(self.p2_crc(packet)) + '\x0A'
        self.send_cmd(packet)  
        answer = ''
        while(not answer):
            answer = self.wait_message(0x33, 1, 1.0)
            if(answer):
                self.debug_out("eeprom:%s" % hexdump(answer[4:-2]), 2)
                return answer[4:-2]
            
    def p1_set_eeprom(self, address, value, argtype='bin', size=1):
        if argtype == 'default':
            argtype = 'bin'
        #FIXME: string_size % 8 != 0 ????
        #TODO:argtype=str
        self.debug_out("P1 setting eeprom ", 2)
        self.debug_out("address = %d, value=%s, argtype=%s, size=%d" % (address, value, argtype, size), 2)
        address = num_to_chars(address, 2, 0)
        if(argtype == 'bin'):
            values = value.split(',')
            value = ''.join([chr(int(c,0)) for c in values])
            if not value:
                return False

            if  (len(values) == 1):
                cmd = '\x41'    
            elif(len(values) == 2):
                cmd = '\x42'    
            elif(len(values) == 3):
                cmd = '\x43'    
            elif(len(values) == 4):
                cmd = '\x44'    
            elif(len(values) == 5):
                cmd = '\x45'    
            elif(len(values) == 6):
                cmd = '\x46'    
            elif(len(values) == 7):
                cmd = '\x47'    
            elif(len(values) == 8):
                cmd = '\x48'
            while (len(value) != 8):
                value += '\x00'
        elif(argtype == 'bcd'):
            cmd = '\x48'
            value = str_to_bcd(value)

        packet = cmd + address + value
        packet = '\x0D' + packet + chr(self.p2_crc(packet)) + '\x0A'
        self.debug_out("sending %s" % hexdump(packet), 2)
        self.send_cmd(packet)
        answer=''
        #TODO: timeout
        answer = self.wait_message(0x06, 1, 1.0)
        if answer:
            self.debug_out("successfully written", 2)
            return True
        return False

if __name__ == "__main__":


    print hexdump(str_to_bcd_ex('100777708', 2))