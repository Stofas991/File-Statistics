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
        Analyser Analyser;
        public Form1()
        {
            InitializeComponent();
            
        }

        public void OpenButton_Click(object sender, EventArgs e)
        {
            //initialising FileManager
            EditFile = new FileManager();
            NoFileIndicator.ForeColor = Color.Green;
            NoFileIndicator.Text = "File Selected - Analysing";
            CopyButton.Enabled = true;

            //Initialising Analyser
            Analyser = new Analyser(EditFile.fileContent);

            //counting characters
            Analyser.CountChars();
            CharLabel.Text = Analyser.characters.ToString();

            //counting lines
            Analyser.CountLines();
            LineLabel.Text = Analyser.lines.ToString();
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            EditFile.Copy();
            CopyIndicator.ForeColor = Color.Green;
            CopyIndicator.Text = "File succesfully copied into: " + EditFile.savePath;
        }

        private void CharLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
