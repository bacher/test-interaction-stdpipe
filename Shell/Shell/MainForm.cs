using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Shell
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProcessStartInfo procInfo = new ProcessStartInfo("Proc.exe");

            procInfo.RedirectStandardInput = true;
            procInfo.RedirectStandardOutput = true;
            procInfo.UseShellExecute = false;
            procInfo.CreateNoWindow = true;

            Process proc = new Process();
            proc.StartInfo = procInfo;
            proc.Start();

            int[] mas = { 1,  2, 4, 15, 3,
                          21, 4, 3, 9,  10 };

            char[] data = new char[40];
            for (int i = 0; i < 10; i++)
            {
                byte[] bytes = BitConverter.GetBytes(mas[i]);
                for (int j = 0; j < 4; j++)
                {
                    data[i * 4 + j] = (char)bytes[j];
                }
            }

            //byte[] data = BitConverter.GetBytes(10);

            //char[] data = { (char)48, (char)48, (char)48, (char)48 };

            proc.StandardInput.Write(data);            

            string result = proc.StandardOutput.ReadToEnd();

            MessageBox.Show(result);
        }
    }
}
