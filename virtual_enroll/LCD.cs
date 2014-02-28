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
    public partial class LCD : Form
    {
        public LCD()
        {
            InitializeComponent();
        }

        public static string lcd;
        SendRequests.ISend send = (SendRequests.ISend)XmlRpcProxyGen.Create(typeof(SendRequests.ISend));

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                lcd = send.get_lcd();
                LCDlabel.Text = lcd;
            }
            catch (WebException)
            {
                LCDlabel.Text = "Unavailable...";
            }
            catch (XmlRpcIllFormedXmlException)
            {
                //MessageBox.Show("Some error happens!!!  Please tell Yuras about it.");
            }
            catch (XmlRpcFaultException)
            {
                MessageBox.Show("Some error happens!!!  Please tell Yuras about it.");
            }
        }
    }
}
