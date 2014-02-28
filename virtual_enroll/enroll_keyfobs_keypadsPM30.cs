using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CookComputing.XmlRpc;
using System.Net;
using System.IO;
using System.Threading;

namespace BFASS
{
    public partial class enroll_keyfobs_keypadsPM30 : Form
    {
        public enroll_keyfobs_keypadsPM30()
        {
            InitializeComponent();
        }

        string SID, LID, code;
        SendRequests.ISend send = (SendRequests.ISend)XmlRpcProxyGen.Create(typeof(SendRequests.ISend));        

        public void GetAllDevice()
        {
            try
            {
                typeKF1.Text = "";
                typeKF2.Text = "";
                typeKF3.Text = "";
                typeKF4.Text = "";
                typeKF5.Text = "";
                typeKF6.Text = "";
                typeKF7.Text = "";
                typeKF8.Text = "";
                typeKF9.Text = "";
                typeKF10.Text = "";
                typeKF11.Text = "";
                typeKF12.Text = "";
                typeKF13.Text = "";
                typeKF14.Text = "";
                typeKF15.Text = "";
                typeKF16.Text = "";
                typeKF17.Text = "";
                typeKF18.Text = "";
                typeKF19.Text = "";
                typeKF20.Text = "";
                typeKF21.Text = "";
                typeKF22.Text = "";
                typeKF23.Text = "";
                typeKF24.Text = "";
                typeKF25.Text = "";
                typeKF26.Text = "";
                typeKF27.Text = "";
                typeKF28.Text = "";
                typeKF29.Text = "";
                typeKF30.Text = "";
                typeKF31.Text = "";
                typeKF32.Text = "";
                typeKP1.Text = "";
                typeKP2.Text = "";
                typeKP3.Text = "";
                typeKP4.Text = "";
                typeKP5.Text = "";
                typeKP6.Text = "";
                typeKP7.Text = "";
                typeKP8.Text = "";
                typeKP9.Text = "";
                typeKP10.Text = "";
                typeKP11.Text = "";
                typeKP12.Text = "";
                typeKP13.Text = "";
                typeKP14.Text = "";
                typeKP15.Text = "";
                typeKP16.Text = "";
                typeKP17.Text = "";
                typeKP18.Text = "";
                typeKP19.Text = "";
                typeKP20.Text = "";
                typeKP21.Text = "";
                typeKP22.Text = "";
                typeKP23.Text = "";
                typeKP24.Text = "";
                typeKP25.Text = "";
                typeKP26.Text = "";
                typeKP27.Text = "";
                typeKP28.Text = "";
                typeKP29.Text = "";
                typeKP30.Text = "";
                typeKP31.Text = "";
                typeKP32.Text = "";

                longIDkf1.Value = 1000;
                longIDkf2.Value = 1000;
                longIDkf3.Value = 1000;
                longIDkf4.Value = 1000;
                longIDkf5.Value = 1000;
                longIDkf6.Value = 1000;
                longIDkf7.Value = 1000;
                longIDkf8.Value = 1000;
                longIDkf9.Value = 1000;
                longIDkf10.Value = 1000;
                longIDkf11.Value = 1000;
                longIDkf12.Value = 1000;
                longIDkf13.Value = 1000;
                longIDkf14.Value = 1000;
                longIDkf15.Value = 1000;
                longIDkf16.Value = 1000;
                longIDkf17.Value = 1000;
                longIDkf18.Value = 1000;
                longIDkf19.Value = 1000;
                longIDkf20.Value = 1000;
                longIDkf21.Value = 1000;
                longIDkf22.Value = 1000;
                longIDkf23.Value = 1000;
                longIDkf24.Value = 1000;
                longIDkf25.Value = 1000;
                longIDkf26.Value = 1000;
                longIDkf27.Value = 1000;
                longIDkf28.Value = 1000;
                longIDkf29.Value = 1000;
                longIDkf30.Value = 1000;
                longIDkf31.Value = 1000;
                longIDkf32.Value = 1000;
                longIDkp1.Value = 1000;
                longIDkp2.Value = 1000;
                longIDkp3.Value = 1000;
                longIDkp4.Value = 1000;
                longIDkp5.Value = 1000;
                longIDkp6.Value = 1000;
                longIDkp7.Value = 1000;
                longIDkp8.Value = 1000;
                longIDkp9.Value = 1000;
                longIDkp10.Value = 1000;
                longIDkp11.Value = 1000;
                longIDkp12.Value = 1000;
                longIDkp13.Value = 1000;
                longIDkp14.Value = 1000;
                longIDkp15.Value = 1000;
                longIDkp16.Value = 1000;
                longIDkp17.Value = 1000;
                longIDkp18.Value = 1000;
                longIDkp19.Value = 1000;
                longIDkp20.Value = 1000;
                longIDkp21.Value = 1000;
                longIDkp22.Value = 1000;
                longIDkp23.Value = 1000;
                longIDkp24.Value = 1000;
                longIDkp25.Value = 1000;
                longIDkp26.Value = 1000;
                longIDkp27.Value = 1000;
                longIDkp28.Value = 1000;
                longIDkp29.Value = 1000;
                longIDkp30.Value = 1000;
                longIDkp31.Value = 1000;
                longIDkp32.Value = 1000;

                longIDkf1.Enabled = true;
                longIDkf2.Enabled = true;
                longIDkf3.Enabled = true;
                longIDkf4.Enabled = true;
                longIDkf5.Enabled = true;
                longIDkf6.Enabled = true;
                longIDkf7.Enabled = true;
                longIDkf8.Enabled = true;
                longIDkf9.Enabled = true;
                longIDkf10.Enabled = true;
                longIDkf11.Enabled = true;
                longIDkf12.Enabled = true;
                longIDkf13.Enabled = true;
                longIDkf14.Enabled = true;
                longIDkf15.Enabled = true;
                longIDkf16.Enabled = true;
                longIDkf17.Enabled = true;
                longIDkf18.Enabled = true;
                longIDkf19.Enabled = true;
                longIDkf20.Enabled = true;
                longIDkf21.Enabled = true;
                longIDkf22.Enabled = true;
                longIDkf23.Enabled = true;
                longIDkf24.Enabled = true;
                longIDkf25.Enabled = true;
                longIDkf26.Enabled = true;
                longIDkf27.Enabled = true;
                longIDkf28.Enabled = true;
                longIDkf29.Enabled = true;
                longIDkf30.Enabled = true;
                longIDkf31.Enabled = true;
                longIDkf32.Enabled = true;
                longIDkp1.Enabled = true;
                longIDkp2.Enabled = true;
                longIDkp3.Enabled = true;
                longIDkp4.Enabled = true;
                longIDkp5.Enabled = true;
                longIDkp6.Enabled = true;
                longIDkp7.Enabled = true;
                longIDkp8.Enabled = true;
                longIDkp9.Enabled = true;
                longIDkp10.Enabled = true;
                longIDkp11.Enabled = true;
                longIDkp12.Enabled = true;
                longIDkp13.Enabled = true;
                longIDkp14.Enabled = true;
                longIDkp15.Enabled = true;
                longIDkp16.Enabled = true;
                longIDkp17.Enabled = true;
                longIDkp18.Enabled = true;
                longIDkp19.Enabled = true;
                longIDkp20.Enabled = true;
                longIDkp21.Enabled = true;
                longIDkp22.Enabled = true;
                longIDkp23.Enabled = true;
                longIDkp24.Enabled = true;
                longIDkp25.Enabled = true;
                longIDkp26.Enabled = true;
                longIDkp27.Enabled = true;
                longIDkp28.Enabled = true;
                longIDkp29.Enabled = true;
                longIDkp30.Enabled = true;
                longIDkp31.Enabled = true;
                longIDkp32.Enabled = true;

                enrollKF1.Text = "enroll";
                enrollKF2.Text = "enroll";
                enrollKF3.Text = "enroll";
                enrollKF4.Text = "enroll";
                enrollKF5.Text = "enroll";
                enrollKF6.Text = "enroll";
                enrollKF7.Text = "enroll";
                enrollKF8.Text = "enroll";
                enrollKF9.Text = "enroll";
                enrollKF10.Text = "enroll";
                enrollKF11.Text = "enroll";
                enrollKF12.Text = "enroll";
                enrollKF13.Text = "enroll";
                enrollKF14.Text = "enroll";
                enrollKF15.Text = "enroll";
                enrollKF16.Text = "enroll";
                enrollKF17.Text = "enroll";
                enrollKF18.Text = "enroll";
                enrollKF19.Text = "enroll";
                enrollKF20.Text = "enroll";
                enrollKF21.Text = "enroll";
                enrollKF22.Text = "enroll";
                enrollKF23.Text = "enroll";
                enrollKF24.Text = "enroll";
                enrollKF25.Text = "enroll";
                enrollKF26.Text = "enroll";
                enrollKF27.Text = "enroll";
                enrollKF28.Text = "enroll";
                enrollKF29.Text = "enroll";
                enrollKF30.Text = "enroll";
                enrollKF31.Text = "enroll";
                enrollKF32.Text = "enroll";
                enrollKP1.Text = "enroll";
                enrollKP2.Text = "enroll";
                enrollKP3.Text = "enroll";
                enrollKP4.Text = "enroll";
                enrollKP5.Text = "enroll";
                enrollKP6.Text = "enroll";
                enrollKP7.Text = "enroll";
                enrollKP8.Text = "enroll";
                enrollKP9.Text = "enroll";
                enrollKP10.Text = "enroll";
                enrollKP11.Text = "enroll";
                enrollKP12.Text = "enroll";
                enrollKP13.Text = "enroll";
                enrollKP14.Text = "enroll";
                enrollKP15.Text = "enroll";
                enrollKP16.Text = "enroll";
                enrollKP17.Text = "enroll";
                enrollKP18.Text = "enroll";
                enrollKP19.Text = "enroll";
                enrollKP20.Text = "enroll";
                enrollKP21.Text = "enroll";
                enrollKP22.Text = "enroll";
                enrollKP23.Text = "enroll";
                enrollKP24.Text = "enroll";
                enrollKP25.Text = "enroll";
                enrollKP26.Text = "enroll";
                enrollKP27.Text = "enroll";
                enrollKP28.Text = "enroll";
                enrollKP29.Text = "enroll";
                enrollKP30.Text = "enroll";
                enrollKP31.Text = "enroll";
                enrollKP32.Text = "enroll";

                typeKF1.Enabled = true;
                typeKF2.Enabled = true;
                typeKF3.Enabled = true;
                typeKF4.Enabled = true;
                typeKF5.Enabled = true;
                typeKF6.Enabled = true;
                typeKF7.Enabled = true;
                typeKF8.Enabled = true;
                typeKF9.Enabled = true;
                typeKF10.Enabled = true;
                typeKF11.Enabled = true;
                typeKF12.Enabled = true;
                typeKF13.Enabled = true;
                typeKF14.Enabled = true;
                typeKF15.Enabled = true;
                typeKF16.Enabled = true;
                typeKF17.Enabled = true;
                typeKF18.Enabled = true;
                typeKF19.Enabled = true;
                typeKF20.Enabled = true;
                typeKF21.Enabled = true;
                typeKF22.Enabled = true;
                typeKF23.Enabled = true;
                typeKF24.Enabled = true;
                typeKF25.Enabled = true;
                typeKF26.Enabled = true;
                typeKF27.Enabled = true;
                typeKF28.Enabled = true;
                typeKF29.Enabled = true;
                typeKF30.Enabled = true;
                typeKF31.Enabled = true;
                typeKF32.Enabled = true;
                typeKP1.Enabled = true;
                typeKP2.Enabled = true;
                typeKP3.Enabled = true;
                typeKP4.Enabled = true;
                typeKP5.Enabled = true;
                typeKP6.Enabled = true;
                typeKP7.Enabled = true;
                typeKP8.Enabled = true;
                typeKP9.Enabled = true;
                typeKP10.Enabled = true;
                typeKP11.Enabled = true;
                typeKP12.Enabled = true;
                typeKP13.Enabled = true;
                typeKP14.Enabled = true;
                typeKP15.Enabled = true;
                typeKP16.Enabled = true;
                typeKP17.Enabled = true;
                typeKP18.Enabled = true;
                typeKP19.Enabled = true;
                typeKP20.Enabled = true;
                typeKP21.Enabled = true;
                typeKP22.Enabled = true;
                typeKP23.Enabled = true;
                typeKP24.Enabled = true;
                typeKP25.Enabled = true;
                typeKP26.Enabled = true;
                typeKP27.Enabled = true;
                typeKP28.Enabled = true;
                typeKP29.Enabled = true;
                typeKP30.Enabled = true;
                typeKP31.Enabled = true;
                typeKP32.Enabled = true;

                shortIDkf1.Text = "sid";
                shortIDkf2.Text = "sid";
                shortIDkf3.Text = "sid";
                shortIDkf4.Text = "sid";
                shortIDkf5.Text = "sid";
                shortIDkf6.Text = "sid";
                shortIDkf7.Text = "sid";
                shortIDkf8.Text = "sid";
                shortIDkf9.Text = "sid";
                shortIDkf10.Text = "sid";
                shortIDkf11.Text = "sid";
                shortIDkf12.Text = "sid";
                shortIDkf13.Text = "sid";
                shortIDkf14.Text = "sid";
                shortIDkf15.Text = "sid";
                shortIDkf16.Text = "sid";
                shortIDkf17.Text = "sid";
                shortIDkf18.Text = "sid";
                shortIDkf19.Text = "sid";
                shortIDkf20.Text = "sid";
                shortIDkf21.Text = "sid";
                shortIDkf22.Text = "sid";
                shortIDkf23.Text = "sid";
                shortIDkf24.Text = "sid";
                shortIDkf25.Text = "sid";
                shortIDkf26.Text = "sid";
                shortIDkf27.Text = "sid";
                shortIDkf28.Text = "sid";
                shortIDkf29.Text = "sid";
                shortIDkf30.Text = "sid";
                shortIDkf31.Text = "sid";
                shortIDkf32.Text = "sid";
                shortIDkp1.Text = "sid";
                shortIDkp2.Text = "sid";
                shortIDkp3.Text = "sid";
                shortIDkp4.Text = "sid";
                shortIDkp5.Text = "sid";
                shortIDkp6.Text = "sid";
                shortIDkp7.Text = "sid";
                shortIDkp8.Text = "sid";
                shortIDkp9.Text = "sid";
                shortIDkp10.Text = "sid";
                shortIDkp11.Text = "sid";
                shortIDkp12.Text = "sid";
                shortIDkp13.Text = "sid";
                shortIDkp14.Text = "sid";
                shortIDkp15.Text = "sid";
                shortIDkp16.Text = "sid";
                shortIDkp17.Text = "sid";
                shortIDkp18.Text = "sid";
                shortIDkp19.Text = "sid";
                shortIDkp20.Text = "sid";
                shortIDkp21.Text = "sid";
                shortIDkp22.Text = "sid";
                shortIDkp23.Text = "sid";
                shortIDkp24.Text = "sid";
                shortIDkp25.Text = "sid";
                shortIDkp26.Text = "sid";
                shortIDkp27.Text = "sid";
                shortIDkp28.Text = "sid";
                shortIDkp29.Text = "sid";
                shortIDkp30.Text = "sid";
                shortIDkp31.Text = "sid";
                shortIDkp32.Text = "sid";

                //_DeviceNames[OUTDOOR_SIREN]:     _DevClass["SIRENS"]     +'\x01',
                //_DeviceNames[INDOOR_SIREN]:      _DevClass["SIRENS"]     +'\x02',
                //_DeviceNames[KEYFOB]:            _DevClass["KEYFOBS"]    +'\x01',
                //_DeviceNames[KEYFOB_235]:        _DevClass["KEYFOBS"]    +'\x02',
                //_DeviceNames[KEYFOB_LCD]:        _DevClass["KEYFOBS"]    +'\x03',
                //_DeviceNames[PGX929]:            _DevClass["KEYFOBS"]    +'\x04',
                //_DeviceNames[PGX939]:            _DevClass["KEYFOBS"]    +'\x05',
                //_DeviceNames[REPEATER]:          _DevClass["REPEATERS"]  +'\x01',
                //_DeviceNames[KP_140]:            _DevClass["KEYPADS"]    +'\x01',
                //_DeviceNames[KP_141]:            _DevClass["KEYPADS"]    +'\x02',
                //_DeviceNames[KP_160_STATION]:    _DevClass["KEYPADS"]    +'\x05',
                //_DeviceNames[KP_250]:            _DevClass["KEYPADS"]    +'\x06',                

                DeviceInfo[] DevInfo;
                DevInfo = send.get_all_devices();

                for (int i = 0; i < DevInfo.Length; i++)
                {
                    if (DevInfo[i].type == "KEYFOB" || DevInfo[i].type == "KEYFOB_235" || DevInfo[i].type == "KEYFOB_LCD")
                    {
                        switch (Convert.ToInt32(DevInfo[i].num))
                        {
                            case 1:
                                longIDkf1.Text = DevInfo[i].lid;
                                shortIDkf1.Text = DevInfo[i].sid;
                                typeKF1.Text = DevInfo[i].type;
                                longIDkf1.Enabled = false;
                                typeKF1.Enabled = false;
                                enrollKF1.Text = "remove";
                                break;

                            case 2:
                                longIDkf2.Text = DevInfo[i].lid;
                                shortIDkf2.Text = DevInfo[i].sid;
                                typeKF2.Text = DevInfo[i].type;
                                longIDkf2.Enabled = false;
                                typeKF2.Enabled = false;
                                enrollKF2.Text = "remove";
                                break;

                            case 3:
                                longIDkf3.Text = DevInfo[i].lid;
                                shortIDkf3.Text = DevInfo[i].sid;
                                typeKF3.Text = DevInfo[i].type;
                                longIDkf3.Enabled = false;
                                typeKF3.Enabled = false;
                                enrollKF3.Text = "remove";
                                break;

                            case 4:
                                longIDkf4.Text = DevInfo[i].lid;
                                shortIDkf4.Text = DevInfo[i].sid;
                                typeKF4.Text = DevInfo[i].type;
                                longIDkf4.Enabled = false;
                                typeKF4.Enabled = false;
                                enrollKF4.Text = "remove";
                                break;

                            case 5:
                                longIDkf5.Text = DevInfo[i].lid;
                                shortIDkf5.Text = DevInfo[i].sid;
                                typeKF5.Text = DevInfo[i].type;
                                longIDkf5.Enabled = false;
                                typeKF5.Enabled = false;
                                enrollKF5.Text = "remove";
                                break;

                            case 6:
                                longIDkf6.Text = DevInfo[i].lid;
                                shortIDkf6.Text = DevInfo[i].sid;
                                typeKF6.Text = DevInfo[i].type;
                                longIDkf6.Enabled = false;
                                typeKF6.Enabled = false;
                                enrollKF6.Text = "remove";
                                break;

                            case 7:
                                longIDkf7.Text = DevInfo[i].lid;
                                shortIDkf7.Text = DevInfo[i].sid;
                                typeKF7.Text = DevInfo[i].type;
                                longIDkf7.Enabled = false;
                                typeKF7.Enabled = false;
                                enrollKF7.Text = "remove";
                                break;

                            case 8:
                                longIDkf8.Text = DevInfo[i].lid;
                                shortIDkf8.Text = DevInfo[i].sid;
                                typeKF8.Text = DevInfo[i].type;
                                longIDkf8.Enabled = false;
                                typeKF8.Enabled = false;
                                enrollKF8.Text = "remove";
                                break;

                            case 9:
                                longIDkf9.Text = DevInfo[i].lid;
                                shortIDkf9.Text = DevInfo[i].sid;
                                typeKF9.Text = DevInfo[i].type;
                                longIDkf9.Enabled = false;
                                typeKF9.Enabled = false;
                                enrollKF9.Text = "remove";
                                break;

                            case 10:
                                longIDkf10.Text = DevInfo[i].lid;
                                shortIDkf10.Text = DevInfo[i].sid;
                                typeKF10.Text = DevInfo[i].type;
                                longIDkf10.Enabled = false;
                                typeKF10.Enabled = false;
                                enrollKF10.Text = "remove";
                                break;

                            case 11:
                                longIDkf11.Text = DevInfo[i].lid;
                                shortIDkf11.Text = DevInfo[i].sid;
                                typeKF11.Text = DevInfo[i].type;
                                longIDkf11.Enabled = false;
                                typeKF11.Enabled = false;
                                enrollKF11.Text = "remove";
                                break;

                            case 12:
                                longIDkf12.Text = DevInfo[i].lid;
                                shortIDkf12.Text = DevInfo[i].sid;
                                typeKF12.Text = DevInfo[i].type;
                                longIDkf12.Enabled = false;
                                typeKF12.Enabled = false;
                                enrollKF12.Text = "remove";
                                break;

                            case 13:
                                longIDkf13.Text = DevInfo[i].lid;
                                shortIDkf13.Text = DevInfo[i].sid;
                                typeKF13.Text = DevInfo[i].type;
                                longIDkf13.Enabled = false;
                                typeKF13.Enabled = false;
                                enrollKF13.Text = "remove";
                                break;

                            case 14:
                                longIDkf14.Text = DevInfo[i].lid;
                                shortIDkf14.Text = DevInfo[i].sid;
                                typeKF14.Text = DevInfo[i].type;
                                longIDkf14.Enabled = false;
                                typeKF14.Enabled = false;
                                enrollKF14.Text = "remove";
                                break;

                            case 15:
                                longIDkf15.Text = DevInfo[i].lid;
                                shortIDkf15.Text = DevInfo[i].sid;
                                typeKF15.Text = DevInfo[i].type;
                                longIDkf15.Enabled = false;
                                typeKF15.Enabled = false;
                                enrollKF15.Text = "remove";
                                break;

                            case 16:
                                longIDkf16.Text = DevInfo[i].lid;
                                shortIDkf16.Text = DevInfo[i].sid;
                                typeKF16.Text = DevInfo[i].type;
                                longIDkf16.Enabled = false;
                                typeKF16.Enabled = false;
                                enrollKF16.Text = "remove";
                                break;

                            case 17:
                                longIDkf17.Text = DevInfo[i].lid;
                                shortIDkf17.Text = DevInfo[i].sid;
                                typeKF17.Text = DevInfo[i].type;
                                longIDkf17.Enabled = false;
                                typeKF17.Enabled = false;
                                enrollKF17.Text = "remove";
                                break;

                            case 18:
                                longIDkf18.Text = DevInfo[i].lid;
                                shortIDkf18.Text = DevInfo[i].sid;
                                typeKF18.Text = DevInfo[i].type;
                                longIDkf18.Enabled = false;
                                typeKF18.Enabled = false;
                                enrollKF18.Text = "remove";
                                break;

                            case 19:
                                longIDkf19.Text = DevInfo[i].lid;
                                shortIDkf19.Text = DevInfo[i].sid;
                                typeKF19.Text = DevInfo[i].type;
                                longIDkf19.Enabled = false;
                                typeKF19.Enabled = false;
                                enrollKF19.Text = "remove";
                                break;

                            case 20:
                                longIDkf20.Text = DevInfo[i].lid;
                                shortIDkf20.Text = DevInfo[i].sid;
                                typeKF20.Text = DevInfo[i].type;
                                longIDkf20.Enabled = false;
                                typeKF20.Enabled = false;
                                enrollKF20.Text = "remove";
                                break;

                            case 21:
                                longIDkf21.Text = DevInfo[i].lid;
                                shortIDkf21.Text = DevInfo[i].sid;
                                typeKF21.Text = DevInfo[i].type;
                                longIDkf21.Enabled = false;
                                typeKF21.Enabled = false;
                                enrollKF21.Text = "remove";
                                break;

                            case 22:
                                longIDkf22.Text = DevInfo[i].lid;
                                shortIDkf22.Text = DevInfo[i].sid;
                                typeKF22.Text = DevInfo[i].type;
                                longIDkf22.Enabled = false;
                                typeKF22.Enabled = false;
                                enrollKF22.Text = "remove";
                                break;

                            case 23:
                                longIDkf23.Text = DevInfo[i].lid;
                                shortIDkf23.Text = DevInfo[i].sid;
                                typeKF23.Text = DevInfo[i].type;
                                longIDkf23.Enabled = false;
                                typeKF23.Enabled = false;
                                enrollKF23.Text = "remove";
                                break;

                            case 24:
                                longIDkf24.Text = DevInfo[i].lid;
                                shortIDkf24.Text = DevInfo[i].sid;
                                typeKF24.Text = DevInfo[i].type;
                                longIDkf24.Enabled = false;
                                typeKF24.Enabled = false;
                                enrollKF24.Text = "remove";
                                break;

                            case 25:
                                longIDkf25.Text = DevInfo[i].lid;
                                shortIDkf25.Text = DevInfo[i].sid;
                                typeKF25.Text = DevInfo[i].type;
                                longIDkf25.Enabled = false;
                                typeKF25.Enabled = false;
                                enrollKF25.Text = "remove";
                                break;

                            case 26:
                                longIDkf26.Text = DevInfo[i].lid;
                                shortIDkf26.Text = DevInfo[i].sid;
                                typeKF26.Text = DevInfo[i].type;
                                longIDkf26.Enabled = false;
                                typeKF26.Enabled = false;
                                enrollKF26.Text = "remove";
                                break;

                            case 27:
                                longIDkf27.Text = DevInfo[i].lid;
                                shortIDkf27.Text = DevInfo[i].sid;
                                typeKF27.Text = DevInfo[i].type;
                                longIDkf27.Enabled = false;
                                typeKF27.Enabled = false;
                                enrollKF27.Text = "remove";
                                break;

                            case 28:
                                longIDkf28.Text = DevInfo[i].lid;
                                shortIDkf28.Text = DevInfo[i].sid;
                                typeKF28.Text = DevInfo[i].type;
                                longIDkf28.Enabled = false;
                                typeKF28.Enabled = false;
                                enrollKF28.Text = "remove";
                                break;

                            case 29:
                                longIDkf29.Text = DevInfo[i].lid;
                                shortIDkf29.Text = DevInfo[i].sid;
                                typeKF29.Text = DevInfo[i].type;
                                longIDkf29.Enabled = false;
                                typeKF29.Enabled = false;
                                enrollKF29.Text = "remove";
                                break;

                            case 30:
                                longIDkf30.Text = DevInfo[i].lid;
                                shortIDkf30.Text = DevInfo[i].sid;
                                typeKF30.Text = DevInfo[i].type;
                                longIDkf30.Enabled = false;
                                typeKF30.Enabled = false;
                                enrollKF30.Text = "remove";
                                break;

                            case 31:
                                longIDkf31.Text = DevInfo[i].lid;
                                shortIDkf31.Text = DevInfo[i].sid;
                                typeKF31.Text = DevInfo[i].type;
                                longIDkf31.Enabled = false;
                                typeKF31.Enabled = false;
                                enrollKF31.Text = "remove";
                                break;

                            case 32:
                                longIDkf32.Text = DevInfo[i].lid;
                                shortIDkf32.Text = DevInfo[i].sid;
                                typeKF32.Text = DevInfo[i].type;
                                longIDkf32.Enabled = false;
                                typeKF32.Enabled = false;
                                enrollKF32.Text = "remove";
                                break;
                        }
                    }

                    if (DevInfo[i].type == "KP_140" || DevInfo[i].type == "KP_141" || 
                        DevInfo[i].type == "KP_160_STATION" || DevInfo[i].type == "KP_250")
                    {
                        switch (Convert.ToInt32(DevInfo[i].num))
                        {
                            case 1:
                                longIDkp1.Text = DevInfo[i].lid;
                                shortIDkp1.Text = DevInfo[i].sid;
                                typeKP1.Text = DevInfo[i].type;
                                longIDkp1.Enabled = false;
                                typeKP1.Enabled = false;
                                enrollKP1.Text = "remove";
                                break;

                            case 2:
                                longIDkp2.Text = DevInfo[i].lid;
                                shortIDkp2.Text = DevInfo[i].sid;
                                typeKP2.Text = DevInfo[i].type;
                                longIDkp2.Enabled = false;
                                typeKP2.Enabled = false;
                                enrollKP2.Text = "remove";
                                break;

                            case 3:
                                longIDkp3.Text = DevInfo[i].lid;
                                shortIDkp3.Text = DevInfo[i].sid;
                                typeKP3.Text = DevInfo[i].type;
                                longIDkp3.Enabled = false;
                                typeKP3.Enabled = false;
                                enrollKP3.Text = "remove";
                                break;

                            case 4:
                                longIDkp4.Text = DevInfo[i].lid;
                                shortIDkp4.Text = DevInfo[i].sid;
                                typeKP4.Text = DevInfo[i].type;
                                longIDkp4.Enabled = false;
                                typeKP4.Enabled = false;
                                enrollKP4.Text = "remove";
                                break;

                            case 5:
                                longIDkp5.Text = DevInfo[i].lid;
                                shortIDkp5.Text = DevInfo[i].sid;
                                typeKP5.Text = DevInfo[i].type;
                                longIDkp5.Enabled = false;
                                typeKP5.Enabled = false;
                                enrollKP5.Text = "remove";
                                break;

                            case 6:
                                longIDkp6.Text = DevInfo[i].lid;
                                shortIDkp6.Text = DevInfo[i].sid;
                                typeKP6.Text = DevInfo[i].type;
                                longIDkp6.Enabled = false;
                                typeKP6.Enabled = false;
                                enrollKP6.Text = "remove";
                                break;

                            case 7:
                                longIDkp7.Text = DevInfo[i].lid;
                                shortIDkp7.Text = DevInfo[i].sid;
                                typeKP7.Text = DevInfo[i].type;
                                longIDkp7.Enabled = false;
                                typeKP7.Enabled = false;
                                enrollKP7.Text = "remove";
                                break;

                            case 8:
                                longIDkp8.Text = DevInfo[i].lid;
                                shortIDkp8.Text = DevInfo[i].sid;
                                typeKP8.Text = DevInfo[i].type;
                                longIDkp8.Enabled = false;
                                typeKP8.Enabled = false;
                                enrollKP8.Text = "remove";
                                break;

                            case 9:
                                longIDkp9.Text = DevInfo[i].lid;
                                shortIDkp9.Text = DevInfo[i].sid;
                                typeKP9.Text = DevInfo[i].type;
                                longIDkp9.Enabled = false;
                                typeKP9.Enabled = false;
                                enrollKP9.Text = "remove";
                                break;

                            case 10:
                                longIDkp10.Text = DevInfo[i].lid;
                                shortIDkp10.Text = DevInfo[i].sid;
                                typeKP10.Text = DevInfo[i].type;
                                longIDkp10.Enabled = false;
                                typeKP10.Enabled = false;
                                enrollKP10.Text = "remove";
                                break;

                            case 11:
                                longIDkp11.Text = DevInfo[i].lid;
                                shortIDkp11.Text = DevInfo[i].sid;
                                typeKP11.Text = DevInfo[i].type;
                                longIDkp11.Enabled = false;
                                typeKP11.Enabled = false;
                                enrollKP11.Text = "remove";
                                break;

                            case 12:
                                longIDkp12.Text = DevInfo[i].lid;
                                shortIDkp12.Text = DevInfo[i].sid;
                                typeKP12.Text = DevInfo[i].type;
                                longIDkp12.Enabled = false;
                                typeKP12.Enabled = false;
                                enrollKP12.Text = "remove";
                                break;

                            case 13:
                                longIDkp13.Text = DevInfo[i].lid;
                                shortIDkp13.Text = DevInfo[i].sid;
                                typeKP13.Text = DevInfo[i].type;
                                longIDkp13.Enabled = false;
                                typeKP13.Enabled = false;
                                enrollKP13.Text = "remove";
                                break;

                            case 14:
                                longIDkp14.Text = DevInfo[i].lid;
                                shortIDkp14.Text = DevInfo[i].sid;
                                typeKP14.Text = DevInfo[i].type;
                                longIDkp14.Enabled = false;
                                typeKP14.Enabled = false;
                                enrollKP14.Text = "remove";
                                break;

                            case 15:
                                longIDkp15.Text = DevInfo[i].lid;
                                shortIDkp15.Text = DevInfo[i].sid;
                                typeKP15.Text = DevInfo[i].type;
                                longIDkp15.Enabled = false;
                                typeKP15.Enabled = false;
                                enrollKP15.Text = "remove";
                                break;

                            case 16:
                                longIDkp16.Text = DevInfo[i].lid;
                                shortIDkp16.Text = DevInfo[i].sid;
                                typeKP16.Text = DevInfo[i].type;
                                longIDkp16.Enabled = false;
                                typeKP16.Enabled = false;
                                enrollKP16.Text = "remove";
                                break;

                            case 17:
                                longIDkp17.Text = DevInfo[i].lid;
                                shortIDkp17.Text = DevInfo[i].sid;
                                typeKP17.Text = DevInfo[i].type;
                                longIDkp17.Enabled = false;
                                typeKP17.Enabled = false;
                                enrollKP17.Text = "remove";
                                break;

                            case 18:
                                longIDkp18.Text = DevInfo[i].lid;
                                shortIDkp18.Text = DevInfo[i].sid;
                                typeKP18.Text = DevInfo[i].type;
                                longIDkp18.Enabled = false;
                                typeKP18.Enabled = false;
                                enrollKP18.Text = "remove";
                                break;

                            case 19:
                                longIDkp19.Text = DevInfo[i].lid;
                                shortIDkp19.Text = DevInfo[i].sid;
                                typeKP19.Text = DevInfo[i].type;
                                longIDkp19.Enabled = false;
                                typeKP19.Enabled = false;
                                enrollKP19.Text = "remove";
                                break;

                            case 20:
                                longIDkp20.Text = DevInfo[i].lid;
                                shortIDkp20.Text = DevInfo[i].sid;
                                typeKP20.Text = DevInfo[i].type;
                                longIDkp20.Enabled = false;
                                typeKP20.Enabled = false;
                                enrollKP20.Text = "remove";
                                break;

                            case 21:
                                longIDkp21.Text = DevInfo[i].lid;
                                shortIDkp21.Text = DevInfo[i].sid;
                                typeKP21.Text = DevInfo[i].type;
                                longIDkp21.Enabled = false;
                                typeKP21.Enabled = false;
                                enrollKP21.Text = "remove";
                                break;

                            case 22:
                                longIDkp22.Text = DevInfo[i].lid;
                                shortIDkp22.Text = DevInfo[i].sid;
                                typeKP22.Text = DevInfo[i].type;
                                longIDkp22.Enabled = false;
                                typeKP22.Enabled = false;
                                enrollKP22.Text = "remove";
                                break;

                            case 23:
                                longIDkp23.Text = DevInfo[i].lid;
                                shortIDkp23.Text = DevInfo[i].sid;
                                typeKP23.Text = DevInfo[i].type;
                                longIDkp23.Enabled = false;
                                typeKP23.Enabled = false;
                                enrollKP23.Text = "remove";
                                break;

                            case 24:
                                longIDkp24.Text = DevInfo[i].lid;
                                shortIDkp24.Text = DevInfo[i].sid;
                                typeKP24.Text = DevInfo[i].type;
                                longIDkp24.Enabled = false;
                                typeKP24.Enabled = false;
                                enrollKP24.Text = "remove";
                                break;

                            case 25:
                                longIDkp25.Text = DevInfo[i].lid;
                                shortIDkp25.Text = DevInfo[i].sid;
                                typeKP25.Text = DevInfo[i].type;
                                longIDkp25.Enabled = false;
                                typeKP25.Enabled = false;
                                enrollKP25.Text = "remove";
                                break;

                            case 26:
                                longIDkp26.Text = DevInfo[i].lid;
                                shortIDkp26.Text = DevInfo[i].sid;
                                typeKP26.Text = DevInfo[i].type;
                                longIDkp26.Enabled = false;
                                typeKP26.Enabled = false;
                                enrollKP26.Text = "remove";
                                break;

                            case 27:
                                longIDkp27.Text = DevInfo[i].lid;
                                shortIDkp27.Text = DevInfo[i].sid;
                                typeKP27.Text = DevInfo[i].type;
                                longIDkp27.Enabled = false;
                                typeKP27.Enabled = false;
                                enrollKP27.Text = "remove";
                                break;

                            case 28:
                                longIDkp28.Text = DevInfo[i].lid;
                                shortIDkp28.Text = DevInfo[i].sid;
                                typeKP28.Text = DevInfo[i].type;
                                longIDkp28.Enabled = false;
                                typeKP28.Enabled = false;
                                enrollKP28.Text = "remove";
                                break;

                            case 29:
                                longIDkp29.Text = DevInfo[i].lid;
                                shortIDkp29.Text = DevInfo[i].sid;
                                typeKP29.Text = DevInfo[i].type;
                                longIDkp29.Enabled = false;
                                typeKP29.Enabled = false;
                                enrollKP29.Text = "remove";
                                break;

                            case 30:
                                longIDkp30.Text = DevInfo[i].lid;
                                shortIDkp30.Text = DevInfo[i].sid;
                                typeKP30.Text = DevInfo[i].type;
                                longIDkp30.Enabled = false;
                                typeKP30.Enabled = false;
                                enrollKP30.Text = "remove";
                                break;

                            case 31:
                                longIDkp31.Text = DevInfo[i].lid;
                                shortIDkp31.Text = DevInfo[i].sid;
                                typeKP31.Text = DevInfo[i].type;
                                longIDkp31.Enabled = false;
                                typeKP31.Enabled = false;
                                enrollKP31.Text = "remove";
                                break;

                            case 32:
                                longIDkp32.Text = DevInfo[i].lid;
                                shortIDkp32.Text = DevInfo[i].sid;
                                typeKP32.Text = DevInfo[i].type;
                                longIDkp32.Enabled = false;
                                typeKP32.Enabled = false;
                                enrollKP32.Text = "remove";
                                break;
                        }
                    }
                }
            }

            catch (WebException ex)
            {
                statusLabel.Text = ex.Message + "! Please verified your settings or connection with panel.";
            }
            catch (XmlRpcInvalidXmlRpcException)
            {
                statusLabel.Text = "There aren't any enroll devices.";
            }
        }

