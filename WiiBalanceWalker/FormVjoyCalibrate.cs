using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WiiBalanceWalker
{
    public partial class FormVjoyCalibrate : Form
    {
        public FormVjoyCalibrate()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*Process.Start("notepad", "readme.txt");

            string winpath = Environment.GetEnvironmentVariable("windir");
            string path = System.IO.Path.GetDirectoryName(
                          System.Windows.Forms.Application.ExecutablePath);

            Process.Start(winpath + @"\Microsoft.NET\Framework\v1.0.3705\Installutil.exe",
            path + "\\MyService.exe");*/


            System.Diagnostics.Process.Start("joy.cpl");
        }
    }
}
