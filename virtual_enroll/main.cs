using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

using CookComputing.XmlRpc;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Collections.Specialized;

namespace BFASS
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }
        

        public static void StartSimulator()
        {
            Process.Start("cmd.exe", "/C " + "DeviceSimulator.py" + " && pause"); 
        }

        public static void StopSimulator()
        {
            Process.Start("cmd.exe", "/C " + "TASKKILL /F /IM python.exe");
        }       

        private void enroll_detetors_Click(object sender, EventArgs e)
        {
            
        }

        private void main_Load(object sender, EventArgs e)
        {
            StartSimulator();
        }

        private void PowerMaster30Button_Click(object sender, EventArgs e)
        {
            PowerMaster30 PM30 = new PowerMaster30();
            PM30.Show();
        }

        private void PowerMaster10Button_Click(object sender, EventArgs e)
        {
            PowerMaster10 PM10 = new PowerMaster10();
            PM10.Show();
        }

        private void helpMenu_Click(object sender, EventArgs e)
        {
            help helpForm = new help();
            helpForm.Show();
        }

        private void aboutMenu_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"Special for VISONIC/TYCO

Developed by: Yuriy Sadovskiy
      yuriys@tycoint.com", "Developed by", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        
            
    }
}