        private void enroll_keyfobs_keypadsPM30_Activated(object sender, EventArgs e)
        {
            GetKeyfobsFromList();
            GetAllDevice();
        }

        private void GetKeyfobsFromList()
        {
            List<string> keyfobsList = new List<string>();

            keyfobsList.Add("KEYFOB");
            keyfobsList.Add("KEYFOB_235");

            typeKF1.DataSource = keyfobsList;
            typeKF2.DataSource = keyfobsList;
            typeKF3.DataSource = keyfobsList;
            typeKF4.DataSource = keyfobsList;
            typeKF5.DataSource = keyfobsList;
            typeKF6.DataSource = keyfobsList;
            typeKF7.DataSource = keyfobsList;
            typeKF8.DataSource = keyfobsList;
            typeKF9.DataSource = keyfobsList;
            typeKF10.DataSource = keyfobsList;
            typeKF11.DataSource = keyfobsList;
            typeKF12.DataSource = keyfobsList;
            typeKF13.DataSource = keyfobsList;
            typeKF14.DataSource = keyfobsList;
            typeKF15.DataSource = keyfobsList;
            typeKF16.DataSource = keyfobsList;
            typeKF17.DataSource = keyfobsList;
            typeKF18.DataSource = keyfobsList;
            typeKF19.DataSource = keyfobsList;
            typeKF20.DataSource = keyfobsList;
            typeKF21.DataSource = keyfobsList;
            typeKF22.DataSource = keyfobsList;
            typeKF23.DataSource = keyfobsList;
            typeKF24.DataSource = keyfobsList;
            typeKF25.DataSource = keyfobsList;
            typeKF26.DataSource = keyfobsList;
            typeKF27.DataSource = keyfobsList;
            typeKF28.DataSource = keyfobsList;
            typeKF29.DataSource = keyfobsList;
            typeKF30.DataSource = keyfobsList;
            typeKF31.DataSource = keyfobsList;
            typeKF32.DataSource = keyfobsList;
        }

