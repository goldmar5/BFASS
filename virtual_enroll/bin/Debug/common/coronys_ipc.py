#!/usr/bin/python
# -*- coding: utf-8 -*-

import ctypes, ctypes.wintypes
import os, sys, time

IpcCreateServer, IpcIsNewMessage,  IpcReplyToServer, IpcGetNewMessageIndex,\
IpcGetNewMessageText, IpcReleaseServer, IpcSendMessage, IpcGetServerName = (None, None, None, None, None, None, None, None)
#SendToCoronysLog = None

#class CrnRPC():

#def init_rpc(self):
def init_rpc():
    global IpcCreateServer, IpcIsNewMessage, IpcReplyToServer, IpcGetNewMessageIndex,\
    IpcGetNewMessageText, IpcReleaseServer, IpcSendMessage, IpcGetServerName
    #global SendToCoronysLog

    ipc_dll_file = 'c:\\ETS\\ETS_IPC_EX_DLL.dll'
    if os.path.exists(ipc_dll_file) == False:
        print 'IPC DLL not found in ' + ipc_dll_file
        return
    ETSdll = ctypes.CDLL(ipc_dll_file)

    prototype = ctypes.CFUNCTYPE (ctypes.c_long, ctypes.wintypes.LPCSTR)
    params = (1, "ServerName", 'SER_FOR_PY'),
    IpcCreateServer = prototype(('IpcCreateServer', ETSdll), params)

    prototype = ctypes.CFUNCTYPE (ctypes.c_long)
    params = None
    IpcIsNewMessage = prototype(('IpcIsNewMessage', ETSdll), params)

    prototype = ctypes.CFUNCTYPE (ctypes.c_long, ctypes.c_long, ctypes.wintypes.LPCSTR)
    params = (1, 'msg_index', 0), (1, 'msg_text', 0)
    IpcReplyToServer = prototype(('IpcReplyToServer', ETSdll), params)

    prototype = ctypes.CFUNCTYPE (ctypes.c_long)
    params = None
    IpcGetNewMessageIndex = prototype(('IpcGetNewMessageIndex', ETSdll), params)

    prototype = ctypes.CFUNCTYPE (ctypes.wintypes.LPCSTR)
    params = None
    IpcGetNewMessageText = prototype(('IpcGetNewMessageText', ETSdll), params)

    prototype = ctypes.CFUNCTYPE (ctypes.c_void_p)
    params = None
    IpcReleaseServer = prototype(('IpcReleaseServer', ETSdll), params)

    prototype = ctypes.CFUNCTYPE (ctypes.c_long, ctypes.wintypes.LPCSTR, ctypes.c_long, ctypes.wintypes.LPCSTR)
    params =  (1, 'server_name', 0), (1, 'msg_index', 0), (1, 'msg_text', 0)
    IpcSendMessage = prototype(('IpcSendMessage', ETSdll), params)

    prototype = ctypes.CFUNCTYPE (ctypes.wintypes.LPCSTR)
    params = None
    IpcGetServerName = prototype(('IpcGetServerName', ETSdll), params)

    #print 'IpcSendMessage:', IpcSendMessage
    #if IpcSendMessage == None:
    #    print 'IpcSendMessage is None. May be DLL not in ' + ipc_dll_file

    server_name = ctypes.create_string_buffer("DEMO_IPC")
    if(IpcCreateServer(server_name) == 0):
        return None
    return IpcGetServerName()

#def SendToCoronysLog(self, str1, cor_inst=1):
def SendToCoronysLog(str1):

    # read coronys instance
    file_com = os.path.normpath( os.path.join( os.path.dirname(__file__), '..\..\com.txt' ) )
    print 'file_com: ', file_com
    f1 = open(file_com, "r", 0) # Win
    f1.readline()
    f1.readline()
    coronys_instance = f1.readline()
    f1.close()
    if (coronys_instance != ''): coronys_instance = int(coronys_instance)
    else: coronys_instance = 1
    print 'coronys_instance: ', coronys_instance

    ets_app_name = '\\\\.\\mailslot\\0\\ETS\\' + os.environ['USERNAME'] + '\\'+str(coronys_instance) # instance number
    script_name = sys.argv[0].split('\\')[-1]
    time2 = '{0}'.format( time.strftime("[%d %b %H:%M:%S]", time.gmtime()) )
    coron_cmd = "Tmmessage 188, \"%s %s: %s\", '0,0,0', '230,230,230'" % (time2,script_name,str1)
    #coron_cmd = "DeclareGlobal dd = %d" % (5) # not work

    if IpcSendMessage != None:
        IpcSendMessage( ctypes.c_char_p(ets_app_name)
            , ctypes.c_long(32), ctypes.c_char_p(coron_cmd) )



if __name__ == "__main__":

    #crn_rpc = CrnRPC()
    #print crn_rpc.init_rpc()
    print init_rpc()


    #ets_app_name = '\\\\.\\mailslot\\0\\ETS\\' + os.environ['USERNAME'] + '\\1' # instance number
    #print  ets_app_name
    #IpcSendMessage(ctypes.c_char_p(ets_app_name), ctypes.c_long(32), ctypes.c_char_p("Tmmessage 188, \"%s: %s\"" % (sys.argv[0], "test message")))

    SendToCoronysLog("cocronys_ipc.py's test message.")
