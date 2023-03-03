using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
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
        private const string ACTION_DIACRITIC = "DIACRITIC";
        private const string ACTION_PUNCTUATION = "PUNCTUATION";
        public Form1()
        {
            InitializeComponent();
            textBox1.ScrollBars = ScrollBars.Both;
            textBox1.WordWrap = false;
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
        }

        private void RemoveDiacritics_Click(object sender, EventArgs e)
        {
            //preparing progress bar
            DisableButtons();
            progressBar.Visible = true;
            cancelAction.Visible = true;
            cancelAction.Enabled = true;
            progressBar.Value = 0;
            progressBar.Maximum = EditFile.fileContent.Length;
            //calling function from action class
            backgroundWorker1.RunWorkerAsync(argument: ACTION_DIACRITIC);
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
            DisableButtons();
            progressBar.Visible = true;
            cancelAction.Visible = true;
            cancelAction.Enabled = true;
            progressBar.Value = 0;
            progressBar.Maximum = EditFile.fileContent.Length;

            backgroundWorker1.RunWorkerAsync(argument: ACTION_PUNCTUATION);
        }

        //function to set labels to their new values
        private void ActualizeLabels()
        {
            //putting text in preview window
            textBox1.Text = EditFile.fileContent;
            Analyser.Count(EditFile.fileContent);
            CharLabel.Text = Analyser.characters.ToString();
            LineLabel.Text = Analyser.lines.ToString();
            WordLabel.Text = Analyser.words.ToString();
            SentenceLabel.Text = Analyser.sentences.ToString();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            switch(e.Argument)
            {
                case ACTION_DIACRITIC:
                    Actions.RemoveDiacritics(progressBar, sender as BackgroundWorker);
                    break;

                case ACTION_PUNCTUATION:
                    Actions.RemovePunctuation(progressBar, sender as BackgroundWorker);
                    break;
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            EditFile.fileContent = Actions.FileContent;
            //actualising and saving, hiding progress bar
            ActualizeLabels();
            EditFile.Save();
            EnableButtons();
        }

        private void DisableButtons()
        {
            RemoveDiacritics.Enabled = false;
            RemoveLines.Enabled = false;
            CopyButton.Enabled = false;
            RemoveSpaces.Enabled = false;
            OpenButton.Enabled = false;
        }

        private void EnableButtons()
        {
            RemoveDiacritics.Enabled = true;
            RemoveLines.Enabled = true;
            CopyButton.Enabled = true;
            RemoveSpaces.Enabled = true;
            OpenButton.Enabled = true;

        }

        private void cancelAction_Click(object sender, EventArgs e)
        {
            if(backgroundWorker1.WorkerSupportsCancellation)
            {
                backgroundWorker1.CancelAsync();
            }
        }
    }
}
