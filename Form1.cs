using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileCopyTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTest1_Click(object sender, EventArgs e)
        {
            lblResults.Text = "Starting test1...";
            string fileToCopy = "c:\\tmp\\from1.txt";
            string destinationDirectory = "c:\\log\\from1.txt";

            File.Copy(fileToCopy, destinationDirectory, true);
            lblResults.Text = "Done - Copied locally";
        }

        private void btnTestNetworkDrive_Click(object sender, EventArgs e)
        {
            lblResults.Text = "Starting test2...";
            string fileToCopy = "c:\\tmp\\from1.txt";
            string destinationDirectory = "\\\\BeeStation\\home\\Files\\shock\\from2.txt";

            File.Copy(fileToCopy, destinationDirectory, true);
            lblResults.Text = "Done - Copied remotely";
        }
    }
}