        private int enroll_inside(string type, string lid, string zone_num)
        {
            try
            {
                send.enroll_to_zone(type, lid, zone_num);
                return 1;
            }
            catch (XmlRpcFaultException ex)
            {
                MessageBox.Show("Field 'Device type' doesn't fill.", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            catch (XmlRpcInvalidXmlRpcException ex)
            {
                MessageBox.Show("This zone already enrolled." + ex.Message, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            catch (WebException ex)
            {
                MessageBox.Show(ex.Message + "! Please verified your settings or connection with panel.", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        private void enroll_remove(ComboBox type, NumericUpDown lid, Button submit, Label sid, string zone_number)
        {
            string lidINstring = Convert.ToString(lid.Value);

            if (submit.Text == "enroll")
            {
                if (enroll_inside(type.Text, lidINstring, zone_number) == 1)
                {
                    statusLabel.Text = "";
                    GetAllDevice();
                }
            }
            else
            {
                send.remove_device(sid.Text, lidINstring);
                GetAllDevice();
                MessageBox.Show("Device removed", "Removing device...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void showFaultyForType(string devType)
        {
            DisableAllFaults();

            if (devType == "")
            {
                deviceDoesnotEnrolledMenu.Visible = true;
                syncMenu.Visible = false;
                arm_awayMenu.Visible = false;
                arm_homeMenu.Visible = false;
                disarmMenu.Visible = false;
                lowbatteryMenu.Visible = false;
                PanicMenu.Visible = false;
            }

            if (devType == "KEYFOB")
            {
                aux_buttonMenu.Visible = true;
            }

            if (devType == "KEYFOB_235")
            {
                aux_buttonMenu.Visible = true;
            }

            if (devType == "KP_140")
            {
                FireMenu.Visible = true;
                EmergencyMenu.Visible = true;
                aux_buttonMenu.Visible = true;
                tamperMenu.Visible = true;
            }

            if (devType == "KP_141")
            {
                FireMenu.Visible = true;
                EmergencyMenu.Visible = true;
                aux_buttonMenu.Visible = true;
                tamperMenu.Visible = true;
            }

            if (devType == "KP_160_STATION")
            {
                FireMenu.Visible = true;
                EmergencyMenu.Visible = true;
                aux_buttonMenu.Visible = true;
                tamperMenu.Visible = true;
            }

            if (devType == "KP_250")
            {
                FireMenu.Visible = true;
                EmergencyMenu.Visible = true;
                aux_buttonMenu.Visible = true;
                tamperMenu.Visible = true;
            }
        }

        public void SidLidDefinition(Control devType)
        {
            string zoneNUMBER = Convert.ToString(devType).Substring(Convert.ToString(devType).IndexOf("#") + 1);

            if (Convert.ToString(devType).Contains("KF"))
            {
                code = "0xAAAA";
                switch (Convert.ToInt32(zoneNUMBER))
                {
                    case 1:
                        LID = Convert.ToString(longIDkf1.Value);
                        SID = shortIDkf1.Text;
                        showFaultyForType(typeKF1.Text);
                        break;

                    case 2:
                        LID = Convert.ToString(longIDkf2.Value);
                        SID = shortIDkf2.Text;
                        showFaultyForType(typeKF2.Text);
                        break;

                    case 3:
                        LID = Convert.ToString(longIDkf3.Value);
                        SID = shortIDkf3.Text;
                        showFaultyForType(typeKF3.Text);
                        break;

                    case 4:
                        LID = Convert.ToString(longIDkf4.Value);
                        SID = shortIDkf4.Text;
                        showFaultyForType(typeKF4.Text);
                        break;

                    case 5:
                        LID = Convert.ToString(longIDkf5.Value);
                        SID = shortIDkf5.Text;
                        showFaultyForType(typeKF5.Text);
                        break;

                    case 6:
                        LID = Convert.ToString(longIDkf6.Value);
                        SID = shortIDkf6.Text;
                        showFaultyForType(typeKF6.Text);
                        break;

                    case 7:
                        LID = Convert.ToString(longIDkf7.Value);
                        SID = shortIDkf7.Text;
                        showFaultyForType(typeKF7.Text);
                        break;

                    case 8:
                        LID = Convert.ToString(longIDkf8.Value);
                        SID = shortIDkf8.Text;
                        showFaultyForType(typeKF8.Text);
                        break;

                    case 9:
                        LID = Convert.ToString(longIDkf9.Value);
                        SID = shortIDkf9.Text;
                        showFaultyForType(typeKF9.Text);
                        break;

                    case 10:
                        LID = Convert.ToString(longIDkf10.Value);
                        SID = shortIDkf10.Text;
                        showFaultyForType(typeKF10.Text);
                        break;

                    case 11:
                        LID = Convert.ToString(longIDkf11.Value);
                        SID = shortIDkf11.Text;
                        showFaultyForType(typeKF11.Text);
                        break;

                    case 12:
                        LID = Convert.ToString(longIDkf12.Value);
                        SID = shortIDkf12.Text;
                        showFaultyForType(typeKF12.Text);
                        break;

                    case 13:
                        LID = Convert.ToString(longIDkf13.Value);
                        SID = shortIDkf13.Text;
                        showFaultyForType(typeKF13.Text);
                        break;

                    case 14:
                        LID = Convert.ToString(longIDkf14.Value);
                        SID = shortIDkf14.Text;
                        showFaultyForType(typeKF14.Text);
                        break;

                    case 15:
                        LID = Convert.ToString(longIDkf15.Value);
                        SID = shortIDkf15.Text;
                        showFaultyForType(typeKF15.Text);
                        break;

                    case 16:
                        LID = Convert.ToString(longIDkf16.Value);
                        SID = shortIDkf16.Text;
                        showFaultyForType(typeKF16.Text);
                        break;

                    case 17:
                        LID = Convert.ToString(longIDkf17.Value);
                        SID = shortIDkf17.Text;
                        showFaultyForType(typeKF17.Text);
                        break;

                    case 18:
                        LID = Convert.ToString(longIDkf18.Value);
                        SID = shortIDkf18.Text;
                        showFaultyForType(typeKF18.Text);
                        break;

                    case 19:
                        LID = Convert.ToString(longIDkf19.Value);
                        SID = shortIDkf19.Text;
                        showFaultyForType(typeKF19.Text);
                        break;

                    case 20:
                        LID = Convert.ToString(longIDkf20.Value);
                        SID = shortIDkf20.Text;
                        showFaultyForType(typeKF20.Text);
                        break;

                    case 21:
                        LID = Convert.ToString(longIDkf21.Value);
                        SID = shortIDkf21.Text;
                        showFaultyForType(typeKF21.Text);
                        break;

                    case 22:
                        LID = Convert.ToString(longIDkf22.Value);
                        SID = shortIDkf22.Text;
                        showFaultyForType(typeKF22.Text);
                        break;

                    case 23:
                        LID = Convert.ToString(longIDkf23.Value);
                        SID = shortIDkf23.Text;
                        showFaultyForType(typeKF23.Text);
                        break;

                    case 24:
                        LID = Convert.ToString(longIDkf24.Value);
                        SID = shortIDkf24.Text;
                        showFaultyForType(typeKF24.Text);
                        break;

                    case 25:
                        LID = Convert.ToString(longIDkf25.Value);
                        SID = shortIDkf25.Text;
                        showFaultyForType(typeKF25.Text);
                        break;

                    case 26:
                        LID = Convert.ToString(longIDkf26.Value);
                        SID = shortIDkf26.Text;
                        showFaultyForType(typeKF26.Text);
                        break;

                    case 27:
                        LID = Convert.ToString(longIDkf27.Value);
                        SID = shortIDkf27.Text;
                        showFaultyForType(typeKF27.Text);
                        break;

                    case 28:
                        LID = Convert.ToString(longIDkf28.Value);
                        SID = shortIDkf28.Text;
                        showFaultyForType(typeKF28.Text);
                        break;

                    case 29:
                        LID = Convert.ToString(longIDkf29.Value);
                        SID = shortIDkf29.Text;
                        showFaultyForType(typeKF29.Text);
                        break;

                    case 30:
                        LID = Convert.ToString(longIDkf30.Value);
                        SID = shortIDkf30.Text;
                        showFaultyForType(typeKF30.Text);
                        break;

                    case 31:
                        LID = Convert.ToString(longIDkf31.Value);
                        SID = shortIDkf31.Text;
                        showFaultyForType(typeKF31.Text);
                        break;

                    case 32:
                        LID = Convert.ToString(longIDkf32.Value);
                        SID = shortIDkf32.Text;
                        showFaultyForType(typeKF32.Text);
                        break;
                } 
            }

            if (Convert.ToString(devType).Contains("KP"))
            {
                code = "1111";
                switch (Convert.ToInt32(zoneNUMBER))
                {
                    case 1:
                        LID = Convert.ToString(longIDkp1.Value);
                        SID = shortIDkp1.Text;
                        showFaultyForType(typeKP1.Text);
                        break;

                    case 2:
                        LID = Convert.ToString(longIDkp2.Value);
                        SID = shortIDkp2.Text;
                        showFaultyForType(typeKP2.Text);
                        break;

                    case 3:
                        LID = Convert.ToString(longIDkp3.Value);
                        SID = shortIDkp3.Text;
                        showFaultyForType(typeKP3.Text);
                        break;

                    case 4:
                        LID = Convert.ToString(longIDkp4.Value);
                        SID = shortIDkp4.Text;
                        showFaultyForType(typeKP4.Text);
                        break;

                    case 5:
                        LID = Convert.ToString(longIDkp5.Value);
                        SID = shortIDkp5.Text;
                        showFaultyForType(typeKP5.Text);
                        break;

                    case 6:
                        LID = Convert.ToString(longIDkp6.Value);
                        SID = shortIDkp6.Text;
                        showFaultyForType(typeKP6.Text);
                        break;

                    case 7:
                        LID = Convert.ToString(longIDkp7.Value);
                        SID = shortIDkp7.Text;
                        showFaultyForType(typeKP7.Text);
                        break;

                    case 8:
                        LID = Convert.ToString(longIDkp8.Value);
                        SID = shortIDkp8.Text;
                        showFaultyForType(typeKP8.Text);
                        break;

                    case 9:
                        LID = Convert.ToString(longIDkp9.Value);
                        SID = shortIDkp9.Text;
                        showFaultyForType(typeKP9.Text);
                        break;

                    case 10:
                        LID = Convert.ToString(longIDkp10.Value);
                        SID = shortIDkp10.Text;
                        showFaultyForType(typeKP10.Text);
                        break;

                    case 11:
                        LID = Convert.ToString(longIDkp11.Value);
                        SID = shortIDkp11.Text;
                        showFaultyForType(typeKP11.Text);
                        break;

                    case 12:
                        LID = Convert.ToString(longIDkp12.Value);
                        SID = shortIDkp12.Text;
                        showFaultyForType(typeKP12.Text);
                        break;

                    case 13:
                        LID = Convert.ToString(longIDkp13.Value);
                        SID = shortIDkp13.Text;
                        showFaultyForType(typeKP13.Text);
                        break;

                    case 14:
                        LID = Convert.ToString(longIDkp14.Value);
                        SID = shortIDkp14.Text;
                        showFaultyForType(typeKP14.Text);
                        break;

                    case 15:
                        LID = Convert.ToString(longIDkp15.Value);
                        SID = shortIDkp15.Text;
                        showFaultyForType(typeKP15.Text);
                        break;

                    case 16:
                        LID = Convert.ToString(longIDkp16.Value);
                        SID = shortIDkp16.Text;
                        showFaultyForType(typeKP16.Text);
                        break;

                    case 17:
                        LID = Convert.ToString(longIDkp17.Value);
                        SID = shortIDkp17.Text;
                        showFaultyForType(typeKP17.Text);
                        break;

                    case 18:
                        LID = Convert.ToString(longIDkp18.Value);
                        SID = shortIDkp18.Text;
                        showFaultyForType(typeKP18.Text);
                        break;

                    case 19:
                        LID = Convert.ToString(longIDkp19.Value);
                        SID = shortIDkp19.Text;
                        showFaultyForType(typeKP19.Text);
                        break;

                    case 20:
                        LID = Convert.ToString(longIDkp20.Value);
                        SID = shortIDkp20.Text;
                        showFaultyForType(typeKP20.Text);
                        break;

                    case 21:
                        LID = Convert.ToString(longIDkp21.Value);
                        SID = shortIDkp21.Text;
                        showFaultyForType(typeKP21.Text);
                        break;

                    case 22:
                        LID = Convert.ToString(longIDkp22.Value);
                        SID = shortIDkp22.Text;
                        showFaultyForType(typeKP22.Text);
                        break;

                    case 23:
                        LID = Convert.ToString(longIDkp23.Value);
                        SID = shortIDkp23.Text;
                        showFaultyForType(typeKP23.Text);
                        break;

                    case 24:
                        LID = Convert.ToString(longIDkp24.Value);
                        SID = shortIDkp24.Text;
                        showFaultyForType(typeKP24.Text);
                        break;

                    case 25:
                        LID = Convert.ToString(longIDkp25.Value);
                        SID = shortIDkp25.Text;
                        showFaultyForType(typeKP25.Text);
                        break;

                    case 26:
                        LID = Convert.ToString(longIDkp26.Value);
                        SID = shortIDkp26.Text;
                        showFaultyForType(typeKP26.Text);
                        break;

                    case 27:
                        LID = Convert.ToString(longIDkp27.Value);
                        SID = shortIDkp27.Text;
                        showFaultyForType(typeKP27.Text);
                        break;

                    case 28:
                        LID = Convert.ToString(longIDkp28.Value);
                        SID = shortIDkp28.Text;
                        showFaultyForType(typeKP28.Text);
                        break;

                    case 29:
                        LID = Convert.ToString(longIDkp29.Value);
                        SID = shortIDkp29.Text;
                        showFaultyForType(typeKP29.Text);
                        break;

                    case 30:
                        LID = Convert.ToString(longIDkp30.Value);
                        SID = shortIDkp30.Text;
                        showFaultyForType(typeKP30.Text);
                        break;

                    case 31:
                        LID = Convert.ToString(longIDkp31.Value);
                        SID = shortIDkp31.Text;
                        showFaultyForType(typeKP31.Text);
                        break;

                    case 32:
                        LID = Convert.ToString(longIDkp32.Value);
                        SID = shortIDkp32.Text;
                        showFaultyForType(typeKP32.Text);
                        break;
                }
            }
        }

        private void DisableAllFaults()
        {            
            deviceDoesnotEnrolledMenu.Visible = false;
            syncMenu.Visible = true;
            arm_awayMenu.Visible = true;
            arm_homeMenu.Visible = true;
            disarmMenu.Visible = true;
            arm_instantMenu.Visible = false;
            arm_latchkeyMenu.Visible = false;
            tamperMenu.Visible = false;
            lowbatteryMenu.Visible = true;
            arm_quickMenu.Visible = false;
            arm_home_quickMenu.Visible = false;
            PanicMenu.Visible = true;
            FireMenu.Visible = false;
            EmergencyMenu.Visible = false;
            aux_buttonMenu.Visible = false;
        }

        private void ContextlMenuGeneralFaulty_Opening(object sender, CancelEventArgs e)
        {          

            // Try to cast the sender to a ContextMenuStrip
            ContextMenuStrip menuItem = sender as ContextMenuStrip;
            if (menuItem != null)
            {
                // Get the control that is displaying this context menu
                Control sourceControl = menuItem.SourceControl;
                SidLidDefinition(sourceControl);
            }            
        }

        #region Enroll buttons click for Keyfobs

        //=================ENROLL KEYFOBS ONE BY ONE=====================================================

        private void enrollKF1_Click(object sender, EventArgs e)
        {
            enroll_remove(typeKF1, longIDkf1, enrollKF1, shortIDkf1, "1");
        }

        private void enrollKF2_Click(object sender, EventArgs e)
        {
            enroll_remove(typeKF2, longIDkf2, enrollKF2, shortIDkf2, "2");
        }

        private void enrollKF3_Click(object sender, EventArgs e)
        {
            enroll_remove(typeKF3, longIDkf3, enrollKF3, shortIDkf3, "3");
        }

        private void enrollKF4_Click(object sender, EventArgs e)
        {
            enroll_remove(typeKF4, longIDkf4, enrollKF4, shortIDkf4, "4");
        }

        private void enrollKF5_Click(object sender, EventArgs e)
        {
            enroll_remove(typeKF5, longIDkf5, enrollKF5, shortIDkf5, "5");
        }

        private void enrollKF6_Click(object sender, EventArgs e)
        {
            enroll_remove(typeKF6, longIDkf6, enrollKF6, shortIDkf6, "6");
        }

        private void enrollKF7_Click(object sender, EventArgs e)
        {
            enroll_remove(typeKF7, longIDkf7, enrollKF7, shortIDkf7, "7");
        }

        private void enrollKF8_Click(object sender, EventArgs e)
        {
            enroll_remove(typeKF8, longIDkf8, enrollKF8, shortIDkf8, "8");
        }

        private void enrollKF9_Click(object sender, EventArgs e)
        {
            enroll_remove(typeKF9, longIDkf9, enrollKF9, shortIDkf9, "9");
        }

        private void enrollKF10_Click(object sender, EventArgs e)
        {
            enroll_remove(typeKF10, longIDkf10, enrollKF10, shortIDkf10, "10");
        }

        private void enrollKF11_Click(object sender, EventArgs e)
        {
            enroll_remove(typeKF11, longIDkf11, enrollKF11, shortIDkf11, "11");
        }

        private void enrollKF12_Click(object sender, EventArgs e)
        {
            enroll_remove(typeKF12, longIDkf12, enrollKF12, shortIDkf12, "12");
        }

        private void enrollKF13_Click(object sender, EventArgs e)
        {
            enroll_remove(typeKF13, longIDkf13, enrollKF13, shortIDkf13, "13");
        }

        private void enrollKF14_Click(object sender, EventArgs e)
        {
            enroll_remove(typeKF14, longIDkf14, enrollKF14, shortIDkf14, "14");
        }

        private void enrollKF15_Click(object sender, EventArgs e)
        {
            enroll_remove(typeKF15, longIDkf15, enrollKF15, shortIDkf15, "15");
        }

        private void enrollKF16_Click(object sender, EventArgs e)
        {
            enroll_remove(typeKF16, longIDkf16, enrollKF16, shortIDkf16, "16");
        }

        private void enrollKF17_Click(object sender, EventArgs e)
        {
            enroll_remove(typeKF17, longIDkf17, enrollKF17, shortIDkf17, "17");
        }

        private void enrollKF18_Click(object sender, EventArgs e)
        {
            enroll_remove(typeKF18, longIDkf18, enrollKF18, shortIDkf18, "18");
        }

        private void enrollKF19_Click(object sender, EventArgs e)
        {
            enroll_remove(typeKF19, longIDkf19, enrollKF19, shortIDkf19, "19");
        }

        private void enrollKF20_Click(object sender, EventArgs e)
        {
            enroll_remove(typeKF20, longIDkf20, enrollKF20, shortIDkf20, "20");
        }

        private void enrollKF21_Click(object sender, EventArgs e)
        {
            enroll_remove(typeKF21, longIDkf21, enrollKF21, shortIDkf21, "21");
        }

        private void enrollKF22_Click(object sender, EventArgs e)
        {
            enroll_remove(typeKF22, longIDkf22, enrollKF22, shortIDkf22, "22");
        }

        private void enrollKF23_Click(object sender, EventArgs e)
        {
            enroll_remove(typeKF23, longIDkf23, enrollKF23, shortIDkf23, "23");
        }

        private void enrollKF24_Click(object sender, EventArgs e)
        {
            enroll_remove(typeKF24, longIDkf24, enrollKF24, shortIDkf24, "24");
        }

        private void enrollKF25_Click(object sender, EventArgs e)
        {
            enroll_remove(typeKF25, longIDkf25, enrollKF25, shortIDkf25, "25");
        }

        private void enrollKF26_Click(object sender, EventArgs e)
        {
            enroll_remove(typeKF26, longIDkf26, enrollKF26, shortIDkf26, "26");
        }

        private void enrollKF27_Click(object sender, EventArgs e)
        {
            enroll_remove(typeKF27, longIDkf27, enrollKF27, shortIDkf27, "27");
        }

        private void enrollKF28_Click(object sender, EventArgs e)
        {
            enroll_remove(typeKF28, longIDkf28, enrollKF28, shortIDkf28, "28");
        }

        private void enrollKF29_Click(object sender, EventArgs e)
        {
            enroll_remove(typeKF29, longIDkf29, enrollKF29, shortIDkf29, "29");
        }

        private void enrollKF30_Click(object sender, EventArgs e)
        {
            enroll_remove(typeKF30, longIDkf30, enrollKF30, shortIDkf30, "30");
        }

        private void enrollKF31_Click(object sender, EventArgs e)
        {
            enroll_remove(typeKF31, longIDkf31, enrollKF31, shortIDkf31, "31");
        }

        private void enrollKF32_Click(object sender, EventArgs e)
        {
            enroll_remove(typeKF32, longIDkf32, enrollKF32, shortIDkf32, "32");
        }

        #endregion

        #region Enroll buttons click for Keypads

        //=================ENROLL KEYPADS ONE BY ONE=====================================================

        private void enrollKP1_Click(object sender, EventArgs e)
        {
            enroll_remove(typeKP1, longIDkp1, enrollKP1, shortIDkp1, "1");
        }

        private void enrollKP2_Click_1(object sender, EventArgs e)
        {
            enroll_remove(typeKP2, longIDkp2, enrollKP2, shortIDkp2, "2");
        }

        private void enrollKP3_Click_1(object sender, EventArgs e)
        {
            enroll_remove(typeKP3, longIDkp3, enrollKP3, shortIDkp3, "3");
        }

        private void enrollKP4_Click_1(object sender, EventArgs e)
        {
            enroll_remove(typeKP4, longIDkp4, enrollKP4, shortIDkp4, "4");
        }

        private void enrollKP5_Click_1(object sender, EventArgs e)
        {
            enroll_remove(typeKP5, longIDkp5, enrollKP5, shortIDkp5, "5");
        }

        private void enrollKP6_Click_1(object sender, EventArgs e)
        {
            enroll_remove(typeKP6, longIDkp6, enrollKP6, shortIDkp6, "6");
        }

        private void enrollKP7_Click_1(object sender, EventArgs e)
        {
            enroll_remove(typeKP7, longIDkp7, enrollKP7, shortIDkp7, "7");
        }

        private void enrollKP8_Click_1(object sender, EventArgs e)
        {
            enroll_remove(typeKP8, longIDkp8, enrollKP8, shortIDkp8, "8");
        }

        private void enrollKP9_Click_1(object sender, EventArgs e)
        {
            enroll_remove(typeKP9, longIDkp9, enrollKP9, shortIDkp9, "9");
        }

        private void enrollKP10_Click_1(object sender, EventArgs e)
        {
            enroll_remove(typeKP10, longIDkp10, enrollKP10, shortIDkp10, "10");
        }

        private void enrollKP11_Click_1(object sender, EventArgs e)
        {
            enroll_remove(typeKP11, longIDkp11, enrollKP11, shortIDkp11, "11");
        }

        private void enrollKP12_Click_1(object sender, EventArgs e)
        {
            enroll_remove(typeKP12, longIDkp12, enrollKP12, shortIDkp12, "12");
        }

        private void enrollKP13_Click_1(object sender, EventArgs e)
        {
            enroll_remove(typeKP13, longIDkp13, enrollKP13, shortIDkp13, "13");
        }

        private void enrollKP14_Click_1(object sender, EventArgs e)
        {
            enroll_remove(typeKP14, longIDkp14, enrollKP14, shortIDkp14, "14");
        }

        private void enrollKP15_Click_1(object sender, EventArgs e)
        {
            enroll_remove(typeKP15, longIDkp15, enrollKP15, shortIDkp15, "15");
        }

        private void enrollKP16_Click_1(object sender, EventArgs e)
        {
            enroll_remove(typeKP16, longIDkp16, enrollKP16, shortIDkp16, "16");
        }

        private void enrollKP17_Click(object sender, EventArgs e)
        {
            enroll_remove(typeKP17, longIDkp17, enrollKP17, shortIDkp17, "17");
        }

        private void enrollKP18_Click(object sender, EventArgs e)
        {
            enroll_remove(typeKP18, longIDkp18, enrollKP18, shortIDkp18, "18");
        }

        private void enrollKP19_Click_1(object sender, EventArgs e)
        {
            enroll_remove(typeKP19, longIDkp19, enrollKP19, shortIDkp19, "19");
        }

        private void enrollKP20_Click_1(object sender, EventArgs e)
        {
            enroll_remove(typeKP20, longIDkp20, enrollKP20, shortIDkp20, "20");
        }

        private void enrollKP21_Click_1(object sender, EventArgs e)
        {
            enroll_remove(typeKP21, longIDkp21, enrollKP21, shortIDkp21, "21");
        }

        private void enrollKP22_Click_1(object sender, EventArgs e)
        {
            enroll_remove(typeKP22, longIDkp22, enrollKP22, shortIDkp22, "22");
        }

        private void enrollKP23_Click_1(object sender, EventArgs e)
        {
            enroll_remove(typeKP23, longIDkp23, enrollKP23, shortIDkp23, "23");
        }

        private void enrollKP24_Click_1(object sender, EventArgs e)
        {
            enroll_remove(typeKP24, longIDkp24, enrollKP24, shortIDkp24, "24");
        }

        private void enrollKP25_Click_1(object sender, EventArgs e)
        {
            enroll_remove(typeKP25, longIDkp25, enrollKP25, shortIDkp25, "25");
        }

        private void enrollKP26_Click_1(object sender, EventArgs e)
        {
            enroll_remove(typeKP26, longIDkp26, enrollKP26, shortIDkp26, "26");
        }

        private void enrollKP27_Click_1(object sender, EventArgs e)
        {
            enroll_remove(typeKP27, longIDkp27, enrollKP27, shortIDkp27, "27");
        }

        private void enrollKP28_Click_1(object sender, EventArgs e)
        {
            enroll_remove(typeKP28, longIDkp28, enrollKP28, shortIDkp28, "28");
        }

        private void enrollKP29_Click_1(object sender, EventArgs e)
        {
            enroll_remove(typeKP29, longIDkp29, enrollKP29, shortIDkp29, "29");
        }

        private void enrollKP30_Click_1(object sender, EventArgs e)
        {
            enroll_remove(typeKP30, longIDkp30, enrollKP30, shortIDkp30, "30");
        }

        private void enrollKP31_Click_1(object sender, EventArgs e)
        {
            enroll_remove(typeKP31, longIDkp31, enrollKP31, shortIDkp31, "31");
        }

        private void enrollKP32_Click_1(object sender, EventArgs e)
        {
            enroll_remove(typeKP32, longIDkp32, enrollKP32, shortIDkp32, "32");
        }

        #endregion

        #region All faulty methods

        //====================== ALL FAULTY FUNCTIONS ========================================

        private void update(string lid, string sid)
        {
            send.update(sid, lid);
        }

        private void open_tamper(string lid, string sid)
        {
            send.open_tamper(sid, lid);
        }

        private void close_tamper(string lid, string sid)
        {
            send.close_tamper(sid, lid);
        }

        private void open_low_bat(string lid, string sid)
        {
            send.open_low_bat(sid, lid);
        }

        private void close_low_bat(string lid, string sid)
        {
            send.close_low_bat(sid, lid);
        }

        private void fire(string lid, string sid)
        {
            send.fire(sid, lid);
        }

        private void panic(string lid, string sid)
        {
            send.panic(sid, lid);
        }

        private void emergency(string lid, string sid)
        {
            send.emergency(sid, lid);
        }

        private void arm_away(string lid, string sid, string arm_code)
        {
            send.arm_away(sid, lid, arm_code, "0");
        }

        private void arm_home(string lid, string sid, string arm_code)
        {
            send.arm_home(sid, lid, arm_code, "0");
        }

        private void disarm(string lid, string sid, string arm_code)
        {
            send.disarm(sid, lid, arm_code, "0");
        }

        private void arm_instant(string lid, string sid, string arm_code)
        {
            send.arm_instant(sid, lid, arm_code, "0");
        }

        private void arm_latchkey(string lid, string sid, string arm_code)
        {
            send.arm_latchkey(sid, lid, arm_code, "0");
        }

        private void arm_quick(string lid, string sid, string arm_code)
        {
            send.arm_quick(sid, lid, arm_code, "0");
        }

        private void arm_home_quick(string lid, string sid, string arm_code)
        {
            send.arm_home_quick(sid, lid, arm_code, "0");
        }

        private void aux_button(string lid, string sid)
        {
            send.aux_button(sid, lid);
        }

        #endregion

        #region ALL CONTEXT MENU ITEMS CLICK

        //===================== ALL CONTEXT MENU ITEMS CLICK =================================

        private void syncMenu_Click(object sender, EventArgs e)
        {
            update(LID, SID);
        }

        private void arm_awayMenu_Click(object sender, EventArgs e)
        {
            arm_away(LID, SID, code);
        }

        private void arm_homeMenu_Click(object sender, EventArgs e)
        {
            arm_home(LID, SID, code);
        }

        private void disarmMenu_Click(object sender, EventArgs e)
        {
            disarm(LID, SID, code);
        }

        private void arm_instantMenu_Click(object sender, EventArgs e)
        {
            arm_instant(LID, SID, code);
        }

        private void arm_latchkeyMenu_Click(object sender, EventArgs e)
        {
            arm_latchkey(LID, SID, code);
        }

        private void tamperopenMenu_Click(object sender, EventArgs e)
        {
            open_tamper(LID, SID);
        }

        private void tamperrestoreMenu_Click(object sender, EventArgs e)
        {
            close_tamper(LID, SID);
        }

        private void openLowBatteryMenu_Click(object sender, EventArgs e)
        {
            open_low_bat(LID, SID);
        }

        private void restoreLowBatteryMenu_Click(object sender, EventArgs e)
        {
            close_low_bat(LID, SID);
        }

        private void arm_quickMenu_Click(object sender, EventArgs e)
        {
            arm_quick(LID, SID, code);
        }

        private void arm_home_quickMenu_Click(object sender, EventArgs e)
        {
            arm_home_quick(LID, SID, code);
        }

        private void PanicMenu_Click(object sender, EventArgs e)
        {
            panic(LID, SID);
        }

        private void FireMenu_Click(object sender, EventArgs e)
        {
            fire(LID, SID);
        }

        private void EmergencyMenu_Click(object sender, EventArgs e)
        {
            emergency(LID, SID);
        }

        private void aux_buttonMenu_Click(object sender, EventArgs e)
        {
            aux_button(LID, SID);
        }

        #endregion

        private void EnrollAllKeyfobsMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("All Keyfobs(32) will be enrolled", "Enrolling keyfobs...", MessageBoxButtons.OK, MessageBoxIcon.Information);

            try
            {
                send.enroll("KEYFOB", "1000");
                Thread.Sleep(200);
                send.enroll("KEYFOB_235", "1000");
                Thread.Sleep(200);
                send.enroll("KEYFOB", "1001");
                Thread.Sleep(200);
                send.enroll("KEYFOB_235", "1001");
                Thread.Sleep(200);
                send.enroll("KEYFOB", "1002");
                Thread.Sleep(200);
                send.enroll("KEYFOB_235", "1002");
                Thread.Sleep(200);
                send.enroll("KEYFOB", "1003");
                Thread.Sleep(200);
                send.enroll("KEYFOB_235", "1003");
                Thread.Sleep(200);
                send.enroll("KEYFOB", "1004");
                Thread.Sleep(200);
                send.enroll("KEYFOB_235", "1004");
                Thread.Sleep(200);
                send.enroll("KEYFOB", "1005");
                Thread.Sleep(200);
                send.enroll("KEYFOB_235", "1005");
                Thread.Sleep(200);
                send.enroll("KEYFOB", "1006");
                Thread.Sleep(200);
                send.enroll("KEYFOB_235", "1006");
                Thread.Sleep(200);
                send.enroll("KEYFOB", "1007");
                Thread.Sleep(200);
                send.enroll("KEYFOB_235", "1007");
                Thread.Sleep(200);
                send.enroll("KEYFOB", "1008");
                Thread.Sleep(200);
                send.enroll("KEYFOB_235", "1008");
                Thread.Sleep(200);
                send.enroll("KEYFOB", "1009");
                Thread.Sleep(200);
                send.enroll("KEYFOB_235", "1009");
                Thread.Sleep(200);
                send.enroll("KEYFOB", "1010");
                Thread.Sleep(200);
                send.enroll("KEYFOB_235", "1010");
                Thread.Sleep(200);
                send.enroll("KEYFOB", "1011");
                Thread.Sleep(200);
                send.enroll("KEYFOB_235", "1011");
                Thread.Sleep(200);
                send.enroll("KEYFOB", "1012");
                Thread.Sleep(200);
                send.enroll("KEYFOB_235", "1012");
                Thread.Sleep(200);
                send.enroll("KEYFOB", "1013");
                Thread.Sleep(200);
                send.enroll("KEYFOB_235", "1013");
                Thread.Sleep(200);
                send.enroll("KEYFOB", "1014");
                Thread.Sleep(200);
                send.enroll("KEYFOB_235", "1014");
                Thread.Sleep(200);
                send.enroll("KEYFOB", "1015");
                Thread.Sleep(200);
                send.enroll("KEYFOB_235", "1015");
                Thread.Sleep(200);
            }
            catch (XmlRpcInvalidXmlRpcException)
            {

            }

            statusLabel.Text = "Ready";
            GetAllDevice();

            MessageBox.Show("All keyfobs enrolled", "Enrolling keyfobs...", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void EnrollAllKeypadsMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("All Keypads(32) will be enrolled", "Enrolling keypads...", MessageBoxButtons.OK, MessageBoxIcon.Information);

            try
            {
                send.enroll("KP_140", "1000");
                Thread.Sleep(200);
                send.enroll("KP_141", "1000");
                Thread.Sleep(200);
                send.enroll("KP_160_STATION", "1000");
                Thread.Sleep(200);
                send.enroll("KP_140", "1001");
                Thread.Sleep(200);
                send.enroll("KP_141", "1001");
                Thread.Sleep(200);
                send.enroll("KP_160_STATION", "1001");
                Thread.Sleep(200);
                send.enroll("KP_140", "1002");
                Thread.Sleep(200);
                send.enroll("KP_141", "1002");
                Thread.Sleep(200);
                send.enroll("KP_160_STATION", "1002");
                Thread.Sleep(200);
                send.enroll("KP_140", "1003");
                Thread.Sleep(200);
                send.enroll("KP_141", "1003");
                Thread.Sleep(200);
                send.enroll("KP_160_STATION", "1003");
                Thread.Sleep(200);
                send.enroll("KP_140", "1004");
                Thread.Sleep(200);
                send.enroll("KP_141", "1004");
                Thread.Sleep(200);
                send.enroll("KP_160_STATION", "1004");
                Thread.Sleep(200);
                send.enroll("KP_140", "1005");
                Thread.Sleep(200);
                send.enroll("KP_141", "1005");
                Thread.Sleep(200);
                send.enroll("KP_160_STATION", "1005");
                Thread.Sleep(200);
                send.enroll("KP_140", "1006");
                Thread.Sleep(200);
                send.enroll("KP_141", "1006");
                Thread.Sleep(200);
                send.enroll("KP_160_STATION", "1006");
                Thread.Sleep(200);
                send.enroll("KP_140", "1007");
                Thread.Sleep(200);
                send.enroll("KP_141", "1007");
                Thread.Sleep(200);
                send.enroll("KP_160_STATION", "1007");
                Thread.Sleep(200);
                send.enroll("KP_140", "1008");
                Thread.Sleep(200);
                send.enroll("KP_141", "1008");
                Thread.Sleep(200);
                send.enroll("KP_160_STATION", "1008");
                Thread.Sleep(200);
                send.enroll("KP_140", "1009");
                Thread.Sleep(200);
                send.enroll("KP_141", "1009");
                Thread.Sleep(200);
                send.enroll("KP_160_STATION", "1009");
                Thread.Sleep(200);
                send.enroll("KP_140", "1010");
                Thread.Sleep(200);
                send.enroll("KP_141", "1010");
                Thread.Sleep(200);
                
            }
            catch (XmlRpcInvalidXmlRpcException)
            {

            }

            statusLabel.Text = "Ready";
            GetAllDevice();

            MessageBox.Show("All keypads enrolled", "Enrolling keypads...", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void RemoveAllKeyfobsMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure to remove all keyfobs? It takes about 1 minute.", "Removing keyfobs...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                string[] allKeyfobs = {shortIDkf1.Text, Convert.ToString(longIDkf1.Value),
                                  shortIDkf2.Text, Convert.ToString(longIDkf2.Value),
                                  shortIDkf3.Text, Convert.ToString(longIDkf3.Value), 
                                  shortIDkf4.Text, Convert.ToString(longIDkf4.Value),
                                  shortIDkf5.Text, Convert.ToString(longIDkf5.Value),
                                  shortIDkf6.Text, Convert.ToString(longIDkf6.Value), 
                                  shortIDkf7.Text, Convert.ToString(longIDkf7.Value),
                                  shortIDkf8.Text, Convert.ToString(longIDkf8.Value),
                                  shortIDkf9.Text, Convert.ToString(longIDkf9.Value),
                                  shortIDkf10.Text, Convert.ToString(longIDkf10.Value),
                                  shortIDkf11.Text, Convert.ToString(longIDkf11.Value),
                                  shortIDkf12.Text, Convert.ToString(longIDkf12.Value),
                                  shortIDkf13.Text, Convert.ToString(longIDkf13.Value), 
                                  shortIDkf14.Text, Convert.ToString(longIDkf14.Value),
                                  shortIDkf15.Text, Convert.ToString(longIDkf15.Value),
                                  shortIDkf16.Text, Convert.ToString(longIDkf16.Value), 
                                  shortIDkf17.Text, Convert.ToString(longIDkf17.Value),
                                  shortIDkf18.Text, Convert.ToString(longIDkf18.Value),
                                  shortIDkf19.Text, Convert.ToString(longIDkf19.Value),
                                  shortIDkf20.Text, Convert.ToString(longIDkf20.Value),
                                  shortIDkf21.Text, Convert.ToString(longIDkf21.Value),
                                  shortIDkf22.Text, Convert.ToString(longIDkf22.Value),
                                  shortIDkf23.Text, Convert.ToString(longIDkf23.Value), 
                                  shortIDkf24.Text, Convert.ToString(longIDkf24.Value),
                                  shortIDkf25.Text, Convert.ToString(longIDkf25.Value),
                                  shortIDkf26.Text, Convert.ToString(longIDkf26.Value), 
                                  shortIDkf27.Text, Convert.ToString(longIDkf27.Value),
                                  shortIDkf28.Text, Convert.ToString(longIDkf28.Value),
                                  shortIDkf29.Text, Convert.ToString(longIDkf29.Value),
                                  shortIDkf30.Text, Convert.ToString(longIDkf30.Value),
                                  shortIDkf31.Text, Convert.ToString(longIDkf31.Value),
                                  shortIDkf32.Text, Convert.ToString(longIDkf32.Value)};

                for (int i = 0; i < allKeyfobs.Length; i = i + 2)
                {
                    if (allKeyfobs[i] != "sid")
                        send.remove_device(allKeyfobs[i], allKeyfobs[i + 1]);
                }
                MessageBox.Show("All keyfobs removed", "Removing keyfobs...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            GetAllDevice();
        }

        private void RemoveAllKeypadsMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure to remove all keypads? It takes about 1 minute.", "Removing keypads...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                string[] allKepads = {shortIDkp1.Text, Convert.ToString(longIDkp1.Value),
                                  shortIDkp2.Text, Convert.ToString(longIDkp2.Value),
                                  shortIDkp3.Text, Convert.ToString(longIDkp3.Value), 
                                  shortIDkp4.Text, Convert.ToString(longIDkp4.Value),
                                  shortIDkp5.Text, Convert.ToString(longIDkp5.Value),
                                  shortIDkp6.Text, Convert.ToString(longIDkp6.Value), 
                                  shortIDkp7.Text, Convert.ToString(longIDkp7.Value),
                                  shortIDkp8.Text, Convert.ToString(longIDkp8.Value),
                                  shortIDkp9.Text, Convert.ToString(longIDkp9.Value),
                                  shortIDkp10.Text, Convert.ToString(longIDkp10.Value),
                                  shortIDkp11.Text, Convert.ToString(longIDkp11.Value),
                                  shortIDkp12.Text, Convert.ToString(longIDkp12.Value),
                                  shortIDkp13.Text, Convert.ToString(longIDkp13.Value), 
                                  shortIDkp14.Text, Convert.ToString(longIDkp14.Value),
                                  shortIDkp15.Text, Convert.ToString(longIDkp15.Value),
                                  shortIDkp16.Text, Convert.ToString(longIDkp16.Value), 
                                  shortIDkp17.Text, Convert.ToString(longIDkp17.Value),
                                  shortIDkp18.Text, Convert.ToString(longIDkp18.Value),
                                  shortIDkp19.Text, Convert.ToString(longIDkp19.Value),
                                  shortIDkp20.Text, Convert.ToString(longIDkp20.Value),
                                  shortIDkp21.Text, Convert.ToString(longIDkp21.Value),
                                  shortIDkp22.Text, Convert.ToString(longIDkp22.Value),
                                  shortIDkp23.Text, Convert.ToString(longIDkp23.Value), 
                                  shortIDkp24.Text, Convert.ToString(longIDkp24.Value),
                                  shortIDkp25.Text, Convert.ToString(longIDkp25.Value),
                                  shortIDkp26.Text, Convert.ToString(longIDkp26.Value), 
                                  shortIDkp27.Text, Convert.ToString(longIDkp27.Value),
                                  shortIDkp28.Text, Convert.ToString(longIDkp28.Value),
                                  shortIDkp29.Text, Convert.ToString(longIDkp29.Value),
                                  shortIDkp30.Text, Convert.ToString(longIDkp30.Value),
                                  shortIDkp31.Text, Convert.ToString(longIDkp31.Value),
                                  shortIDkp32.Text, Convert.ToString(longIDkp32.Value)};

                for (int i = 0; i < allKepads.Length; i = i + 2)
                {
                    if (allKepads[i] != "sid")
                        send.remove_device(allKepads[i], allKepads[i + 1]);
                }
                MessageBox.Show("All keypads removed", "Removing keypads...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            GetAllDevice();
        }
        
    }
}