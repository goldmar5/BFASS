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

namespace BFASS
{
    public partial class PowerMaster10 : Form
    {
        public PowerMaster10()
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
    }
}
