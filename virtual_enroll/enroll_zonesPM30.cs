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
    //comment

    public partial class enroll_zonesPM30 : Form
    {
        public enroll_zonesPM30()
        {
            InitializeComponent();
        }

        string SID, LID;
        SendRequests.ISend send = (SendRequests.ISend)XmlRpcProxyGen.Create(typeof(SendRequests.ISend));

        public void GetAllDevice()
        {
            try
            {
                typeZ1.Text = "";
                typeZ2.Text = "";
                typeZ3.Text = "";
                typeZ4.Text = "";
                typeZ5.Text = "";
                typeZ6.Text = "";
                typeZ7.Text = "";
                typeZ8.Text = "";
                typeZ9.Text = "";
                typeZ10.Text = "";
                typeZ11.Text = "";
                typeZ12.Text = "";
                typeZ13.Text = "";
                typeZ14.Text = "";
                typeZ15.Text = "";
                typeZ16.Text = "";
                typeZ17.Text = "";
                typeZ18.Text = "";
                typeZ19.Text = "";
                typeZ20.Text = "";
                typeZ21.Text = "";
                typeZ22.Text = "";
                typeZ23.Text = "";
                typeZ24.Text = "";
                typeZ25.Text = "";
                typeZ26.Text = "";
                typeZ27.Text = "";
                typeZ28.Text = "";
                typeZ29.Text = "";
                typeZ30.Text = "";
                typeZ31.Text = "";
                typeZ32.Text = "";
                typeZ33.Text = "";
                typeZ34.Text = "";
                typeZ35.Text = "";
                typeZ36.Text = "";
                typeZ37.Text = "";
                typeZ38.Text = "";
                typeZ39.Text = "";
                typeZ40.Text = "";
                typeZ41.Text = "";
                typeZ42.Text = "";
                typeZ43.Text = "";
                typeZ44.Text = "";
                typeZ45.Text = "";
                typeZ46.Text = "";
                typeZ47.Text = "";
                typeZ48.Text = "";
                typeZ49.Text = "";
                typeZ50.Text = "";
                typeZ51.Text = "";
                typeZ52.Text = "";
                typeZ53.Text = "";
                typeZ54.Text = "";
                typeZ55.Text = "";
                typeZ56.Text = "";
                typeZ57.Text = "";
                typeZ58.Text = "";
                typeZ59.Text = "";
                typeZ60.Text = "";
                typeZ61.Text = "";
                typeZ62.Text = "";
                typeZ63.Text = "";
                typeZ64.Text = "";

                longIDz1.Value = 1000;
                longIDz2.Value = 1000;
                longIDz3.Value = 1000;
                longIDz4.Value = 1000;
                longIDz5.Value = 1000;
                longIDz6.Value = 1000;
                longIDz7.Value = 1000;
                longIDz8.Value = 1000;
                longIDz9.Value = 1000;
                longIDz10.Value = 1000;
                longIDz11.Value = 1000;
                longIDz12.Value = 1000;
                longIDz13.Value = 1000;
                longIDz14.Value = 1000;
                longIDz15.Value = 1000;
                longIDz16.Value = 1000;
                longIDz17.Value = 1000;
                longIDz18.Value = 1000;
                longIDz19.Value = 1000;
                longIDz20.Value = 1000;
                longIDz21.Value = 1000;
                longIDz22.Value = 1000;
                longIDz23.Value = 1000;
                longIDz24.Value = 1000;
                longIDz25.Value = 1000;
                longIDz26.Value = 1000;
                longIDz27.Value = 1000;
                longIDz28.Value = 1000;
                longIDz29.Value = 1000;
                longIDz30.Value = 1000;
                longIDz31.Value = 1000;
                longIDz32.Value = 1000;
                longIDz33.Value = 1000;
                longIDz34.Value = 1000;
                longIDz35.Value = 1000;
                longIDz36.Value = 1000;
                longIDz37.Value = 1000;
                longIDz38.Value = 1000;
                longIDz39.Value = 1000;
                longIDz40.Value = 1000;
                longIDz41.Value = 1000;
                longIDz42.Value = 1000;
                longIDz43.Value = 1000;
                longIDz44.Value = 1000;
                longIDz45.Value = 1000;
                longIDz46.Value = 1000;
                longIDz47.Value = 1000;
                longIDz48.Value = 1000;
                longIDz49.Value = 1000;
                longIDz50.Value = 1000;
                longIDz51.Value = 1000;
                longIDz52.Value = 1000;
                longIDz53.Value = 1000;
                longIDz54.Value = 1000;
                longIDz55.Value = 1000;
                longIDz56.Value = 1000;
                longIDz57.Value = 1000;
                longIDz58.Value = 1000;
                longIDz59.Value = 1000;
                longIDz60.Value = 1000;
                longIDz61.Value = 1000;
                longIDz62.Value = 1000;
                longIDz63.Value = 1000;
                longIDz64.Value = 1000;

                longIDz1.Enabled = true;
                longIDz2.Enabled = true;
                longIDz3.Enabled = true;
                longIDz4.Enabled = true;
                longIDz5.Enabled = true;
                longIDz6.Enabled = true;
                longIDz7.Enabled = true;
                longIDz8.Enabled = true;
                longIDz9.Enabled = true;
                longIDz10.Enabled = true;
                longIDz11.Enabled = true;
                longIDz12.Enabled = true;
                longIDz13.Enabled = true;
                longIDz14.Enabled = true;
                longIDz15.Enabled = true;
                longIDz16.Enabled = true;
                longIDz17.Enabled = true;
                longIDz18.Enabled = true;
                longIDz19.Enabled = true;
                longIDz20.Enabled = true;
                longIDz21.Enabled = true;
                longIDz22.Enabled = true;
                longIDz23.Enabled = true;
                longIDz24.Enabled = true;
                longIDz25.Enabled = true;
                longIDz26.Enabled = true;
                longIDz27.Enabled = true;
                longIDz28.Enabled = true;
                longIDz29.Enabled = true;
                longIDz30.Enabled = true;
                longIDz31.Enabled = true;
                longIDz32.Enabled = true;
                longIDz33.Enabled = true;
                longIDz34.Enabled = true;
                longIDz35.Enabled = true;
                longIDz36.Enabled = true;
                longIDz37.Enabled = true;
                longIDz38.Enabled = true;
                longIDz39.Enabled = true;
                longIDz40.Enabled = true;
                longIDz41.Enabled = true;
                longIDz42.Enabled = true;
                longIDz43.Enabled = true;
                longIDz44.Enabled = true;
                longIDz45.Enabled = true;
                longIDz46.Enabled = true;
                longIDz47.Enabled = true;
                longIDz48.Enabled = true;
                longIDz49.Enabled = true;
                longIDz50.Enabled = true;
                longIDz51.Enabled = true;
                longIDz52.Enabled = true;
                longIDz53.Enabled = true;
                longIDz54.Enabled = true;
                longIDz55.Enabled = true;
                longIDz56.Enabled = true;
                longIDz57.Enabled = true;
                longIDz58.Enabled = true;
                longIDz59.Enabled = true;
                longIDz60.Enabled = true;
                longIDz61.Enabled = true;
                longIDz62.Enabled = true;
                longIDz63.Enabled = true;
                longIDz64.Enabled = true;

                enrollZ1.Text = "enroll";
                enrollZ2.Text = "enroll";
                enrollZ3.Text = "enroll";
                enrollZ4.Text = "enroll";
                enrollZ5.Text = "enroll";
                enrollZ6.Text = "enroll";
                enrollZ7.Text = "enroll";
                enrollZ8.Text = "enroll";
                enrollZ9.Text = "enroll";
                enrollZ10.Text = "enroll";
                enrollZ11.Text = "enroll";
                enrollZ12.Text = "enroll";
                enrollZ13.Text = "enroll";
                enrollZ14.Text = "enroll";
                enrollZ15.Text = "enroll";
                enrollZ16.Text = "enroll";
                enrollZ17.Text = "enroll";
                enrollZ18.Text = "enroll";
                enrollZ19.Text = "enroll";
                enrollZ20.Text = "enroll";
                enrollZ21.Text = "enroll";
                enrollZ22.Text = "enroll";
                enrollZ23.Text = "enroll";
                enrollZ24.Text = "enroll";
                enrollZ25.Text = "enroll";
                enrollZ26.Text = "enroll";
                enrollZ27.Text = "enroll";
                enrollZ28.Text = "enroll";
                enrollZ29.Text = "enroll";
                enrollZ30.Text = "enroll";
                enrollZ31.Text = "enroll";
                enrollZ32.Text = "enroll";
                enrollZ33.Text = "enroll";
                enrollZ34.Text = "enroll";
                enrollZ35.Text = "enroll";
                enrollZ36.Text = "enroll";
                enrollZ37.Text = "enroll";
                enrollZ38.Text = "enroll";
                enrollZ39.Text = "enroll";
                enrollZ40.Text = "enroll";
                enrollZ41.Text = "enroll";
                enrollZ42.Text = "enroll";
                enrollZ43.Text = "enroll";
                enrollZ44.Text = "enroll";
                enrollZ45.Text = "enroll";
                enrollZ46.Text = "enroll";
                enrollZ47.Text = "enroll";
                enrollZ48.Text = "enroll";
                enrollZ49.Text = "enroll";
                enrollZ50.Text = "enroll";
                enrollZ51.Text = "enroll";
                enrollZ52.Text = "enroll";
                enrollZ53.Text = "enroll";
                enrollZ54.Text = "enroll";
                enrollZ55.Text = "enroll";
                enrollZ56.Text = "enroll";
                enrollZ57.Text = "enroll";
                enrollZ58.Text = "enroll";
                enrollZ59.Text = "enroll";
                enrollZ60.Text = "enroll";
                enrollZ61.Text = "enroll";
                enrollZ62.Text = "enroll";
                enrollZ63.Text = "enroll";
                enrollZ64.Text = "enroll";

                typeZ1.Enabled = true;
                typeZ2.Enabled = true;
                typeZ3.Enabled = true;
                typeZ4.Enabled = true;
                typeZ5.Enabled = true;
                typeZ6.Enabled = true;
                typeZ7.Enabled = true;
                typeZ8.Enabled = true;
                typeZ9.Enabled = true;
                typeZ10.Enabled = true;
                typeZ11.Enabled = true;
                typeZ12.Enabled = true;
                typeZ13.Enabled = true;
                typeZ14.Enabled = true;
                typeZ15.Enabled = true;
                typeZ16.Enabled = true;
                typeZ17.Enabled = true;
                typeZ18.Enabled = true;
                typeZ19.Enabled = true;
                typeZ20.Enabled = true;
                typeZ21.Enabled = true;
                typeZ22.Enabled = true;
                typeZ23.Enabled = true;
                typeZ24.Enabled = true;
                typeZ25.Enabled = true;
                typeZ26.Enabled = true;
                typeZ27.Enabled = true;
                typeZ28.Enabled = true;
                typeZ29.Enabled = true;
                typeZ30.Enabled = true;
                typeZ31.Enabled = true;
                typeZ32.Enabled = true;
                typeZ33.Enabled = true;
                typeZ34.Enabled = true;
                typeZ35.Enabled = true;
                typeZ36.Enabled = true;
                typeZ37.Enabled = true;
                typeZ38.Enabled = true;
                typeZ39.Enabled = true;
                typeZ40.Enabled = true;
                typeZ41.Enabled = true;
                typeZ42.Enabled = true;
                typeZ43.Enabled = true;
                typeZ44.Enabled = true;
                typeZ45.Enabled = true;
                typeZ46.Enabled = true;
                typeZ47.Enabled = true;
                typeZ48.Enabled = true;
                typeZ49.Enabled = true;
                typeZ50.Enabled = true;
                typeZ51.Enabled = true;
                typeZ52.Enabled = true;
                typeZ53.Enabled = true;
                typeZ54.Enabled = true;
                typeZ55.Enabled = true;
                typeZ56.Enabled = true;
                typeZ57.Enabled = true;
                typeZ58.Enabled = true;
                typeZ59.Enabled = true;
                typeZ60.Enabled = true;
                typeZ61.Enabled = true;
                typeZ62.Enabled = true;
                typeZ63.Enabled = true;
                typeZ64.Enabled = true;

                shortIDz1.Text = "sid";
                shortIDz2.Text = "sid";
                shortIDz3.Text = "sid";
                shortIDz4.Text = "sid";
                shortIDz5.Text = "sid";
                shortIDz6.Text = "sid";
                shortIDz7.Text = "sid";
                shortIDz8.Text = "sid";
                shortIDz9.Text = "sid";
                shortIDz10.Text = "sid";
                shortIDz11.Text = "sid";
                shortIDz12.Text = "sid";
                shortIDz13.Text = "sid";
                shortIDz14.Text = "sid";
                shortIDz15.Text = "sid";
                shortIDz16.Text = "sid";
                shortIDz17.Text = "sid";
                shortIDz18.Text = "sid";
                shortIDz19.Text = "sid";
                shortIDz20.Text = "sid";
                shortIDz21.Text = "sid";
                shortIDz22.Text = "sid";
                shortIDz23.Text = "sid";
                shortIDz24.Text = "sid";
                shortIDz25.Text = "sid";
                shortIDz26.Text = "sid";
                shortIDz27.Text = "sid";
                shortIDz28.Text = "sid";
                shortIDz29.Text = "sid";
                shortIDz30.Text = "sid";
                shortIDz31.Text = "sid";
                shortIDz32.Text = "sid";
                shortIDz33.Text = "sid";
                shortIDz34.Text = "sid";
                shortIDz35.Text = "sid";
                shortIDz36.Text = "sid";
                shortIDz37.Text = "sid";
                shortIDz38.Text = "sid";
                shortIDz39.Text = "sid";
                shortIDz40.Text = "sid";
                shortIDz41.Text = "sid";
                shortIDz42.Text = "sid";
                shortIDz43.Text = "sid";
                shortIDz44.Text = "sid";
                shortIDz45.Text = "sid";
                shortIDz46.Text = "sid";
                shortIDz47.Text = "sid";
                shortIDz48.Text = "sid";
                shortIDz49.Text = "sid";
                shortIDz50.Text = "sid";
                shortIDz51.Text = "sid";
                shortIDz52.Text = "sid";
                shortIDz53.Text = "sid";
                shortIDz54.Text = "sid";
                shortIDz55.Text = "sid";
                shortIDz56.Text = "sid";
                shortIDz57.Text = "sid";
                shortIDz58.Text = "sid";
                shortIDz59.Text = "sid";
                shortIDz60.Text = "sid";
                shortIDz61.Text = "sid";
                shortIDz62.Text = "sid";
                shortIDz63.Text = "sid";
                shortIDz64.Text = "sid";
                
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

    //"CONTACT",
    //"CONTACT_AUX",
    //"MOTION_SENSOR",
    //"MOTION_CAMERA",
    //"SMOKE",
    //"SMOKE_HEAT",
    //"GAS",
    //"CO",
    //"FLOOD",
    //"TEMPERATURE",
    //"SMOKE_HEAT_TEMP",
    //"SHOCK_AUX",
    //"SHOCK_CONTACT",
    //"SHOCK_AUX_CONTACT",
    //"SHOCK_AUX_CONTACT_G2",
    //"TOWER30",
    //"TOWER32",
    //"TOWER20",
    //"OUTDOOR_SIREN",
    //"INDOOR_SIREN",
    //"KEYFOB",
    //"KEYFOB_235",
    //"KEYFOB_LCD",
    //"REPEATER",
    //"KP_140",
    //"KP_141",
    //"KP_160_STATION",
    //"KP_250",
    //"CLIP",
    //"GLASS_BREAK",
    //"VANISHING",
    //"FLOOD_551",
    //"PENDENT_PANIC_101",
    //"PANIC_102"

                DeviceInfo[] DevInfo;
                DevInfo = send.get_all_devices();
                                
                for (int i = 0; i < DevInfo.Length; i++)
                    {
                        if (DevInfo[i].type != "INDOOR_SIREN" && 
                            DevInfo[i].type != "OUTDOOR_SIREN" && 
                            DevInfo[i].type != "REPEATER" && 
                            DevInfo[i].type != "KEYFOB" && 
                            DevInfo[i].type != "KEYFOB_235" && 
                            DevInfo[i].type != "KEYFOB_LCD" && 
                            DevInfo[i].type != "KP_140" && 
                            DevInfo[i].type != "KP_141" && 
                            DevInfo[i].type != "KP_160_STATION" && 
                            DevInfo[i].type != "KP_250" &&
                            DevInfo[i].type != "PENDENT_PANIC_101" &&
                            DevInfo[i].type != "PANIC_102")
                        {
                            switch (Convert.ToInt32(DevInfo[i].num))
                            {
                                case 1:
                                    longIDz1.Text = DevInfo[i].lid;
                                    shortIDz1.Text = DevInfo[i].sid;
                                    typeZ1.Text = DevInfo[i].type;
                                    longIDz1.Enabled = false;
                                    typeZ1.Enabled = false;
                                    enrollZ1.Text = "remove";
                                    break;

                                case 2:
                                    longIDz2.Text = DevInfo[i].lid;
                                    shortIDz2.Text = DevInfo[i].sid;
                                    typeZ2.Text = DevInfo[i].type;
                                    longIDz2.Enabled = false;
                                    typeZ2.Enabled = false;
                                    enrollZ2.Text = "remove";
                                    break;

                                case 3:
                                    longIDz3.Text = DevInfo[i].lid;
                                    shortIDz3.Text = DevInfo[i].sid;
                                    typeZ3.Text = DevInfo[i].type;
                                    longIDz3.Enabled = false;
                                    typeZ3.Enabled = false;
                                    enrollZ3.Text = "remove";
                                    break;

                                case 4:
                                    longIDz4.Text = DevInfo[i].lid;
                                    shortIDz4.Text = DevInfo[i].sid;
                                    typeZ4.Text = DevInfo[i].type;
                                    longIDz4.Enabled = false;
                                    typeZ4.Enabled = false;
                                    enrollZ4.Text = "remove";
                                    break;

                                case 5:
                                    longIDz5.Text = DevInfo[i].lid;
                                    shortIDz5.Text = DevInfo[i].sid;
                                    typeZ5.Text = DevInfo[i].type;
                                    longIDz5.Enabled = false;
                                    typeZ5.Enabled = false;
                                    enrollZ5.Text = "remove";
                                    break;

                                case 6:
                                    longIDz6.Text = DevInfo[i].lid;
                                    shortIDz6.Text = DevInfo[i].sid;
                                    typeZ6.Text = DevInfo[i].type;
                                    longIDz6.Enabled = false;
                                    typeZ6.Enabled = false;
                                    enrollZ6.Text = "remove";
                                    break;

                                case 7:
                                    longIDz7.Text = DevInfo[i].lid;
                                    shortIDz7.Text = DevInfo[i].sid;
                                    typeZ7.Text = DevInfo[i].type;
                                    longIDz7.Enabled = false;
                                    typeZ7.Enabled = false;
                                    enrollZ7.Text = "remove";
                                    break;

                                case 8:
                                    longIDz8.Text = DevInfo[i].lid;
                                    shortIDz8.Text = DevInfo[i].sid;
                                    typeZ8.Text = DevInfo[i].type;
                                    longIDz8.Enabled = false;
                                    typeZ8.Enabled = false;
                                    enrollZ8.Text = "remove";
                                    break;

                                case 9:
                                    longIDz9.Text = DevInfo[i].lid;
                                    shortIDz9.Text = DevInfo[i].sid;
                                    typeZ9.Text = DevInfo[i].type;
                                    longIDz9.Enabled = false;
                                    typeZ9.Enabled = false;
                                    enrollZ9.Text = "remove";
                                    break;

                                case 10:
                                    longIDz10.Text = DevInfo[i].lid;
                                    shortIDz10.Text = DevInfo[i].sid;
                                    typeZ10.Text = DevInfo[i].type;
                                    longIDz10.Enabled = false;
                                    typeZ10.Enabled = false;
                                    enrollZ10.Text = "remove";
                                    break;

                                case 11:
                                    longIDz11.Text = DevInfo[i].lid;
                                    shortIDz11.Text = DevInfo[i].sid;
                                    typeZ11.Text = DevInfo[i].type;
                                    longIDz11.Enabled = false;
                                    typeZ11.Enabled = false;
                                    enrollZ11.Text = "remove";
                                    break;

                                case 12:
                                    longIDz12.Text = DevInfo[i].lid;
                                    shortIDz12.Text = DevInfo[i].sid;
                                    typeZ12.Text = DevInfo[i].type;
                                    longIDz12.Enabled = false;
                                    typeZ12.Enabled = false;
                                    enrollZ12.Text = "remove";
                                    break;

                                case 13:
                                    longIDz13.Text = DevInfo[i].lid;
                                    shortIDz13.Text = DevInfo[i].sid;
                                    typeZ13.Text = DevInfo[i].type;
                                    longIDz13.Enabled = false;
                                    typeZ13.Enabled = false;
                                    enrollZ13.Text = "remove";
                                    break;

                                case 14:
                                    longIDz14.Text = DevInfo[i].lid;
                                    shortIDz14.Text = DevInfo[i].sid;
                                    typeZ14.Text = DevInfo[i].type;
                                    longIDz14.Enabled = false;
                                    typeZ14.Enabled = false;
                                    enrollZ14.Text = "remove";
                                    break;

                                case 15:
                                    longIDz15.Text = DevInfo[i].lid;
                                    shortIDz15.Text = DevInfo[i].sid;
                                    typeZ15.Text = DevInfo[i].type;
                                    longIDz15.Enabled = false;
                                    typeZ15.Enabled = false;
                                    enrollZ15.Text = "remove";
                                    break;

                                case 16:
                                    longIDz16.Text = DevInfo[i].lid;
                                    shortIDz16.Text = DevInfo[i].sid;
                                    typeZ16.Text = DevInfo[i].type;
                                    longIDz16.Enabled = false;
                                    typeZ16.Enabled = false;
                                    enrollZ16.Text = "remove";
                                    break;

                                case 17:
                                    longIDz17.Text = DevInfo[i].lid;
                                    shortIDz17.Text = DevInfo[i].sid;
                                    typeZ17.Text = DevInfo[i].type;
                                    longIDz17.Enabled = false;
                                    typeZ17.Enabled = false;
                                    enrollZ17.Text = "remove";
                                    break;

                                case 18:
                                    longIDz18.Text = DevInfo[i].lid;
                                    shortIDz18.Text = DevInfo[i].sid;
                                    typeZ18.Text = DevInfo[i].type;
                                    longIDz18.Enabled = false;
                                    typeZ18.Enabled = false;
                                    enrollZ18.Text = "remove";
                                    break;

                                case 19:
                                    longIDz19.Text = DevInfo[i].lid;
                                    shortIDz19.Text = DevInfo[i].sid;
                                    typeZ19.Text = DevInfo[i].type;
                                    longIDz19.Enabled = false;
                                    typeZ19.Enabled = false;
                                    enrollZ19.Text = "remove";
                                    break;

                                case 20:
                                    longIDz20.Text = DevInfo[i].lid;
                                    shortIDz20.Text = DevInfo[i].sid;
                                    typeZ20.Text = DevInfo[i].type;
                                    longIDz20.Enabled = false;
                                    typeZ20.Enabled = false;
                                    enrollZ20.Text = "remove";
                                    break;

                                case 21:
                                    longIDz21.Text = DevInfo[i].lid;
                                    shortIDz21.Text = DevInfo[i].sid;
                                    typeZ21.Text = DevInfo[i].type;
                                    longIDz21.Enabled = false;
                                    typeZ21.Enabled = false;
                                    enrollZ21.Text = "remove";
                                    break;

                                case 22:
                                    longIDz22.Text = DevInfo[i].lid;
                                    shortIDz22.Text = DevInfo[i].sid;
                                    typeZ22.Text = DevInfo[i].type;
                                    longIDz22.Enabled = false;
                                    typeZ22.Enabled = false;
                                    enrollZ22.Text = "remove";
                                    break;

                                case 23:
                                    longIDz23.Text = DevInfo[i].lid;
                                    shortIDz23.Text = DevInfo[i].sid;
                                    typeZ23.Text = DevInfo[i].type;
                                    longIDz23.Enabled = false;
                                    typeZ23.Enabled = false;
                                    enrollZ23.Text = "remove";
                                    break;

                                case 24:
                                    longIDz24.Text = DevInfo[i].lid;
                                    shortIDz24.Text = DevInfo[i].sid;
                                    typeZ24.Text = DevInfo[i].type;
                                    longIDz24.Enabled = false;
                                    typeZ24.Enabled = false;
                                    enrollZ24.Text = "remove";
                                    break;

                                case 25:
                                    longIDz25.Text = DevInfo[i].lid;
                                    shortIDz25.Text = DevInfo[i].sid;
                                    typeZ25.Text = DevInfo[i].type;
                                    longIDz25.Enabled = false;
                                    typeZ25.Enabled = false;
                                    enrollZ25.Text = "remove";
                                    break;

                                case 26:
                                    longIDz26.Text = DevInfo[i].lid;
                                    shortIDz26.Text = DevInfo[i].sid;
                                    typeZ26.Text = DevInfo[i].type;
                                    longIDz26.Enabled = false;
                                    typeZ26.Enabled = false;
                                    enrollZ26.Text = "remove";
                                    break;

                                case 27:
                                    longIDz27.Text = DevInfo[i].lid;
                                    shortIDz27.Text = DevInfo[i].sid;
                                    typeZ27.Text = DevInfo[i].type;
                                    longIDz27.Enabled = false;
                                    typeZ27.Enabled = false;
                                    enrollZ27.Text = "remove";
                                    break;

                                case 28:
                                    longIDz28.Text = DevInfo[i].lid;
                                    shortIDz28.Text = DevInfo[i].sid;
                                    typeZ28.Text = DevInfo[i].type;
                                    longIDz28.Enabled = false;
                                    typeZ28.Enabled = false;
                                    enrollZ28.Text = "remove";
                                    break;

                                case 29:
                                    longIDz29.Text = DevInfo[i].lid;
                                    shortIDz29.Text = DevInfo[i].sid;
                                    typeZ29.Text = DevInfo[i].type;
                                    longIDz29.Enabled = false;
                                    typeZ29.Enabled = false;
                                    enrollZ29.Text = "remove";
                                    break;

                                case 30:
                                    longIDz30.Text = DevInfo[i].lid;
                                    shortIDz30.Text = DevInfo[i].sid;
                                    typeZ30.Text = DevInfo[i].type;
                                    longIDz30.Enabled = false;
                                    typeZ30.Enabled = false;
                                    enrollZ30.Text = "remove";
                                    break;

                                case 31:
                                    longIDz31.Text = DevInfo[i].lid;
                                    shortIDz31.Text = DevInfo[i].sid;
                                    typeZ31.Text = DevInfo[i].type;
                                    longIDz31.Enabled = false;
                                    typeZ31.Enabled = false;
                                    enrollZ31.Text = "remove";
                                    break;

                                case 32:
                                    longIDz32.Text = DevInfo[i].lid;
                                    shortIDz32.Text = DevInfo[i].sid;
                                    typeZ32.Text = DevInfo[i].type;
                                    longIDz32.Enabled = false;
                                    typeZ32.Enabled = false;
                                    enrollZ32.Text = "remove";
                                    break;

                                case 33:
                                    longIDz33.Text = DevInfo[i].lid;
                                    shortIDz33.Text = DevInfo[i].sid;
                                    typeZ33.Text = DevInfo[i].type;
                                    longIDz33.Enabled = false;
                                    typeZ33.Enabled = false;
                                    enrollZ33.Text = "remove";
                                    break;

                                case 34:
                                    longIDz34.Text = DevInfo[i].lid;
                                    shortIDz34.Text = DevInfo[i].sid;
                                    typeZ34.Text = DevInfo[i].type;
                                    longIDz34.Enabled = false;
                                    typeZ34.Enabled = false;
                                    enrollZ34.Text = "remove";
                                    break;

                                case 35:
                                    longIDz35.Text = DevInfo[i].lid;
                                    shortIDz35.Text = DevInfo[i].sid;
                                    typeZ35.Text = DevInfo[i].type;
                                    longIDz35.Enabled = false;
                                    typeZ35.Enabled = false;
                                    enrollZ35.Text = "remove";
                                    break;

                                case 36:
                                    longIDz36.Text = DevInfo[i].lid;
                                    shortIDz36.Text = DevInfo[i].sid;
                                    typeZ36.Text = DevInfo[i].type;
                                    longIDz36.Enabled = false;
                                    typeZ36.Enabled = false;
                                    enrollZ36.Text = "remove";
                                    break;

                                case 37:
                                    longIDz37.Text = DevInfo[i].lid;
                                    shortIDz37.Text = DevInfo[i].sid;
                                    typeZ37.Text = DevInfo[i].type;
                                    longIDz37.Enabled = false;
                                    typeZ37.Enabled = false;
                                    enrollZ37.Text = "remove";
                                    break;

                                case 38:
                                    longIDz38.Text = DevInfo[i].lid;
                                    shortIDz38.Text = DevInfo[i].sid;
                                    typeZ38.Text = DevInfo[i].type;
                                    longIDz38.Enabled = false;
                                    typeZ38.Enabled = false;
                                    enrollZ38.Text = "remove";
                                    break;

                                case 39:
                                    longIDz39.Text = DevInfo[i].lid;
                                    shortIDz39.Text = DevInfo[i].sid;
                                    typeZ39.Text = DevInfo[i].type;
                                    longIDz39.Enabled = false;
                                    typeZ39.Enabled = false;
                                    enrollZ39.Text = "remove";
                                    break;

                                case 40:
                                    longIDz40.Text = DevInfo[i].lid;
                                    shortIDz40.Text = DevInfo[i].sid;
                                    typeZ40.Text = DevInfo[i].type;
                                    longIDz40.Enabled = false;
                                    typeZ40.Enabled = false;
                                    enrollZ40.Text = "remove";
                                    break;

                                case 41:
                                    longIDz41.Text = DevInfo[i].lid;
                                    shortIDz41.Text = DevInfo[i].sid;
                                    typeZ41.Text = DevInfo[i].type;
                                    longIDz41.Enabled = false;
                                    typeZ41.Enabled = false;
                                    enrollZ41.Text = "remove";
                                    break;

                                case 42:
                                    longIDz42.Text = DevInfo[i].lid;
                                    shortIDz42.Text = DevInfo[i].sid;
                                    typeZ42.Text = DevInfo[i].type;
                                    longIDz42.Enabled = false;
                                    typeZ42.Enabled = false;
                                    enrollZ42.Text = "remove";
                                    break;

                                case 43:
                                    longIDz43.Text = DevInfo[i].lid;
                                    shortIDz43.Text = DevInfo[i].sid;
                                    typeZ43.Text = DevInfo[i].type;
                                    longIDz43.Enabled = false;
                                    typeZ43.Enabled = false;
                                    enrollZ43.Text = "remove";
                                    break;

                                case 44:
                                    longIDz44.Text = DevInfo[i].lid;
                                    shortIDz44.Text = DevInfo[i].sid;
                                    typeZ44.Text = DevInfo[i].type;
                                    longIDz44.Enabled = false;
                                    typeZ44.Enabled = false;
                                    enrollZ44.Text = "remove";
                                    break;

                                case 45:
                                    longIDz45.Text = DevInfo[i].lid;
                                    shortIDz45.Text = DevInfo[i].sid;
                                    typeZ45.Text = DevInfo[i].type;
                                    longIDz45.Enabled = false;
                                    typeZ45.Enabled = false;
                                    enrollZ45.Text = "remove";
                                    break;

                                case 46:
                                    longIDz46.Text = DevInfo[i].lid;
                                    shortIDz46.Text = DevInfo[i].sid;
                                    typeZ46.Text = DevInfo[i].type;
                                    longIDz46.Enabled = false;
                                    typeZ46.Enabled = false;
                                    enrollZ46.Text = "remove";
                                    break;

                                case 47:
                                    longIDz47.Text = DevInfo[i].lid;
                                    shortIDz47.Text = DevInfo[i].sid;
                                    typeZ47.Text = DevInfo[i].type;
                                    longIDz47.Enabled = false;
                                    typeZ47.Enabled = false;
                                    enrollZ47.Text = "remove";
                                    break;

                                case 48:
                                    longIDz48.Text = DevInfo[i].lid;
                                    shortIDz48.Text = DevInfo[i].sid;
                                    typeZ48.Text = DevInfo[i].type;
                                    longIDz48.Enabled = false;
                                    typeZ48.Enabled = false;
                                    enrollZ48.Text = "remove";
                                    break;

                                case 49:
                                    longIDz49.Text = DevInfo[i].lid;
                                    shortIDz49.Text = DevInfo[i].sid;
                                    typeZ49.Text = DevInfo[i].type;
                                    longIDz49.Enabled = false;
                                    typeZ49.Enabled = false;
                                    enrollZ49.Text = "remove";
                                    break;

                                case 50:
                                    longIDz50.Text = DevInfo[i].lid;
                                    shortIDz50.Text = DevInfo[i].sid;
                                    typeZ50.Text = DevInfo[i].type;
                                    longIDz50.Enabled = false;
                                    typeZ50.Enabled = false;
                                    enrollZ50.Text = "remove";
                                    break;

                                case 51:
                                    longIDz51.Text = DevInfo[i].lid;
                                    shortIDz51.Text = DevInfo[i].sid;
                                    typeZ51.Text = DevInfo[i].type;
                                    longIDz51.Enabled = false;
                                    typeZ51.Enabled = false;
                                    enrollZ51.Text = "remove";
                                    break;

                                case 52:
                                    longIDz52.Text = DevInfo[i].lid;
                                    shortIDz52.Text = DevInfo[i].sid;
                                    typeZ52.Text = DevInfo[i].type;
                                    longIDz52.Enabled = false;
                                    typeZ52.Enabled = false;
                                    enrollZ52.Text = "remove";
                                    break;

                                case 53:
                                    longIDz53.Text = DevInfo[i].lid;
                                    shortIDz53.Text = DevInfo[i].sid;
                                    typeZ53.Text = DevInfo[i].type;
                                    longIDz53.Enabled = false;
                                    typeZ53.Enabled = false;
                                    enrollZ53.Text = "remove";
                                    break;

                                case 54:
                                    longIDz54.Text = DevInfo[i].lid;
                                    shortIDz54.Text = DevInfo[i].sid;
                                    typeZ54.Text = DevInfo[i].type;
                                    longIDz54.Enabled = false;
                                    typeZ54.Enabled = false;
                                    enrollZ54.Text = "remove";
                                    break;

                                case 55:
                                    longIDz55.Text = DevInfo[i].lid;
                                    shortIDz55.Text = DevInfo[i].sid;
                                    typeZ55.Text = DevInfo[i].type;
                                    longIDz55.Enabled = false;
                                    typeZ55.Enabled = false;
                                    enrollZ55.Text = "remove";
                                    break;

                                case 56:
                                    longIDz56.Text = DevInfo[i].lid;
                                    shortIDz56.Text = DevInfo[i].sid;
                                    typeZ56.Text = DevInfo[i].type;
                                    longIDz56.Enabled = false;
                                    typeZ56.Enabled = false;
                                    enrollZ56.Text = "remove";
                                    break;

                                case 57:
                                    longIDz57.Text = DevInfo[i].lid;
                                    shortIDz57.Text = DevInfo[i].sid;
                                    typeZ57.Text = DevInfo[i].type;
                                    longIDz57.Enabled = false;
                                    typeZ57.Enabled = false;
                                    enrollZ57.Text = "remove";
                                    break;

                                case 58:
                                    longIDz58.Text = DevInfo[i].lid;
                                    shortIDz58.Text = DevInfo[i].sid;
                                    typeZ58.Text = DevInfo[i].type;
                                    longIDz58.Enabled = false;
                                    typeZ58.Enabled = false;
                                    enrollZ58.Text = "remove";
                                    break;

                                case 59:
                                    longIDz59.Text = DevInfo[i].lid;
                                    shortIDz59.Text = DevInfo[i].sid;
                                    typeZ59.Text = DevInfo[i].type;
                                    longIDz59.Enabled = false;
                                    typeZ59.Enabled = false;
                                    enrollZ59.Text = "remove";
                                    break;

                                case 60:
                                    longIDz60.Text = DevInfo[i].lid;
                                    shortIDz60.Text = DevInfo[i].sid;
                                    typeZ60.Text = DevInfo[i].type;
                                    longIDz60.Enabled = false;
                                    typeZ60.Enabled = false;
                                    enrollZ60.Text = "remove";
                                    break;

                                case 61:
                                    longIDz61.Text = DevInfo[i].lid;
                                    shortIDz61.Text = DevInfo[i].sid;
                                    typeZ61.Text = DevInfo[i].type;
                                    longIDz61.Enabled = false;
                                    typeZ61.Enabled = false;
                                    enrollZ61.Text = "remove";
                                    break;

                                case 62:
                                    longIDz62.Text = DevInfo[i].lid;
                                    shortIDz62.Text = DevInfo[i].sid;
                                    typeZ62.Text = DevInfo[i].type;
                                    longIDz62.Enabled = false;
                                    typeZ62.Enabled = false;
                                    enrollZ62.Text = "remove";
                                    break;

                                case 63:
                                    longIDz63.Text = DevInfo[i].lid;
                                    shortIDz63.Text = DevInfo[i].sid;
                                    typeZ63.Text = DevInfo[i].type;
                                    longIDz63.Enabled = false;
                                    typeZ63.Enabled = false;
                                    enrollZ63.Text = "remove";
                                    break;

                                case 64:
                                    longIDz64.Text = DevInfo[i].lid;
                                    shortIDz64.Text = DevInfo[i].sid;
                                    typeZ64.Text = DevInfo[i].type;
                                    longIDz64.Enabled = false;
                                    typeZ64.Enabled = false;
                                    enrollZ64.Text = "remove";
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

        private void enroll_detector_Activated(object sender, EventArgs e)
        {
            GetAllDevice();            
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

        #region Enroll buttons click for all zones

        //=================ENROLL ZONES ONE BY ONE=====================================================

        private void enrollZ1_Click(object sender, EventArgs e)
        {
            enroll_remove(typeZ1, longIDz1, enrollZ1, shortIDz1, "1");
        }

        private void enrollZ2_Click(object sender, EventArgs e)
        {
            enroll_remove(typeZ2, longIDz2, enrollZ2, shortIDz2, "2");
        }

        private void enrollZ3_Click(object sender, EventArgs e)
        {
            enroll_remove(typeZ3, longIDz3, enrollZ3, shortIDz3, "3");
        }

        private void enrollZ4_Click(object sender, EventArgs e)
        {
            enroll_remove(typeZ4, longIDz4, enrollZ4, shortIDz4, "4");
        }

        private void enrollZ5_Click(object sender, EventArgs e)
        {
            enroll_remove(typeZ5, longIDz5, enrollZ5, shortIDz5, "5");
        }

        private void enrollZ6_Click(object sender, EventArgs e)
        {
            enroll_remove(typeZ6, longIDz6, enrollZ6, shortIDz6, "6");
        }

        private void enrollZ7_Click(object sender, EventArgs e)
        {
            enroll_remove(typeZ7, longIDz7, enrollZ7, shortIDz7, "7");
        }

        private void enrollZ8_Click(object sender, EventArgs e)
        {
            enroll_remove(typeZ8, longIDz8, enrollZ8, shortIDz8, "8");
        }

        private void enrollZ9_Click(object sender, EventArgs e)
        {
            enroll_remove(typeZ9, longIDz9, enrollZ9, shortIDz9, "9");
        }

        private void enrollZ10_Click(object sender, EventArgs e)
        {
            enroll_remove(typeZ10, longIDz10, enrollZ10, shortIDz10, "10");
        }

        private void enrollZ11_Click(object sender, EventArgs e)
        {
            enroll_remove(typeZ11, longIDz11, enrollZ11, shortIDz11, "11");
        }

        private void enrollZ12_Click(object sender, EventArgs e)
        {
            enroll_remove(typeZ12, longIDz12, enrollZ12, shortIDz12, "12");
        }

        private void enrollZ13_Click(object sender, EventArgs e)
        {
            enroll_remove(typeZ13, longIDz13, enrollZ13, shortIDz13, "13");
        }

        private void enrollZ14_Click(object sender, EventArgs e)
        {
            enroll_remove(typeZ14, longIDz14, enrollZ14, shortIDz14, "14");
        }

        private void enrollZ15_Click(object sender, EventArgs e)
        {
            enroll_remove(typeZ15, longIDz15, enrollZ15, shortIDz15, "15");
        }

        private void enrollZ16_Click(object sender, EventArgs e)
        {
            enroll_remove(typeZ16, longIDz16, enrollZ16, shortIDz16, "16");
        }

        private void enrollZ17_Click_1(object sender, EventArgs e)
        {
            enroll_remove(typeZ17, longIDz17, enrollZ17, shortIDz17, "17");
        }

        private void enrollZ18_Click_1(object sender, EventArgs e)
        {
            enroll_remove(typeZ18, longIDz18, enrollZ18, shortIDz18, "18");
        }

        private void enrollZ19_Click(object sender, EventArgs e)
        {
            enroll_remove(typeZ19, longIDz19, enrollZ19, shortIDz19, "19");
        }

        private void enrollZ20_Click(object sender, EventArgs e)
        {
            enroll_remove(typeZ20, longIDz20, enrollZ20, shortIDz20, "20");
        }

        private void enrollZ21_Click(object sender, EventArgs e)
        {
            enroll_remove(typeZ21, longIDz21, enrollZ21, shortIDz21, "21");
        }

        private void enrollZ22_Click(object sender, EventArgs e)
        {
            enroll_remove(typeZ22, longIDz22, enrollZ22, shortIDz22, "22");
        }

        private void enrollZ23_Click(object sender, EventArgs e)
        {
            enroll_remove(typeZ23, longIDz23, enrollZ23, shortIDz23, "23");
        }

        private void enrollZ24_Click(object sender, EventArgs e)
        {
            enroll_remove(typeZ24, longIDz24, enrollZ24, shortIDz24, "24");
        }

        private void enrollZ25_Click(object sender, EventArgs e)
        {
            enroll_remove(typeZ25, longIDz25, enrollZ25, shortIDz25, "25");
        }

        private void enrollZ26_Click(object sender, EventArgs e)
        {
            enroll_remove(typeZ26, longIDz26, enrollZ26, shortIDz26, "26");
        }

        private void enrollZ27_Click(object sender, EventArgs e)
        {
            enroll_remove(typeZ27, longIDz27, enrollZ27, shortIDz27, "27");
        }

        private void enrollZ28_Click(object sender, EventArgs e)
        {
            enroll_remove(typeZ28, longIDz28, enrollZ28, shortIDz28, "28");
        }

        private void enrollZ29_Click(object sender, EventArgs e)
        {
            enroll_remove(typeZ29, longIDz29, enrollZ29, shortIDz29, "29");
        }

        private void enrollZ30_Click(object sender, EventArgs e)
        {
            enroll_remove(typeZ30, longIDz30, enrollZ30, shortIDz30, "30");
        }

        private void enrollZ31_Click(object sender, EventArgs e)
        {
            enroll_remove(typeZ31, longIDz31, enrollZ31, shortIDz31, "31");
        }

        private void enrollZ32_Click(object sender, EventArgs e)
        {
            enroll_remove(typeZ32, longIDz32, enrollZ32, shortIDz32, "32");
        }

        private void enrollZ33_Click(object sender, EventArgs e)
        {
            enroll_remove(typeZ33, longIDz33, enrollZ33, shortIDz33, "33");
        }

        private void enrollZ34_Click(object sender, EventArgs e)
        {
            enroll_remove(typeZ34, longIDz34, enrollZ34, shortIDz34, "34");
        }

        private void enrollZ35_Click(object sender, EventArgs e)
        {
            enroll_remove(typeZ35, longIDz35, enrollZ35, shortIDz35, "35");
        }

        private void enrollZ36_Click(object sender, EventArgs e)
        {
            enroll_remove(typeZ36, longIDz36, enrollZ36, shortIDz36, "36");
        }

        private void enrollZ37_Click(object sender, EventArgs e)
        {
            enroll_remove(typeZ37, longIDz37, enrollZ37, shortIDz37, "37");
        }

        private void enrollZ38_Click(object sender, EventArgs e)
        {
            enroll_remove(typeZ38, longIDz38, enrollZ38, shortIDz38, "38");
        }

        private void enrollZ39_Click(object sender, EventArgs e)
        {
            enroll_remove(typeZ39, longIDz39, enrollZ39, shortIDz39, "39");
        }

        private void enrollZ40_Click(object sender, EventArgs e)
        {
            enroll_remove(typeZ40, longIDz40, enrollZ40, shortIDz40, "40");
        }

        private void enrollZ41_Click(object sender, EventArgs e)
        {
            enroll_remove(typeZ41, longIDz41, enrollZ41, shortIDz41, "41");
        }

        private void enrollZ42_Click(object sender, EventArgs e)
        {
            enroll_remove(typeZ42, longIDz42, enrollZ42, shortIDz42, "42");
        }

        private void enrollZ43_Click(object sender, EventArgs e)
        {
            enroll_remove(typeZ43, longIDz43, enrollZ43, shortIDz43, "43");
        }

        private void enrollZ44_Click(object sender, EventArgs e)
        {
            enroll_remove(typeZ44, longIDz44, enrollZ44, shortIDz44, "44");
        }

        private void enrollZ45_Click(object sender, EventArgs e)
        {
            enroll_remove(typeZ45, longIDz45, enrollZ45, shortIDz45, "45");
        }

        private void enrollZ46_Click(object sender, EventArgs e)
        {
            enroll_remove(typeZ46, longIDz46, enrollZ46, shortIDz46, "46");
        }

        private void enrollZ47_Click(object sender, EventArgs e)
        {
            enroll_remove(typeZ47, longIDz47, enrollZ47, shortIDz47, "47");
        }

        private void enrollZ48_Click(object sender, EventArgs e)
        {
            enroll_remove(typeZ48, longIDz48, enrollZ48, shortIDz48, "48");
        }

        private void enrollZ49_Click(object sender, EventArgs e)
        {
            enroll_remove(typeZ49, longIDz49, enrollZ49, shortIDz49, "49");
        }

        private void enrollZ50_Click(object sender, EventArgs e)
        {
            enroll_remove(typeZ50, longIDz50, enrollZ50, shortIDz50, "50");
        }

        private void enrollZ51_Click(object sender, EventArgs e)
        {
            enroll_remove(typeZ51, longIDz51, enrollZ51, shortIDz51, "51");
        }

        private void enrollZ52_Click(object sender, EventArgs e)
        {
            enroll_remove(typeZ52, longIDz52, enrollZ52, shortIDz52, "52");
        }

        private void enrollZ53_Click(object sender, EventArgs e)
        {
            enroll_remove(typeZ53, longIDz53, enrollZ53, shortIDz53, "53");
        }

        private void enrollZ54_Click(object sender, EventArgs e)
        {
            enroll_remove(typeZ54, longIDz54, enrollZ54, shortIDz54, "54");
        }

        private void enrollZ55_Click(object sender, EventArgs e)
        {
            enroll_remove(typeZ55, longIDz55, enrollZ55, shortIDz55, "55");
        }

        private void enrollZ56_Click(object sender, EventArgs e)
        {
            enroll_remove(typeZ56, longIDz56, enrollZ56, shortIDz56, "56");
        }

        private void enrollZ57_Click(object sender, EventArgs e)
        {
            enroll_remove(typeZ57, longIDz57, enrollZ57, shortIDz57, "57");
        }

        private void enrollZ58_Click(object sender, EventArgs e)
        {
            enroll_remove(typeZ58, longIDz58, enrollZ58, shortIDz58, "58");
        }

        private void enrollZ59_Click(object sender, EventArgs e)
        {
            enroll_remove(typeZ59, longIDz59, enrollZ59, shortIDz59, "59");
        }

        private void enrollZ60_Click(object sender, EventArgs e)
        {
            enroll_remove(typeZ60, longIDz60, enrollZ60, shortIDz60, "60");
        }

        private void enrollZ61_Click(object sender, EventArgs e)
        {
            enroll_remove(typeZ61, longIDz61, enrollZ61, shortIDz61, "61");
        }

        private void enrollZ62_Click(object sender, EventArgs e)
        {
            enroll_remove(typeZ62, longIDz62, enrollZ62, shortIDz62, "62");
        }

        private void enrollZ63_Click(object sender, EventArgs e)
        {
            enroll_remove(typeZ63, longIDz63, enrollZ63, shortIDz63, "63");
        }

        private void enrollZ64_Click(object sender, EventArgs e)
        {
            enroll_remove(typeZ64, longIDz64, enrollZ64, shortIDz64, "64");
        }

        //=============================================================================================

        #endregion

        //private void timer1_Tick(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        LCDlabel.Text = send.get_lcd();
        //    }
        //    catch (WebException)
        //    {
        //        LCDlabel.Text = "Unavailable...";
        //    }
        //    catch (XmlRpcIllFormedXmlException)
        //    {
        //        MessageBox.Show("Some error happens!!!  Please tell Yuras about it.");
        //    }
        //    catch (XmlRpcFaultException)
        //    {
        //        MessageBox.Show("Some error happens!!!  Please tell Yuras about it.");
        //    }

        //}
        
        private void showFaultyForType(string devType)
        {
            DisableAllFaults();

            if (devType == "")
            {
                deviceDoesnotEnrolledMenu.Visible = true;
                syncMenu.Visible = false;
                tamperMenu.Visible = false;
                lowbatteryMenu.Visible = false;
            }

            if (devType == "CONTACT")
            {
                openMenu.Visible = true;
                closeMenu.Visible = true;
            }

            if (devType == "CONTACT_AUX")
            {
                openMenu.Visible = true;
                closeMenu.Visible = true;
                contactauxMenu.Visible = true;
            }

            if (devType == "VANISHING")
            {
                openMenu.Visible = true;
                closeMenu.Visible = true;
            }

            if (devType == "MOTION_SENSOR")
            {
                violateMenu.Visible = true;
            }

            if (devType == "CLIP")
            {
                violateMenu.Visible = true;
            }

            if (devType == "MOTION_CAMERA")
            {
                violateMenu.Visible = true;
                ACMenu.Visible = true;
            }

            if (devType == "TOWER30")
            {
                violateMenu.Visible = true;
                maskingMenu.Visible = true;
            }

            if (devType == "TOWER32")
            {
                violateMenu.Visible = true;
                maskingMenu.Visible = true;
            }

            if (devType == "TOWER20")
            {
                violateMenu.Visible = true;
                maskingMenu.Visible = true;
            }

            if (devType == "SMOKE")
            {
                smoke_alarmMenu.Visible = true;
                smokeTroubleMenu.Visible = true;
            }

            if (devType == "SMOKE_HEAT")
            {
                smoke_alarmMenu.Visible = true;
                smokeTroubleMenu.Visible = true;
                heat_alarmMenu.Visible = true;
                heatTroubleMenu.Visible = true;
            }

            if (devType == "GAS")
            {
                gas_alertMenu.Visible = true;
                GAStroubleMenu.Visible = true;
            }

            if (devType == "CO")
            {
                co_alertMenu.Visible = true;
                COtroubleMenu.Visible = true;
            }

            if (devType == "FLOOD")
            {
                floodMenu.Visible = true;
            }

            if (devType == "FLOOD_551")
            {
                floodMenu.Visible = true;
            }

            if (devType == "TEMPERATURE")
            {
                hotMenu.Visible = true;
                coldMenu.Visible = true;
                freezerMenu.Visible = true;
                freezingMenu.Visible = true;
                probeMenu.Visible = true;
            }

            if (devType == "SMOKE_HEAT_TEMP")
            {

            }            

            if (devType == "SHOCK_AUX")
            {
                
            }

            if (devType == "SHOCK_CONTACT")
            {

            }

            if (devType == "SHOCK_AUX_CONTACT")
            {

            }

            if (devType == "SHOCK_AUX_CONTACT_G2")
            {

            }

            if (devType == "GLASS_BREAK")
            {
                glassbreakMenu.Visible = true;
            }
        }

        public void SidLidDefinition(Control devType)
        {
            string zoneNUMBER = Convert.ToString(devType).Substring(Convert.ToString(devType).IndexOf("#") + 1);

            switch (Convert.ToInt32(zoneNUMBER))
            {
                case 1:
                    LID = Convert.ToString(longIDz1.Value);
                    SID = shortIDz1.Text;                    
                    showFaultyForType(typeZ1.Text);
                    break;

                case 2:
                    LID = Convert.ToString(longIDz2.Value);
                    SID = shortIDz2.Text;
                    showFaultyForType(typeZ2.Text);
                    break;

                case 3:
                    LID = Convert.ToString(longIDz3.Value);
                    SID = shortIDz3.Text;
                    showFaultyForType(typeZ3.Text);
                    break;

                case 4:
                    LID = Convert.ToString(longIDz4.Value);
                    SID = shortIDz4.Text;
                    showFaultyForType(typeZ4.Text);
                    break;

                case 5:
                    LID = Convert.ToString(longIDz5.Value);
                    SID = shortIDz5.Text;
                    showFaultyForType(typeZ5.Text);
                    break;

                case 6:
                    LID = Convert.ToString(longIDz6.Value);
                    SID = shortIDz6.Text;
                    showFaultyForType(typeZ6.Text);
                    break;

                case 7:
                    LID = Convert.ToString(longIDz7.Value);
                    SID = shortIDz7.Text;
                    showFaultyForType(typeZ7.Text);
                    break;

                case 8:
                    LID = Convert.ToString(longIDz8.Value);
                    SID = shortIDz8.Text;
                    showFaultyForType(typeZ8.Text);
                    break;

                case 9:
                    LID = Convert.ToString(longIDz9.Value);
                    SID = shortIDz9.Text;
                    showFaultyForType(typeZ9.Text);
                    break;

                case 10:
                    LID = Convert.ToString(longIDz10.Value);
                    SID = shortIDz10.Text;
                    showFaultyForType(typeZ10.Text);
                    break;

                case 11:
                    LID = Convert.ToString(longIDz11.Value);
                    SID = shortIDz11.Text;
                    showFaultyForType(typeZ11.Text);
                    break;

                case 12:
                    LID = Convert.ToString(longIDz12.Value);
                    SID = shortIDz12.Text;
                    showFaultyForType(typeZ12.Text);
                    break;

                case 13:
                    LID = Convert.ToString(longIDz13.Value);
                    SID = shortIDz13.Text;
                    showFaultyForType(typeZ13.Text);
                    break;

                case 14:
                    LID = Convert.ToString(longIDz14.Value);
                    SID = shortIDz14.Text;
                    showFaultyForType(typeZ14.Text);
                    break;

                case 15:
                    LID = Convert.ToString(longIDz15.Value);
                    SID = shortIDz15.Text;
                    showFaultyForType(typeZ15.Text);
                    break;

                case 16:
                    LID = Convert.ToString(longIDz16.Value);
                    SID = shortIDz16.Text;
                    showFaultyForType(typeZ16.Text);
                    break;

                case 17:
                    LID = Convert.ToString(longIDz17.Value);
                    SID = shortIDz17.Text;
                    showFaultyForType(typeZ17.Text);
                    break;

                case 18:
                    LID = Convert.ToString(longIDz18.Value);
                    SID = shortIDz18.Text;
                    showFaultyForType(typeZ18.Text);
                    break;

                case 19:
                    LID = Convert.ToString(longIDz19.Value);
                    SID = shortIDz19.Text;
                    showFaultyForType(typeZ19.Text);
                    break;

                case 20:
                    LID = Convert.ToString(longIDz20.Value);
                    SID = shortIDz20.Text;
                    showFaultyForType(typeZ20.Text);
                    break;

                case 21:
                    LID = Convert.ToString(longIDz21.Value);
                    SID = shortIDz21.Text;
                    showFaultyForType(typeZ21.Text);
                    break;

                case 22:
                    LID = Convert.ToString(longIDz22.Value);
                    SID = shortIDz22.Text;
                    showFaultyForType(typeZ22.Text);
                    break;

                case 23:
                    LID = Convert.ToString(longIDz23.Value);
                    SID = shortIDz23.Text;
                    showFaultyForType(typeZ23.Text);
                    break;

                case 24:
                    LID = Convert.ToString(longIDz24.Value);
                    SID = shortIDz24.Text;
                    showFaultyForType(typeZ24.Text);
                    break;

                case 25:
                    LID = Convert.ToString(longIDz25.Value);
                    SID = shortIDz25.Text;
                    showFaultyForType(typeZ25.Text);
                    break;

                case 26:
                    LID = Convert.ToString(longIDz26.Value);
                    SID = shortIDz26.Text;
                    showFaultyForType(typeZ26.Text);
                    break;

                case 27:
                    LID = Convert.ToString(longIDz27.Value);
                    SID = shortIDz27.Text;
                    showFaultyForType(typeZ27.Text);
                    break;

                case 28:
                    LID = Convert.ToString(longIDz28.Value);
                    SID = shortIDz28.Text;
                    showFaultyForType(typeZ28.Text);
                    break;

                case 29:
                    LID = Convert.ToString(longIDz29.Value);
                    SID = shortIDz29.Text;
                    showFaultyForType(typeZ29.Text);
                    break;

                case 30:
                    LID = Convert.ToString(longIDz30.Value);
                    SID = shortIDz30.Text;
                    showFaultyForType(typeZ30.Text);
                    break;

                case 31:
                    LID = Convert.ToString(longIDz31.Value);
                    SID = shortIDz31.Text;
                    showFaultyForType(typeZ31.Text);
                    break;

                case 32:
                    LID = Convert.ToString(longIDz32.Value);
                    SID = shortIDz32.Text;
                    showFaultyForType(typeZ32.Text);
                    break;

                case 33:
                    LID = Convert.ToString(longIDz33.Value);
                    SID = shortIDz33.Text;
                    showFaultyForType(typeZ33.Text);
                    break;

                case 34:
                    LID = Convert.ToString(longIDz34.Value);
                    SID = shortIDz34.Text;
                    showFaultyForType(typeZ34.Text);
                    break;

                case 35:
                    LID = Convert.ToString(longIDz35.Value);
                    SID = shortIDz35.Text;
                    showFaultyForType(typeZ35.Text);
                    break;

                case 36:
                    LID = Convert.ToString(longIDz36.Value);
                    SID = shortIDz36.Text;
                    showFaultyForType(typeZ36.Text);
                    break;

                case 37:
                    LID = Convert.ToString(longIDz37.Value);
                    SID = shortIDz37.Text;
                    showFaultyForType(typeZ37.Text);
                    break;

                case 38:
                    LID = Convert.ToString(longIDz38.Value);
                    SID = shortIDz38.Text;
                    showFaultyForType(typeZ38.Text);
                    break;

                case 39:
                    LID = Convert.ToString(longIDz39.Value);
                    SID = shortIDz39.Text;
                    showFaultyForType(typeZ39.Text);
                    break;

                case 40:
                    LID = Convert.ToString(longIDz40.Value);
                    SID = shortIDz40.Text;
                    showFaultyForType(typeZ40.Text);
                    break;

                case 41:
                    LID = Convert.ToString(longIDz41.Value);
                    SID = shortIDz41.Text;
                    showFaultyForType(typeZ41.Text);
                    break;

                case 42:
                    LID = Convert.ToString(longIDz42.Value);
                    SID = shortIDz42.Text;
                    showFaultyForType(typeZ42.Text);
                    break;

                case 43:
                    LID = Convert.ToString(longIDz43.Value);
                    SID = shortIDz43.Text;
                    showFaultyForType(typeZ43.Text);
                    break;

                case 44:
                    LID = Convert.ToString(longIDz44.Value);
                    SID = shortIDz44.Text;
                    showFaultyForType(typeZ44.Text);
                    break;

                case 45:
                    LID = Convert.ToString(longIDz45.Value);
                    SID = shortIDz45.Text;
                    showFaultyForType(typeZ45.Text);
                    break;

                case 46:
                    LID = Convert.ToString(longIDz46.Value);
                    SID = shortIDz46.Text;
                    showFaultyForType(typeZ46.Text);
                    break;

                case 47:
                    LID = Convert.ToString(longIDz47.Value);
                    SID = shortIDz47.Text;
                    showFaultyForType(typeZ47.Text);
                    break;

                case 48:
                    LID = Convert.ToString(longIDz48.Value);
                    SID = shortIDz48.Text;
                    showFaultyForType(typeZ48.Text);
                    break;

                case 49:
                    LID = Convert.ToString(longIDz49.Value);
                    SID = shortIDz49.Text;
                    showFaultyForType(typeZ49.Text);
                    break;

                case 50:
                    LID = Convert.ToString(longIDz50.Value);
                    SID = shortIDz50.Text;
                    showFaultyForType(typeZ50.Text);
                    break;

                case 51:
                    LID = Convert.ToString(longIDz51.Value);
                    SID = shortIDz51.Text;
                    showFaultyForType(typeZ51.Text);
                    break;

                case 52:
                    LID = Convert.ToString(longIDz52.Value);
                    SID = shortIDz52.Text;
                    showFaultyForType(typeZ52.Text);
                    break;

                case 53:
                    LID = Convert.ToString(longIDz53.Value);
                    SID = shortIDz53.Text;
                    showFaultyForType(typeZ53.Text);
                    break;

                case 54:
                    LID = Convert.ToString(longIDz54.Value);
                    SID = shortIDz54.Text;
                    showFaultyForType(typeZ54.Text);
                    break;

                case 55:
                    LID = Convert.ToString(longIDz55.Value);
                    SID = shortIDz55.Text;
                    showFaultyForType(typeZ55.Text);
                    break;

                case 56:
                    LID = Convert.ToString(longIDz56.Value);
                    SID = shortIDz56.Text;
                    showFaultyForType(typeZ56.Text);
                    break;

                case 57:
                    LID = Convert.ToString(longIDz57.Value);
                    SID = shortIDz57.Text;
                    showFaultyForType(typeZ57.Text);
                    break;

                case 58:
                    LID = Convert.ToString(longIDz58.Value);
                    SID = shortIDz58.Text;
                    showFaultyForType(typeZ58.Text);
                    break;

                case 59:
                    LID = Convert.ToString(longIDz59.Value);
                    SID = shortIDz59.Text;
                    showFaultyForType(typeZ59.Text);
                    break;

                case 60:
                    LID = Convert.ToString(longIDz60.Value);
                    SID = shortIDz60.Text;
                    showFaultyForType(typeZ60.Text);
                    break;

                case 61:
                    LID = Convert.ToString(longIDz61.Value);
                    SID = shortIDz61.Text;
                    showFaultyForType(typeZ61.Text);
                    break;

                case 62:
                    LID = Convert.ToString(longIDz62.Value);
                    SID = shortIDz62.Text;
                    showFaultyForType(typeZ62.Text);
                    break;

                case 63:
                    LID = Convert.ToString(longIDz63.Value);
                    SID = shortIDz63.Text;
                    showFaultyForType(typeZ63.Text);
                    break;

                case 64:
                    LID = Convert.ToString(longIDz64.Value);
                    SID = shortIDz64.Text;
                    showFaultyForType(typeZ64.Text);
                    break;
            }            
        }       
        
        private void DisableAllFaults()
        {
            deviceDoesnotEnrolledMenu.Visible = false;
            syncMenu.Visible = true;
            openMenu.Visible = false;
            closeMenu.Visible = false;
            violateMenu.Visible = false;
            floodMenu.Visible = false;
            glassbreakMenu.Visible = false;
            tamperMenu.Visible = true;
            lowbatteryMenu.Visible = true;
            smoke_alarmMenu.Visible = false;
            heat_alarmMenu.Visible = false;
            co_alertMenu.Visible = false;
            gas_alertMenu.Visible = false;
            contactauxMenu.Visible = false;
            freezerMenu.Visible = false;
            freezingMenu.Visible = false;
            hotMenu.Visible = false;
            coldMenu.Visible = false;
            ACMenu.Visible = false;
            maskingMenu.Visible = false;
            heatTroubleMenu.Visible = false;
            smokeTroubleMenu.Visible = false;
            jammingMenu.Visible = false;
            COtroubleMenu.Visible = false;
            GAStroubleMenu.Visible = false;
            probeMenu.Visible = false;
        }

        private void GeneralMenuStrip_Opening(object sender, CancelEventArgs e)
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

        #region All faulty methods

        //====================== ALL FAULTY FUNCTIONS ========================================

        private void update(string lid, string sid)
        {
            send.update(sid, lid);
        }

        private void open(string lid, string sid)
        {
            send.open(sid, lid);
        }

        private void close(string lid, string sid)
        {
            send.close(sid, lid);
        }

        private void open_tamper(string lid, string sid)
        {
            send.open_tamper(sid, lid);
        }

        private void close_tamper(string lid, string sid)
        {
            send.close_tamper(sid, lid);
        }

        private void violate(string lid, string sid)
        {
            send.violate(sid, lid);
        }

        private void glass_break(string lid, string sid)
        {
            send.glass_break(sid, lid);
        }

        private void open_smoke_alarm(string lid, string sid)
        {
            send.open_smoke_alarm(sid, lid);
        }

        private void close_smoke_alarm(string lid, string sid)
        {
            send.close_smoke_alarm(sid, lid);
        }

        private void open_heat_alarm(string lid, string sid)
        {
            send.open_heat_alarm(sid, lid);
        }

        private void close_heat_alarm(string lid, string sid)
        {
            send.close_heat_alarm(sid, lid);
        }

        private void open_co_alert(string lid, string sid)
        {
            send.open_co_alert(sid, lid);
        }

        private void close_co_alert(string lid, string sid)
        {
            send.close_co_alert(sid, lid);
        }

        private void open_gas_alert(string lid, string sid)
        {
            send.open_gas_alert(sid, lid);
        }

        private void close_gas_alert(string lid, string sid)
        {
            send.close_gas_alert(sid, lid);
        }

        private void open_flood(string lid, string sid)
        {
            send.open_flood(sid, lid);
        }

        private void close_flood(string lid, string sid)
        {
            send.close_flood(sid, lid);
        }

        private void open_aux(string lid, string sid)
        {
            send.open_aux(sid, lid);
        }

        private void close_aux(string lid, string sid)
        {
            send.close_aux(sid, lid);
        }

        private void open_freezer(string lid, string sid)
        {
            send.open_freezer(sid, lid);
        }

        private void close_freezer(string lid, string sid)
        {
            send.close_freezer(sid, lid);
        }

        private void open_freezing(string lid, string sid)
        {
            send.open_freezing(sid, lid);
        }

        private void close_freezing(string lid, string sid)
        {
            send.close_freezing(sid, lid);
        }

        private void open_hot(string lid, string sid)
        {
            send.open_hot(sid, lid);
        }

        private void close_hot(string lid, string sid)
        {
            send.close_hot(sid, lid);
        }

        private void open_cold(string lid, string sid)
        {
            send.open_cold(sid, lid);
        }

        private void close_cold(string lid, string sid)
        {
            send.close_cold(sid, lid);
        }

        private void open_low_bat(string lid, string sid)
        {
            send.open_low_bat(sid, lid);
        }

        private void close_low_bat(string lid, string sid)
        {
            send.close_low_bat(sid, lid);
        }

        private void ac_fail(string lid, string sid)
        {
            send.ac_fail(sid, lid);
        }

        private void ac_rest(string lid, string sid)
        {
            send.ac_rest(sid, lid);
        }

        private void open_masking(string lid, string sid)
        {
            send.open_masking(sid, lid);
        }

        private void close_masking(string lid, string sid)
        {
            send.close_masking(sid, lid);
        }

        private void open_heat_trouble(string lid, string sid)
        {
            send.open_heat_trouble(sid, lid);
        }

        private void close_heat_trouble(string lid, string sid)
        {
            send.close_heat_trouble(sid, lid);
        }

        private void open_smoke_trouble(string lid, string sid)
        {
            send.open_smoke_trouble(sid, lid);
        }

        private void close_smoke_trouble(string lid, string sid)
        {
            send.close_smoke_trouble(sid, lid);
        }

        private void open_jamming(string lid, string sid)
        {
            send.open_jamming(sid, lid);
        }

        private void close_jamming(string lid, string sid)
        {
            send.close_jamming(sid, lid);
        }

        private void open_probe(string lid, string sid)
        {
            send.open_probe(sid, lid);
        }

        private void close_probe(string lid, string sid)
        {
            send.close_probe(sid, lid);
        }

        private void open_co_trouble(string lid, string sid)
        {
            send.open_co_trouble(sid, lid);
        }

        private void close_co_trouble(string lid, string sid)
        {
            send.close_co_trouble(sid, lid);
        }

        private void open_gas_trouble(string lid, string sid)
        {
            send.open_gas_trouble(sid, lid);
        }

        private void close_gas_trouble(string lid, string sid)
        {
            send.close_gas_trouble(sid, lid);
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
        //====================================================================================

        #endregion

        #region ALL CONTEXT MENU ITEMS CLICK

        //===================== ALL CONTEXT MENU ITEMS CLICK =================================

        private void syncMenu_Click(object sender, EventArgs e)
        {
            update(LID, SID);
        }

        private void openMenu_Click(object sender, EventArgs e)
        {
            open(LID, SID);
        }

        private void closeMenu_Click(object sender, EventArgs e)
        {
            close(LID, SID);
        }

        private void violateMenu_Click(object sender, EventArgs e)
        {
            violate(LID, SID);
        }

        private void floodopenMenu_Click(object sender, EventArgs e)
        {
            open_flood(LID, SID);
        }

        private void floodrestoreMenu_Click(object sender, EventArgs e)
        {
            close_flood(LID, SID);
        }

        private void glassbreakMenu_Click(object sender, EventArgs e)
        {
            glass_break(LID, SID);
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

        private void openSmokeAlarmMenu_Click(object sender, EventArgs e)
        {
            open_smoke_alarm(LID, SID);
        }

        private void restoreSmokeAlarmMenu_Click(object sender, EventArgs e)
        {
            close_smoke_alarm(LID, SID);
        }

        private void openHeatAlarmMenu_Click(object sender, EventArgs e)
        {
            open_heat_alarm(LID, SID);
        }

        private void restoreHeatAlarmMenu_Click(object sender, EventArgs e)
        {
            close_heat_alarm(LID, SID);
        }

        private void openCOAlertMenu_Click(object sender, EventArgs e)
        {
            open_co_alert(LID, SID);
        }

        private void restoreCOAlertMenu_Click(object sender, EventArgs e)
        {
            close_co_alert(LID, SID);
        }

        private void openGasAlertMenu_Click(object sender, EventArgs e)
        {
            open_gas_alert(LID, SID);
        }

        private void restoreGasAlertMenu_Click(object sender, EventArgs e)
        {
            close_gas_alert(LID, SID);
        }

        private void openContact_auxMenu_Click(object sender, EventArgs e)
        {
            open_aux(LID, SID);
        }

        private void restoreContact_auxMenu_Click(object sender, EventArgs e)
        {
            close_aux(LID, SID);
        }

        private void openFreezerMenu_Click(object sender, EventArgs e)
        {
            open_freezer(LID, SID);
        }

        private void restoreFreezerMenu_Click(object sender, EventArgs e)
        {
            close_freezer(LID, SID);
        }

        private void openFreezingMenu_Click(object sender, EventArgs e)
        {
            open_freezing(LID, SID);
        }

        private void restoreFreezingMenu_Click(object sender, EventArgs e)
        {
            close_freezing(LID, SID);
        }

        private void openHotMenu_Click(object sender, EventArgs e)
        {
            open_hot(LID, SID);
        }

        private void restoreHotMenu_Click(object sender, EventArgs e)
        {
            close_hot(LID, SID);
        }

        private void openColdMenu_Click(object sender, EventArgs e)
        {
            open_cold(LID, SID);
        }

        private void restoreColdMenu_Click(object sender, EventArgs e)
        {
            close_cold(LID, SID);
        }

        private void openACMenu_Click(object sender, EventArgs e)
        {
            ac_fail(LID, SID);
        }

        private void restoreACMenu_Click(object sender, EventArgs e)
        {
            ac_rest(LID, SID);
        }

        private void openMaskingMenu_Click(object sender, EventArgs e)
        {
            open_masking(LID, SID);
        }

        private void restoreMaskingMenu_Click(object sender, EventArgs e)
        {
            close_masking(LID, SID);
        }

        private void openHeatTroubleMenu_Click(object sender, EventArgs e)
        {
            open_heat_trouble(LID, SID);
        }

        private void restoreHeatTroubleMenu_Click(object sender, EventArgs e)
        {
            close_heat_trouble(LID, SID);
        }

        private void openSmokeTroubleMenu_Click(object sender, EventArgs e)
        {
            open_smoke_trouble(LID, SID);
        }

        private void restoreSmokeTroubleMenu_Click(object sender, EventArgs e)
        {
            close_smoke_trouble(LID, SID);
        }

        private void openJammingMenu_Click(object sender, EventArgs e)
        {
            open_jamming(LID, SID);
        }

        private void restoreJammingMenu_Click(object sender, EventArgs e)
        {
            close_jamming(LID, SID);
        }

        private void openCOtroubleMenu_Click(object sender, EventArgs e)
        {
            open_co_trouble(LID, SID);
        }

        private void restoreCOtroubleMenu_Click(object sender, EventArgs e)
        {
            close_co_trouble(LID, SID);
        }

        private void openGASTroubleMenu_Click(object sender, EventArgs e)
        {
            open_gas_trouble(LID, SID);
        }

        private void restoreGASTroubleMenu_Click(object sender, EventArgs e)
        {
            close_gas_trouble(LID, SID);
        }

        private void openProbeMenu_Click(object sender, EventArgs e)
        {
            open_probe(LID, SID);
        }

        private void restoreProbeMenu_Click(object sender, EventArgs e)
        {
            close_probe(LID, SID);
        }
        //====================================================================================

        #endregion

        private void NewPaneltoolStripButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("All devices will be removed from POOL. Click 'Yes' if your panel after burning or with factory defaults(there aren't any devices).", "New panel...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                send.clear_device_pool();
                GetAllDevice();
            }
        }

        private void EnrollAllZonesStripButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure to add 64 devices? It takes about 30 seconds.", "Enrolling all devices...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    send.enroll("CONTACT", "1000");
                    Thread.Sleep(200);
                    send.enroll("CONTACT_AUX", "1000");
                    Thread.Sleep(200);
                    send.enroll("VANISHING", "1000");
                    Thread.Sleep(200);                    
                    send.enroll("MOTION_SENSOR", "1000");
                    Thread.Sleep(200);
                    send.enroll("MOTION_CAMERA", "1000");
                    Thread.Sleep(200);
                    send.enroll("CLIP", "1000");
                    Thread.Sleep(200);
                    send.enroll("TOWER30", "1000");
                    Thread.Sleep(200);
                    send.enroll("TOWER32", "1000");
                    Thread.Sleep(200);
                    send.enroll("TOWER20", "1000");
                    Thread.Sleep(200);
                    send.enroll("SMOKE", "1000");
                    Thread.Sleep(200);
                    send.enroll("SMOKE_HEAT", "1000");
                    Thread.Sleep(200);
                    send.enroll("GAS", "1000");
                    Thread.Sleep(200);
                    send.enroll("CO", "1000");
                    Thread.Sleep(200);
                    send.enroll("FLOOD", "1000");
                    Thread.Sleep(200);
                    send.enroll("FLOOD_551", "1000");
                    Thread.Sleep(200);                    
                    send.enroll("TEMPERATURE", "1000");
                    Thread.Sleep(200);
                    send.enroll("GLASS_BREAK", "1000");
                    Thread.Sleep(200);
                    send.enroll("SHOCK_AUX_CONTACT", "1000");
                    Thread.Sleep(200);
                    send.enroll("SHOCK_AUX", "1000");
                    Thread.Sleep(200);
                    send.enroll("SHOCK_CONTACT", "1000");
                    Thread.Sleep(200);
                    send.enroll("SHOCK_AUX_CONTACT_G2", "1000");
                    Thread.Sleep(200);
                    send.enroll("CONTACT", "1001");
                    Thread.Sleep(200);
                    send.enroll("CONTACT_AUX", "1001");
                    Thread.Sleep(200);
                    send.enroll("VANISHING", "1001");
                    Thread.Sleep(200);
                    send.enroll("MOTION_SENSOR", "1001");
                    Thread.Sleep(200);
                    send.enroll("MOTION_CAMERA", "1001");
                    Thread.Sleep(200);
                    send.enroll("CLIP", "1001");
                    Thread.Sleep(200);
                    send.enroll("TOWER30", "1001");
                    Thread.Sleep(200);
                    send.enroll("TOWER32", "1001");
                    Thread.Sleep(200);
                    send.enroll("TOWER20", "1001");
                    Thread.Sleep(200);
                    send.enroll("SMOKE", "1001");
                    Thread.Sleep(200);
                    send.enroll("SMOKE_HEAT", "1001");
                    Thread.Sleep(200);
                    send.enroll("GAS", "1001");
                    Thread.Sleep(200);
                    send.enroll("CO", "1001");
                    Thread.Sleep(200);
                    send.enroll("FLOOD", "1001");
                    Thread.Sleep(200);
                    send.enroll("FLOOD_551", "1001");
                    Thread.Sleep(200);
                    send.enroll("TEMPERATURE", "1001");
                    Thread.Sleep(200);
                    send.enroll("GLASS_BREAK", "1001");
                    Thread.Sleep(200);
                    send.enroll("SHOCK_AUX_CONTACT", "1001");
                    Thread.Sleep(200);
                    send.enroll("SHOCK_AUX", "1001");
                    Thread.Sleep(200);
                    send.enroll("SHOCK_CONTACT", "1001");
                    Thread.Sleep(200);
                    send.enroll("SHOCK_AUX_CONTACT_G2", "1001");
                    Thread.Sleep(200);
                    send.enroll("CONTACT", "1002");
                    Thread.Sleep(200);
                    send.enroll("CONTACT_AUX", "1002");
                    Thread.Sleep(200);
                    send.enroll("VANISHING", "1002");
                    Thread.Sleep(200);
                    send.enroll("MOTION_SENSOR", "1002");
                    Thread.Sleep(200);
                    send.enroll("MOTION_CAMERA", "1002");
                    Thread.Sleep(200);
                    send.enroll("CLIP", "1002");
                    Thread.Sleep(200);
                    send.enroll("TOWER30", "1002");
                    Thread.Sleep(200);
                    send.enroll("TOWER32", "1002");
                    Thread.Sleep(200);
                    send.enroll("TOWER20", "1002");
                    Thread.Sleep(200);
                    send.enroll("SMOKE", "1002");
                    Thread.Sleep(200);
                    send.enroll("SMOKE_HEAT", "1002");
                    Thread.Sleep(200);
                    send.enroll("GAS", "1002");
                    Thread.Sleep(200);
                    send.enroll("CO", "1002");
                    Thread.Sleep(200);
                    send.enroll("FLOOD", "1002");
                    Thread.Sleep(200);
                    send.enroll("FLOOD_551", "1002");
                    Thread.Sleep(200);
                    send.enroll("TEMPERATURE", "1002");
                    Thread.Sleep(200);
                    send.enroll("GLASS_BREAK", "1002");
                    Thread.Sleep(200);
                    send.enroll("SHOCK_AUX_CONTACT", "1002");
                    Thread.Sleep(200);
                    send.enroll("SHOCK_AUX", "1002");
                    Thread.Sleep(200);
                    send.enroll("SHOCK_CONTACT", "1002");
                    Thread.Sleep(200);
                    send.enroll("SHOCK_AUX_CONTACT_G2", "1002");
                    Thread.Sleep(200);
                    send.enroll("CONTACT", "1003");
                    Thread.Sleep(200);                   
                }
                catch (XmlRpcInvalidXmlRpcException)
                {

                }

                statusLabel.Text = "Ready";
                GetAllDevice();

                MessageBox.Show("All devices enrolled", "Enrolling all devices...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void RemoveAllZonestoolStripButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure to remove all zones? It takes about 2 minutes.", "Removing zones...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                string[] allZones = {shortIDz1.Text, Convert.ToString(longIDz1.Value),
                                  shortIDz2.Text, Convert.ToString(longIDz2.Value),
                                  shortIDz3.Text, Convert.ToString(longIDz3.Value), 
                                  shortIDz4.Text, Convert.ToString(longIDz4.Value),
                                  shortIDz5.Text, Convert.ToString(longIDz5.Value),
                                  shortIDz6.Text, Convert.ToString(longIDz6.Value), 
                                  shortIDz7.Text, Convert.ToString(longIDz7.Value),
                                  shortIDz8.Text, Convert.ToString(longIDz8.Value),
                                  shortIDz9.Text, Convert.ToString(longIDz9.Value),
                                  shortIDz10.Text, Convert.ToString(longIDz10.Value),
                                  shortIDz11.Text, Convert.ToString(longIDz11.Value),
                                  shortIDz12.Text, Convert.ToString(longIDz12.Value),
                                  shortIDz13.Text, Convert.ToString(longIDz13.Value), 
                                  shortIDz14.Text, Convert.ToString(longIDz14.Value),
                                  shortIDz15.Text, Convert.ToString(longIDz15.Value),
                                  shortIDz16.Text, Convert.ToString(longIDz16.Value), 
                                  shortIDz17.Text, Convert.ToString(longIDz17.Value),
                                  shortIDz18.Text, Convert.ToString(longIDz18.Value),
                                  shortIDz19.Text, Convert.ToString(longIDz19.Value),
                                  shortIDz20.Text, Convert.ToString(longIDz20.Value),
                                  shortIDz21.Text, Convert.ToString(longIDz21.Value),
                                  shortIDz22.Text, Convert.ToString(longIDz22.Value),
                                  shortIDz23.Text, Convert.ToString(longIDz23.Value), 
                                  shortIDz24.Text, Convert.ToString(longIDz24.Value),
                                  shortIDz25.Text, Convert.ToString(longIDz25.Value),
                                  shortIDz26.Text, Convert.ToString(longIDz26.Value), 
                                  shortIDz27.Text, Convert.ToString(longIDz27.Value),
                                  shortIDz28.Text, Convert.ToString(longIDz28.Value),
                                  shortIDz29.Text, Convert.ToString(longIDz29.Value),
                                  shortIDz30.Text, Convert.ToString(longIDz30.Value),
                                  shortIDz31.Text, Convert.ToString(longIDz31.Value),
                                  shortIDz32.Text, Convert.ToString(longIDz32.Value),
                                  shortIDz33.Text, Convert.ToString(longIDz33.Value), 
                                  shortIDz34.Text, Convert.ToString(longIDz34.Value),
                                  shortIDz35.Text, Convert.ToString(longIDz35.Value),
                                  shortIDz36.Text, Convert.ToString(longIDz36.Value), 
                                  shortIDz37.Text, Convert.ToString(longIDz37.Value),
                                  shortIDz38.Text, Convert.ToString(longIDz38.Value),
                                  shortIDz39.Text, Convert.ToString(longIDz39.Value),
                                  shortIDz40.Text, Convert.ToString(longIDz40.Value),
                                  shortIDz41.Text, Convert.ToString(longIDz41.Value),
                                  shortIDz42.Text, Convert.ToString(longIDz42.Value),
                                  shortIDz43.Text, Convert.ToString(longIDz43.Value), 
                                  shortIDz44.Text, Convert.ToString(longIDz44.Value),
                                  shortIDz45.Text, Convert.ToString(longIDz45.Value),
                                  shortIDz46.Text, Convert.ToString(longIDz46.Value), 
                                  shortIDz47.Text, Convert.ToString(longIDz47.Value),
                                  shortIDz48.Text, Convert.ToString(longIDz48.Value),
                                  shortIDz49.Text, Convert.ToString(longIDz49.Value),
                                  shortIDz50.Text, Convert.ToString(longIDz50.Value),
                                  shortIDz51.Text, Convert.ToString(longIDz51.Value),
                                  shortIDz52.Text, Convert.ToString(longIDz52.Value),
                                  shortIDz53.Text, Convert.ToString(longIDz53.Value), 
                                  shortIDz54.Text, Convert.ToString(longIDz54.Value),
                                  shortIDz55.Text, Convert.ToString(longIDz55.Value),
                                  shortIDz56.Text, Convert.ToString(longIDz56.Value), 
                                  shortIDz57.Text, Convert.ToString(longIDz57.Value),
                                  shortIDz58.Text, Convert.ToString(longIDz58.Value),
                                  shortIDz59.Text, Convert.ToString(longIDz59.Value),
                                  shortIDz60.Text, Convert.ToString(longIDz60.Value),
                                  shortIDz61.Text, Convert.ToString(longIDz61.Value),
                                  shortIDz62.Text, Convert.ToString(longIDz62.Value),
                                  shortIDz63.Text, Convert.ToString(longIDz63.Value), 
                                  shortIDz64.Text, Convert.ToString(longIDz64.Value)};

                for (int i = 0; i < allZones.Length; i = i + 2)
                {
                    if (allZones[i] != "sid")
                        send.remove_device(allZones[i], allZones[i + 1]);
                }
                MessageBox.Show("All zones removed", "Removing zones...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            GetAllDevice();
        }       
                                  
    }
}