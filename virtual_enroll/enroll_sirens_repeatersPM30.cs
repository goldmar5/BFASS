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
    public partial class enroll_sirens_repeatersPM30 : Form
    {
        public enroll_sirens_repeatersPM30()
        {
            InitializeComponent();
        }

        string SID, LID, code;
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
                typePendantZ1.Text = "";
                typePendantZ2.Text = "";
                typePendantZ3.Text = "";
                typePendantZ4.Text = "";
                typePendantZ5.Text = "";
                typePendantZ6.Text = "";
                typePendantZ7.Text = "";
                typePendantZ8.Text = "";
                typePendantZ9.Text = "";
                typePendantZ10.Text = "";
                typePendantZ11.Text = "";
                typePendantZ12.Text = "";
                typePendantZ13.Text = "";
                typePendantZ14.Text = "";
                typePendantZ15.Text = "";

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
                longIDPendant1.Value = 1000;
                longIDPendant2.Value = 1000;
                longIDPendant3.Value = 1000;
                longIDPendant4.Value = 1000;
                longIDPendant5.Value = 1000;
                longIDPendant6.Value = 1000;
                longIDPendant7.Value = 1000;
                longIDPendant8.Value = 1000;
                longIDPendant9.Value = 1000;
                longIDPendant10.Value = 1000;
                longIDPendant11.Value = 1000;
                longIDPendant12.Value = 1000;
                longIDPendant13.Value = 1000;
                longIDPendant14.Value = 1000;
                longIDPendant15.Value = 1000;

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
                longIDPendant1.Enabled = true;
                longIDPendant2.Enabled = true;
                longIDPendant3.Enabled = true;
                longIDPendant4.Enabled = true;
                longIDPendant5.Enabled = true;
                longIDPendant6.Enabled = true;
                longIDPendant7.Enabled = true;
                longIDPendant8.Enabled = true;
                longIDPendant9.Enabled = true;
                longIDPendant10.Enabled = true;
                longIDPendant11.Enabled = true;
                longIDPendant12.Enabled = true;
                longIDPendant13.Enabled = true;
                longIDPendant14.Enabled = true;
                longIDPendant15.Enabled = true;

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
                enrollPendant1.Text = "enroll";
                enrollPendant2.Text = "enroll";
                enrollPendant3.Text = "enroll";
                enrollPendant4.Text = "enroll";
                enrollPendant5.Text = "enroll";
                enrollPendant6.Text = "enroll";
                enrollPendant7.Text = "enroll";
                enrollPendant8.Text = "enroll";
                enrollPendant9.Text = "enroll";
                enrollPendant10.Text = "enroll";
                enrollPendant11.Text = "enroll";
                enrollPendant12.Text = "enroll";
                enrollPendant13.Text = "enroll";
                enrollPendant14.Text = "enroll";
                enrollPendant15.Text = "enroll";

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
                typePendantZ1.Enabled = true;
                typePendantZ2.Enabled = true;
                typePendantZ3.Enabled = true;
                typePendantZ4.Enabled = true;
                typePendantZ5.Enabled = true;
                typePendantZ6.Enabled = true;
                typePendantZ7.Enabled = true;
                typePendantZ8.Enabled = true;
                typePendantZ9.Enabled = true;
                typePendantZ10.Enabled = true;
                typePendantZ11.Enabled = true;
                typePendantZ12.Enabled = true;
                typePendantZ13.Enabled = true;
                typePendantZ14.Enabled = true;
                typePendantZ15.Enabled = true;

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
                shortIDPendant1.Text = "sid";
                shortIDPendant2.Text = "sid";
                shortIDPendant3.Text = "sid";
                shortIDPendant4.Text = "sid";
                shortIDPendant5.Text = "sid";
                shortIDPendant6.Text = "sid";
                shortIDPendant7.Text = "sid";
                shortIDPendant8.Text = "sid";
                shortIDPendant9.Text = "sid";
                shortIDPendant10.Text = "sid";
                shortIDPendant11.Text = "sid";
                shortIDPendant12.Text = "sid";
                shortIDPendant13.Text = "sid";
                shortIDPendant14.Text = "sid";
                shortIDPendant15.Text = "sid";                
                
                //_DeviceNames[OUTDOOR_SIREN]:     _DevClass["SIRENS"]     +'\x01',
                //_DeviceNames[INDOOR_SIREN]:      _DevClass["SIRENS"]     +'\x02',                
                //_DeviceNames[REPEATER]:          _DevClass["REPEATERS"]  +'\x01',                

                DeviceInfo[] DevInfo;
                DevInfo = send.get_all_devices();                

                for (int i = 0; i < DevInfo.Length; i++)
                {
                    if (DevInfo[i].type == "INDOOR_SIREN" || DevInfo[i].type == "OUTDOOR_SIREN")
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
                        }
                    }
                    
                    if (DevInfo[i].type == "REPEATER")
                    {
                        switch (Convert.ToInt32(DevInfo[i].num))
                        {
                            case 1:
                                longIDz9.Text = DevInfo[i].lid;
                                shortIDz9.Text = DevInfo[i].sid;
                                typeZ9.Text = DevInfo[i].type;
                                longIDz9.Enabled = false;
                                typeZ9.Enabled = false;
                                enrollZ9.Text = "remove";
                                break;

                            case 2:
                                longIDz10.Text = DevInfo[i].lid;
                                shortIDz10.Text = DevInfo[i].sid;
                                typeZ10.Text = DevInfo[i].type;
                                longIDz10.Enabled = false;
                                typeZ10.Enabled = false;
                                enrollZ10.Text = "remove";
                                break;

                            case 3:
                                longIDz11.Text = DevInfo[i].lid;
                                shortIDz11.Text = DevInfo[i].sid;
                                typeZ11.Text = DevInfo[i].type;
                                longIDz11.Enabled = false;
                                typeZ11.Enabled = false;
                                enrollZ11.Text = "remove";
                                break;

                            case 4:
                                longIDz12.Text = DevInfo[i].lid;
                                shortIDz12.Text = DevInfo[i].sid;
                                typeZ12.Text = DevInfo[i].type;
                                longIDz12.Enabled = false;
                                typeZ12.Enabled = false;
                                enrollZ12.Text = "remove";
                                break;
                        }
                    }

                    if (DevInfo[i].type == "PENDENT_PANIC_101" || DevInfo[i].type == "PANIC_102")
                    {
                        switch (Convert.ToInt32(DevInfo[i].num))
                        {
                            case 1:                                
                                longIDPendant1.Text = DevInfo[i].lid;
                                shortIDPendant1.Text = DevInfo[i].sid;
                                typePendantZ1.Text = DevInfo[i].type;
                                longIDPendant1.Enabled = false;
                                typePendantZ1.Enabled = false;
                                enrollPendant1.Text = "remove";
                                break;

                            case 2:
                                longIDPendant2.Text = DevInfo[i].lid;
                                shortIDPendant2.Text = DevInfo[i].sid;
                                typePendantZ2.Text = DevInfo[i].type;
                                longIDPendant2.Enabled = false;
                                typePendantZ2.Enabled = false;
                                enrollPendant2.Text = "remove";
                                break;

                            case 3:
                                longIDPendant3.Text = DevInfo[i].lid;
                                shortIDPendant3.Text = DevInfo[i].sid;
                                typePendantZ3.Text = DevInfo[i].type;
                                longIDPendant3.Enabled = false;
                                typePendantZ3.Enabled = false;
                                enrollPendant3.Text = "remove";
                                break;

                            case 4:
                                longIDPendant4.Text = DevInfo[i].lid;
                                shortIDPendant4.Text = DevInfo[i].sid;
                                typePendantZ4.Text = DevInfo[i].type;
                                longIDPendant4.Enabled = false;
                                typePendantZ4.Enabled = false;
                                enrollPendant4.Text = "remove";
                                break;

                            case 5:
                                longIDPendant5.Text = DevInfo[i].lid;
                                shortIDPendant5.Text = DevInfo[i].sid;
                                typePendantZ5.Text = DevInfo[i].type;
                                longIDPendant5.Enabled = false;
                                typePendantZ5.Enabled = false;
                                enrollPendant5.Text = "remove";
                                break;

                            case 6:
                                longIDPendant6.Text = DevInfo[i].lid;
                                shortIDPendant6.Text = DevInfo[i].sid;
                                typePendantZ6.Text = DevInfo[i].type;
                                longIDPendant6.Enabled = false;
                                typePendantZ6.Enabled = false;
                                enrollPendant6.Text = "remove";
                                break;

                            case 7:
                                longIDPendant7.Text = DevInfo[i].lid;
                                shortIDPendant7.Text = DevInfo[i].sid;
                                typePendantZ7.Text = DevInfo[i].type;
                                longIDPendant7.Enabled = false;
                                typePendantZ7.Enabled = false;
                                enrollPendant7.Text = "remove";
                                break;

                            case 8:
                                longIDPendant8.Text = DevInfo[i].lid;
                                shortIDPendant8.Text = DevInfo[i].sid;
                                typePendantZ8.Text = DevInfo[i].type;
                                longIDPendant8.Enabled = false;
                                typePendantZ8.Enabled = false;
                                enrollPendant8.Text = "remove";
                                break;

                            case 9:
                                longIDPendant9.Text = DevInfo[i].lid;
                                shortIDPendant9.Text = DevInfo[i].sid;
                                typePendantZ9.Text = DevInfo[i].type;
                                longIDPendant9.Enabled = false;
                                typePendantZ9.Enabled = false;
                                enrollPendant9.Text = "remove";
                                break;

                            case 10:
                                longIDPendant10.Text = DevInfo[i].lid;
                                shortIDPendant10.Text = DevInfo[i].sid;
                                typePendantZ10.Text = DevInfo[i].type;
                                longIDPendant10.Enabled = false;
                                typePendantZ10.Enabled = false;
                                enrollPendant10.Text = "remove";
                                break;

                            case 11:
                                longIDPendant11.Text = DevInfo[i].lid;
                                shortIDPendant11.Text = DevInfo[i].sid;
                                typePendantZ11.Text = DevInfo[i].type;
                                longIDPendant11.Enabled = false;
                                typePendantZ11.Enabled = false;
                                enrollPendant11.Text = "remove";
                                break;

                            case 12:
                                longIDPendant12.Text = DevInfo[i].lid;
                                shortIDPendant12.Text = DevInfo[i].sid;
                                typePendantZ12.Text = DevInfo[i].type;
                                longIDPendant12.Enabled = false;
                                typePendantZ12.Enabled = false;
                                enrollPendant12.Text = "remove";
                                break;

                            case 13:
                                longIDPendant13.Text = DevInfo[i].lid;
                                shortIDPendant13.Text = DevInfo[i].sid;
                                typePendantZ13.Text = DevInfo[i].type;
                                longIDPendant13.Enabled = false;
                                typePendantZ13.Enabled = false;
                                enrollPendant13.Text = "remove";
                                break;

                            case 14:
                                longIDPendant14.Text = DevInfo[i].lid;
                                shortIDPendant14.Text = DevInfo[i].sid;
                                typePendantZ14.Text = DevInfo[i].type;
                                longIDPendant14.Enabled = false;
                                typePendantZ14.Enabled = false;
                                enrollPendant14.Text = "remove";
                                break;

                            case 15:
                                longIDPendant15.Text = DevInfo[i].lid;
                                shortIDPendant15.Text = DevInfo[i].sid;
                                typePendantZ15.Text = DevInfo[i].type;
                                longIDPendant15.Enabled = false;
                                typePendantZ15.Enabled = false;
                                enrollPendant15.Text = "remove";
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
                    statusLabel.Text = "Ready";
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

        private void enroll_sirens_repeatersPM30_Activated(object sender, EventArgs e)
        {
            GetAllDevice();
        }

        //================= ENROLL =========================================

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
            enroll_remove(typeZ9, longIDz9, enrollZ9, shortIDz9, "1");
        }

        private void enrollZ10_Click(object sender, EventArgs e)
        {
            enroll_remove(typeZ10, longIDz10, enrollZ10, shortIDz10, "2");
        }

        private void enrollZ11_Click(object sender, EventArgs e)
        {
            enroll_remove(typeZ11, longIDz11, enrollZ11, shortIDz11, "3");
        }

        private void enrollZ12_Click(object sender, EventArgs e)
        {
            enroll_remove(typeZ12, longIDz12, enrollZ12, shortIDz12, "4");
        }

        private void enrollPendant1_Click(object sender, EventArgs e)
        {
            enroll_remove(typePendantZ1, longIDPendant1, enrollPendant1, shortIDPendant1, "1");
        }

        private void enrollPendant2_Click(object sender, EventArgs e)
        {
            enroll_remove(typePendantZ2, longIDPendant2, enrollPendant2, shortIDPendant2, "2");
        }

        private void enrollPendant3_Click(object sender, EventArgs e)
        {
            enroll_remove(typePendantZ3, longIDPendant3, enrollPendant3, shortIDPendant3, "3");
        }

        private void enrollPendant4_Click(object sender, EventArgs e)
        {
            enroll_remove(typePendantZ4, longIDPendant4, enrollPendant4, shortIDPendant4, "4");
        }

        private void enrollPendant5_Click(object sender, EventArgs e)
        {
            enroll_remove(typePendantZ5, longIDPendant5, enrollPendant5, shortIDPendant5, "5");
        }

        private void enrollPendant6_Click(object sender, EventArgs e)
        {
            enroll_remove(typePendantZ6, longIDPendant6, enrollPendant6, shortIDPendant6, "6");
        }

        private void enrollPendant7_Click(object sender, EventArgs e)
        {
            enroll_remove(typePendantZ7, longIDPendant7, enrollPendant7, shortIDPendant7, "7");
        }

        private void enrollPendant8_Click(object sender, EventArgs e)
        {
            enroll_remove(typePendantZ8, longIDPendant8, enrollPendant8, shortIDPendant8, "8");
        }

        private void enrollPendant9_Click(object sender, EventArgs e)
        {
            enroll_remove(typePendantZ9, longIDPendant9, enrollPendant9, shortIDPendant9, "9");
        }

        private void enrollPendant10_Click(object sender, EventArgs e)
        {
            enroll_remove(typePendantZ10, longIDPendant10, enrollPendant10, shortIDPendant10, "10");
        }

        private void enrollPendant11_Click(object sender, EventArgs e)
        {
            enroll_remove(typePendantZ11, longIDPendant11, enrollPendant11, shortIDPendant11, "11");
        }

        private void enrollPendant12_Click(object sender, EventArgs e)
        {
            enroll_remove(typePendantZ12, longIDPendant12, enrollPendant12, shortIDPendant12, "12");
        }

        private void enrollPendant13_Click(object sender, EventArgs e)
        {
            enroll_remove(typePendantZ13, longIDPendant13, enrollPendant13, shortIDPendant13, "13");
        }

        private void enrollPendant14_Click(object sender, EventArgs e)
        {
            enroll_remove(typePendantZ14, longIDPendant14, enrollPendant14, shortIDPendant14, "14");
        }

        private void enrollPendant15_Click(object sender, EventArgs e)
        {
            enroll_remove(typePendantZ15, longIDPendant15, enrollPendant15, shortIDPendant15, "15");
        }   
        //==============================================================

        
        //private void timer1_Tick_1(object sender, EventArgs e)
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

            if (devType == "REPEATER")
            {
                jammingMenu.Visible = true;
            }

            if (devType == "PENDENT_PANIC_101")
            {
                PanicMenu.Visible = false;
                lowbatteryMenu.Visible = true;
                tamperMenu.Visible = false;
            }

            if (devType == "PANIC_102")
            {
                armawayMenu.Visible = false;
                disarmMenu.Visible = false;
                lowbatteryMenu.Visible = true;
                tamperMenu.Visible = false;
            }
        }

        private void DisableAllFaults()
        {
            deviceDoesnotEnrolledMenu.Visible = false;
            syncMenu.Visible = true;
            tamperMenu.Visible = true;
            lowbatteryMenu.Visible = true;
            jammingMenu.Visible = false;
            PanicMenu.Visible = false;
            armawayMenu.Visible = false;
            disarmMenu.Visible = false;
        }

        public void SidLidDefinition(Control devType)
        {
            string zoneNUMBER = Convert.ToString(devType).Substring(Convert.ToString(devType).IndexOf("#") + 1);

            if (Convert.ToString(devType).Contains("Siren"))
            {
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
                }
            }

            if (Convert.ToString(devType).Contains("Repeater"))
            {
                switch (Convert.ToInt32(zoneNUMBER))
                {
                    case 1:
                        LID = Convert.ToString(longIDz9.Value);
                        SID = shortIDz9.Text;
                        showFaultyForType(typeZ9.Text);
                        break;
                    case 2:
                        LID = Convert.ToString(longIDz10.Value);
                        SID = shortIDz10.Text;
                        showFaultyForType(typeZ10.Text);
                        break;
                    case 3:
                        LID = Convert.ToString(longIDz11.Value);
                        SID = shortIDz11.Text;
                        showFaultyForType(typeZ11.Text);
                        break;
                    case 4:
                        LID = Convert.ToString(longIDz12.Value);
                        SID = shortIDz12.Text;
                        showFaultyForType(typeZ12.Text);
                        break;
                }
            }

            if (Convert.ToString(devType).Contains("Pendant"))
            {
                code = "0xAAAA";
                switch (Convert.ToInt32(zoneNUMBER))
                {
                    case 1:                        
                        LID = Convert.ToString(longIDPendant1.Value);
                        SID = shortIDPendant1.Text;
                        showFaultyForType(typePendantZ1.Text);
                        break;
                    case 2:
                        LID = Convert.ToString(longIDPendant2.Value);
                        SID = shortIDPendant2.Text;
                        showFaultyForType(typePendantZ2.Text);
                        break;
                    case 3:
                        LID = Convert.ToString(longIDPendant3.Value);
                        SID = shortIDPendant3.Text;
                        showFaultyForType(typePendantZ3.Text);
                        break;
                    case 4:
                        LID = Convert.ToString(longIDPendant4.Value);
                        SID = shortIDPendant4.Text;
                        showFaultyForType(typePendantZ4.Text);
                        break;
                    case 5:
                        LID = Convert.ToString(longIDPendant5.Value);
                        SID = shortIDPendant5.Text;
                        showFaultyForType(typePendantZ5.Text);
                        break;
                    case 6:
                        LID = Convert.ToString(longIDPendant6.Value);
                        SID = shortIDPendant6.Text;
                        showFaultyForType(typePendantZ6.Text);
                        break;
                    case 7:
                        LID = Convert.ToString(longIDPendant7.Value);
                        SID = shortIDPendant7.Text;
                        showFaultyForType(typePendantZ7.Text);
                        break;
                    case 8:
                        LID = Convert.ToString(longIDPendant8.Value);
                        SID = shortIDPendant8.Text;
                        showFaultyForType(typePendantZ8.Text);
                        break;
                    case 9:
                        LID = Convert.ToString(longIDPendant9.Value);
                        SID = shortIDPendant9.Text;
                        showFaultyForType(typePendantZ9.Text);
                        break;
                    case 10:
                        LID = Convert.ToString(longIDPendant10.Value);
                        SID = shortIDPendant10.Text;
                        showFaultyForType(typePendantZ10.Text);
                        break;
                    case 11:
                        LID = Convert.ToString(longIDPendant11.Value);
                        SID = shortIDPendant11.Text;
                        showFaultyForType(typePendantZ11.Text);
                        break;
                    case 12:
                        LID = Convert.ToString(longIDPendant12.Value);
                        SID = shortIDPendant12.Text;
                        showFaultyForType(typePendantZ12.Text);
                        break;
                    case 13:
                        LID = Convert.ToString(longIDPendant13.Value);
                        SID = shortIDPendant13.Text;
                        showFaultyForType(typePendantZ13.Text);
                        break;
                    case 14:
                        LID = Convert.ToString(longIDPendant14.Value);
                        SID = shortIDPendant14.Text;
                        showFaultyForType(typePendantZ14.Text);
                        break;
                    case 15:
                        LID = Convert.ToString(longIDPendant15.Value);
                        SID = shortIDPendant15.Text;
                        showFaultyForType(typePendantZ15.Text);
                        break;                    
                }
            }
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

        private void open_jamming(string lid, string sid)
        {
            send.open_jamming(sid, lid);
        }

        private void close_jamming(string lid, string sid)
        {
            send.close_jamming(sid, lid);
        }

        private void panic(string lid, string sid)
        {
            send.panic(sid, lid);
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

        //===================== ALL CONTEXT MENU ITEMS CLICK =================================

        private void syncMenu_Click(object sender, EventArgs e)
        {
            update(LID, SID);
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

        private void openJammingMenu_Click(object sender, EventArgs e)
        {
            open_jamming(LID, SID);
        }

        private void restoreJammingMenu_Click(object sender, EventArgs e)
        {
            close_jamming(LID, SID);
        }

        private void PanicMenu_Click(object sender, EventArgs e)
        {
            panic(LID, SID);
        }

        private void armawayMenu_Click(object sender, EventArgs e)
        {
            arm_away(LID, SID, code);
        }

        private void disarmMenu_Click(object sender, EventArgs e)
        {
            arm_away(LID, SID, code);
        }
        //====================================================================================
        
        private void allSirensEnrollToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("All Sirens(8) will be enrolled", "Enrolling sirens...", MessageBoxButtons.OK, MessageBoxIcon.Information);

            try
            {
                send.enroll("INDOOR_SIREN", "1000");
                Thread.Sleep(200);
                send.enroll("OUTDOOR_SIREN", "1000");
                Thread.Sleep(200);
                send.enroll("INDOOR_SIREN", "1001");
                Thread.Sleep(200);
                send.enroll("OUTDOOR_SIREN", "1001");
                Thread.Sleep(200);
                send.enroll("INDOOR_SIREN", "1002");
                Thread.Sleep(200);
                send.enroll("OUTDOOR_SIREN", "1002");
                Thread.Sleep(200);
                send.enroll("INDOOR_SIREN", "1003");
                Thread.Sleep(200);
                send.enroll("OUTDOOR_SIREN", "1003");
            }
            catch (XmlRpcInvalidXmlRpcException)
            {

            }
            statusLabel.Text = "Ready";
            GetAllDevice();

            MessageBox.Show("All sirens enrolled", "Enrolling sirens...", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void allRepeatersEnrollToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("All Repeaters(4) will be enrolled", "Enrolling repeaters...", MessageBoxButtons.OK, MessageBoxIcon.Information);

            try
            {
                send.enroll("REPEATER", "1000");
                Thread.Sleep(200);
                send.enroll("REPEATER", "1001");
                Thread.Sleep(200);
                send.enroll("REPEATER", "1002");
                Thread.Sleep(200);
                send.enroll("REPEATER", "1003");
            }
            catch (XmlRpcInvalidXmlRpcException)
            {

            }

            statusLabel.Text = "Ready";
            GetAllDevice();

            MessageBox.Show("All repeaters enrolled", "Enrolling repeaters...", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void allPendantsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("All Pendants(15) will be enrolled", "Enrolling pendants...", MessageBoxButtons.OK, MessageBoxIcon.Information);

            try
            {
                send.enroll("PENDENT_PANIC_101", "1000");
                Thread.Sleep(200);
                send.enroll("PANIC_102", "1000");
                Thread.Sleep(200);
                send.enroll("PENDENT_PANIC_101", "1001");
                Thread.Sleep(200);
                send.enroll("PANIC_102", "1001");
                Thread.Sleep(200);
                send.enroll("PENDENT_PANIC_101", "1002");
                Thread.Sleep(200);
                send.enroll("PANIC_102", "1002");
                Thread.Sleep(200);
                send.enroll("PENDENT_PANIC_101", "1003");
                Thread.Sleep(200);
                send.enroll("PANIC_102", "1003");
                Thread.Sleep(200);
                send.enroll("PENDENT_PANIC_101", "1004");
                Thread.Sleep(200);
                send.enroll("PANIC_102", "1004");
                Thread.Sleep(200);
                send.enroll("PENDENT_PANIC_101", "1005");
                Thread.Sleep(200);
                send.enroll("PANIC_102", "1005");
                Thread.Sleep(200);
                send.enroll("PENDENT_PANIC_101", "1006");
                Thread.Sleep(200);
                send.enroll("PANIC_102", "1006");
                Thread.Sleep(200);
                send.enroll("PENDENT_PANIC_101", "1007");                
            }
            catch (XmlRpcInvalidXmlRpcException)
            {

            }

            statusLabel.Text = "Ready";
            GetAllDevice();

            MessageBox.Show("All pendants enrolled", "Enrolling pendants...", MessageBoxButtons.OK, MessageBoxIcon.Information);
        } 

        private void allSirensRemoveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure to remove all sirens?", "Removing sirens...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                string[] allSirens = {shortIDz1.Text, Convert.ToString(longIDz1.Value),
                                  shortIDz2.Text, Convert.ToString(longIDz2.Value),
                                  shortIDz3.Text, Convert.ToString(longIDz3.Value), 
                                  shortIDz4.Text, Convert.ToString(longIDz4.Value),
                                  shortIDz5.Text, Convert.ToString(longIDz5.Value),
                                  shortIDz6.Text, Convert.ToString(longIDz6.Value), 
                                  shortIDz7.Text, Convert.ToString(longIDz7.Value),
                                  shortIDz8.Text, Convert.ToString(longIDz8.Value)};

                for (int i = 0; i < allSirens.Length; i = i + 2)
                {
                    if (allSirens[i] != "sid")
                        send.remove_device(allSirens[i], allSirens[i + 1]);
                }
                MessageBox.Show("All sirens removed", "Removing sirens...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            GetAllDevice();
        }

        private void allRepeatersRemoveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure to remove all repeaters?", "Removing repeaters...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                string[] allRepeaters = {shortIDz9.Text, Convert.ToString(longIDz9.Value),
                                     shortIDz10.Text, Convert.ToString(longIDz10.Value),
                                     shortIDz11.Text, Convert.ToString(longIDz11.Value), 
                                     shortIDz12.Text, Convert.ToString(longIDz12.Value)};

                for (int i = 0; i < allRepeaters.Length; i = i + 2)
                {
                    if (allRepeaters[i] != "sid")
                        send.remove_device(allRepeaters[i], allRepeaters[i + 1]);
                }
                MessageBox.Show("All repeaters removed", "Removing repeaters...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            GetAllDevice();
        }

        private void allPendantsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure to remove all pendants?", "Removing pendants...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {                
                string[] allPendants = {shortIDPendant1.Text, Convert.ToString(longIDPendant1.Value),
                                  shortIDPendant2.Text, Convert.ToString(longIDPendant2.Value),
                                  shortIDPendant3.Text, Convert.ToString(longIDPendant3.Value), 
                                  shortIDPendant4.Text, Convert.ToString(longIDPendant4.Value),
                                  shortIDPendant5.Text, Convert.ToString(longIDPendant5.Value),
                                  shortIDPendant6.Text, Convert.ToString(longIDPendant6.Value),
                                  shortIDPendant7.Text, Convert.ToString(longIDPendant7.Value), 
                                  shortIDPendant8.Text, Convert.ToString(longIDPendant8.Value),
                                  shortIDPendant9.Text, Convert.ToString(longIDPendant9.Value),
                                  shortIDPendant10.Text, Convert.ToString(longIDPendant10.Value), 
                                  shortIDPendant11.Text, Convert.ToString(longIDPendant11.Value),
                                  shortIDPendant12.Text, Convert.ToString(longIDPendant12.Value),
                                  shortIDPendant13.Text, Convert.ToString(longIDPendant13.Value), 
                                  shortIDPendant14.Text, Convert.ToString(longIDPendant14.Value),
                                  shortIDPendant15.Text, Convert.ToString(longIDPendant15.Value)};

                for (int i = 0; i < allPendants.Length; i = i + 2)
                {
                    if (allPendants[i] != "sid")
                        send.remove_device(allPendants[i], allPendants[i + 1]);
                }
                MessageBox.Show("All pendants removed", "Removing pendants...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            GetAllDevice();
        }
    }
}
