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
using System.Threading;

namespace BFASS
{
    public partial class PowerMaster30 : Form
    {
        public PowerMaster30()
        {
            InitializeComponent();
        }

        SendRequests.ISend send = (SendRequests.ISend)XmlRpcProxyGen.Create(typeof(SendRequests.ISend));

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                LCDlabel.Text = LCD.lcd;
            }
            catch (WebException)
            {
                LCDlabel.Text = "Unavailable...";
            }
            catch (XmlRpcFaultException)
            {
                MessageBox.Show("Some error happens!!!  Please tell Yuras about it.");
            }
        }

        private void panel1utton_Click(object sender, EventArgs e)
        {
            send.send_key("1");
        }

        private void panel2button_Click(object sender, EventArgs e)
        {
            send.send_key("2");
        }

        private void panel3button_Click(object sender, EventArgs e)
        {
            send.send_key("3");
        }

        private void panel4button_Click(object sender, EventArgs e)
        {
            send.send_key("4");
        }

        private void panel5button_Click(object sender, EventArgs e)
        {
            send.send_key("5");
        }

        private void panel6button_Click(object sender, EventArgs e)
        {
            send.send_key("6");
        }

        private void panel7button_Click(object sender, EventArgs e)
        {
            send.send_key("7");
        }

        private void panel8button_Click(object sender, EventArgs e)
        {
            send.send_key("8");
        }

        private void panel9button_Click(object sender, EventArgs e)
        {
            send.send_key("9");
        }

        private void panel0button_Click(object sender, EventArgs e)
        {
            send.send_key("0");
        }

        private void panelZDEZDO4KAbutton_Click(object sender, EventArgs e)
        {
            send.send_key("*");
        }

        private void panelREWETKAbutton_Click(object sender, EventArgs e)
        {
            send.send_key("#");
        }

        private void panelAWAYbutton_Click(object sender, EventArgs e)
        {
            send.send_key("AWAY");
        }

        private void panelHOMEbutton_Click(object sender, EventArgs e)
        {
            send.send_key("HOME");
        }

        private void panelDISARMbutton_Click(object sender, EventArgs e)
        {
            send.send_key("OFF");
        }

        private void panelBACKbutton_Click(object sender, EventArgs e)
        {
            send.send_key("BACK");
        }

        private void panelEMERGENCYbutton_Click(object sender, EventArgs e)
        {
            send.send_key("EMERGENCY");
        }

        private void panelFIREbutton_Click(object sender, EventArgs e)
        {
            send.send_key("FIRE");
        }

        private void panelMENUbutton_Click(object sender, EventArgs e)
        {
            send.send_key("NEXT");
        }

        private void panelOKbutton_Click(object sender, EventArgs e)
        {
            send.send_key("OK");
        }

        private void panelPANICbutton_Click(object sender, EventArgs e)
        {
            send.send_key("PANIC");
        }

        private void PowerMaster30_Load(object sender, EventArgs e)
        {
            LCD lcd = new LCD();

            if ((Application.OpenForms["LCD"] as LCD) == null)
            {
                lcd.Show();
            }
        }

        private void EnrollAllDevicesStripButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure to add all devices(64 zones, 17 keyfobs, 14 keypads, 15 pendants, 8 sirens and 4 repeaters)? It takes about 1 minute.", "Enrolling all devices...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                    Thread.Sleep(200);

                    send.enroll("REPEATER", "1000");
                    Thread.Sleep(200);
                    send.enroll("REPEATER", "1001");
                    Thread.Sleep(200);
                    send.enroll("REPEATER", "1002");
                    Thread.Sleep(200);
                    send.enroll("REPEATER", "1003");
                    Thread.Sleep(200);

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
                    Thread.Sleep(200);
                }
                catch (XmlRpcInvalidXmlRpcException)
                {

                }

                MessageBox.Show("All devices enrolled", "Enrolling all devices...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void updateAllDevicesStripButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("It takes some time. Be patient.", "Updating all devices...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            send.update_all_devices();
            Thread.Sleep(1000);
            send.update_all_devices();
            MessageBox.Show("All devices updated.", "Updating all devices...", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void RemoveAlDeviceslStripButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure to remove all device? All devices(real and virtual) will be removed.", "Removing all devices...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show("It takes some time. Be patient.", "Removing all devices...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                send.remove_all_devices();
                send.remove_all_devices();
                send.remove_all_devices();
                MessageBox.Show("All devices removed", "Removing all devices...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BackToFactoryStripButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure to back to factory defaults? All settings will be erased.", "Back to factory defaults...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                send.back_to_factory_defaults();
                MessageBox.Show("Factory defaults restored.", "Back to factory defaults...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void zonesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            enroll_zonesPM30 enrollZonesPM30 = new enroll_zonesPM30();
            enrollZonesPM30.Show();
        }

        private void keyfobsKeypadsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            enroll_keyfobs_keypadsPM30 enrollKeyfobsKeypadsPM30 = new enroll_keyfobs_keypadsPM30();
            enrollKeyfobsKeypadsPM30.Show();
        }

        private void sirensRepeatersToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            enroll_sirens_repeatersPM30 enrollSirensRepeatersPM30 = new enroll_sirens_repeatersPM30();
            enrollSirensRepeatersPM30.Show();
        }
    }
}