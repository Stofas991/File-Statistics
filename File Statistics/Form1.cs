using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace File_Statistics
{
    
    public partial class Form1 : Form
    {
        FileManager EditFile;
        public Form1()
        {
            InitializeComponent();
            
        }

        public void OpenButton_Click(object sender, EventArgs e)
        {
            EditFile = new FileManager();
            NoFileIndicator.ForeColor = Color.Green;
            NoFileIndicator.Text = "File Selected - Starting to analyse";
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            EditFile.Copy();
            CopyIndicator.ForeColor = Color.Green;
            CopyIndicator.Text = "File succesfully copied into: " + EditFile.savePath;
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }
    }
}
