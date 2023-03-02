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
        Actions Actions;
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
            RemoveDiacritics.Enabled = true;
            RemoveLines.Enabled = true;
            RemoveSpaces.Enabled = true;
            progressBar.Enabled = true;
            progressBar.Maximum = EditFile.fileContent.Length;

            //Initialising Analyser
            Analyser = new Analyser(EditFile.fileContent);

            //calculate and set new values
            ActualizeLabels();

            //Initialising Action class
            Actions = new Actions(EditFile.fileContent);
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            EditFile.Save();
            CopyIndicator.ForeColor = Color.Green;
            CopyIndicator.Text = "File succesfully copied into: " + EditFile.savePath;
        }

        private void CharLabel_Click(object sender, EventArgs e)
        {

        }

        private void RemoveDiacritics_Click(object sender, EventArgs e)
        {
            Actions.RemoveDiacritics();
            EditFile.fileContent = Actions.FileContent;
            EditFile.Save();
        }

        private void RemoveLines_Click(object sender, EventArgs e)
        {
            Actions.RemoveEmptyLines();
            EditFile.fileContent = Actions.FileContent;
            ActualizeLabels();
            EditFile.Save();
        }
        private void RemoveSpaces_Click(object sender, EventArgs e)
        {
            progressBar.Visible = true;
            Actions.RemovePunctuation(progressBar);
            EditFile.fileContent = Actions.FileContent;
            ActualizeLabels();
            EditFile.Save();
            progressBar.Visible = false;
        }

        //function to set labels to their new values
        private void ActualizeLabels()
        {
            Analyser.Count(EditFile.fileContent);
            CharLabel.Text = Analyser.characters.ToString();
            LineLabel.Text = Analyser.lines.ToString();
            WordLabel.Text = Analyser.words.ToString();
            SentenceLabel.Text = Analyser.sentences.ToString();
        }


    }
}
