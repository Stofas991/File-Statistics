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
        FileManager EditFile = new FileManager();
        //Initialising Analyser
        Analyser Analyser = new Analyser();
        Actions Actions = new Actions();
        private const string ACTION_DIACRITIC = "DIACRITIC";
        private const string ACTION_PUNCTUATION = "PUNCTUATION";
        private int ActualPercent = 0;
        private bool ActionCanceled = false;
        public Form1()
        {
            InitializeComponent();
            textBox1.ScrollBars = ScrollBars.Both;
            textBox1.WordWrap = false;
        }

        public void OpenButton_Click(object sender, EventArgs e)
        {
            //Opening file, checking if file is opened or not
            if (!EditFile.Open())
                return;

            NoFileIndicator.ForeColor = Color.Green;
            NoFileIndicator.Text = "Soubor úspěšně načten";

            //Enabling all buttons
            EnableButtons();

            //calculate and set newly acquired values
            ActualizeLabels();

            //setting content from file for future usage
            Actions.FileContent = EditFile.fileContent;
        }

        //function that is called upon clicking button "kopírovat" 
        private void CopyButton_Click(object sender, EventArgs e)
        {
            EditFile.Save();
        }

        //function that is called upon clicking button "odstranit diakritiku" 
        private void RemoveDiacritics_Click(object sender, EventArgs e)
        {
            //disabling buttons that are not available during actions
            DisableButtons();
            //preparing progress bar
            ActivateBar();
            progressBar.Value = 0;
            progressBar.Maximum = EditFile.fileContent.Length;
            //calling Background worker with argument that indicates which function to be called
            backgroundWorker1.RunWorkerAsync(argument: ACTION_DIACRITIC);
        }

        //function that is called upon clicking button "odstranit prázdné řádky" 
        private void RemoveLines_Click(object sender, EventArgs e)
        {
            
            Actions.RemoveEmptyLines();
            EditFile.fileContent = Actions.FileContent;
            ActualizeLabels();
            EditFile.Save();
        }

        //function that is called upon clicking button "odstranit interpunkci" 
        private void RemoveSpaces_Click(object sender, EventArgs e)
        {
            DisableButtons();
            ActivateBar();
            progressBar.Value = 0;
            progressBar.Maximum = EditFile.fileContent.Length;

            backgroundWorker1.RunWorkerAsync(argument: ACTION_PUNCTUATION);
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            //switch that determines which function should be called
            switch(e.Argument)
            {
                //for ACTION_DIACRITIC call remove diacritics
                case ACTION_DIACRITIC:
                    Actions.RemoveDiacritics(progressBar, sender as BackgroundWorker);
                    break;

                //for ACTION_PUNCTUATION call remove punctuation
                case ACTION_PUNCTUATION:
                    Actions.RemovePunctuation(progressBar, sender as BackgroundWorker);
                    break;
            }
        }

        //function called every time background worker reports progress
        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //sets value of progress bar to reported value
            progressBar.Value = e.ProgressPercentage;
            //dividing by ten because we report each 0.1% and want to show percent in integers
            if (ActualPercent % 10 == 0)
                Percentage.Text = (ActualPercent/10).ToString() + "%";
            //adding 1 for each call
            ActualPercent++;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (ActionCanceled)
            {
                MessageBox.Show("Akce byla zrušena");
                DeactivateBar();
                EnableButtons();
            }
            else
            {
                EditFile.fileContent = Actions.FileContent;
                //actualising and saving, hiding progress bar
                ActualizeLabels();
                EditFile.Save();
                EnableButtons();
                DeactivateBar();
            }
        }

        private void cancelAction_Click(object sender, EventArgs e)
        {
            //checking if background worker supports cancelation
            if (backgroundWorker1.WorkerSupportsCancellation)
            {
                //calling cancel function
                backgroundWorker1.CancelAsync();
                //setting cancel flag to true
                ActionCanceled = true;
            }
        }

        //function that disables buttons during actions
        private void DisableButtons()
        {
            ActionCanceled = false;
            RemoveDiacritics.Enabled = false;
            RemoveLines.Enabled = false;
            CopyButton.Enabled = false;
            RemoveSpaces.Enabled = false;
            OpenButton.Enabled = false;
        }

        //function that enables buttons back after finished action
        private void EnableButtons()
        {
            RemoveDiacritics.Enabled = true;
            RemoveLines.Enabled = true;
            CopyButton.Enabled = true;
            RemoveSpaces.Enabled = true;
            OpenButton.Enabled = true;

        }

        //function that shows and enables cancel button, progress bar, progress percentage label
        //also resets values of progress bar and percentage
        private void ActivateBar()
        {
            progressBar.Value = 0;
            Percentage.Text = "";
            ActualPercent = 0;
            Percentage.Visible = true;
            progressBar.Visible = true;
            cancelAction.Visible = true;
            cancelAction.Enabled = true;
        }
        
        //Function that hides and deactivates button and progress bar
        private void DeactivateBar()
        {
            Percentage.Visible = false;
            progressBar.Visible = false;
            cancelAction.Visible = false;
            cancelAction.Enabled = false;
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
    }
}
