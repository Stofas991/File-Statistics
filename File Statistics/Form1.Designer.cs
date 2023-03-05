namespace File_Statistics
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.OpenButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CopyButton = new System.Windows.Forms.Button();
            this.NoFileIndicator = new System.Windows.Forms.Label();
            this.CopyIndicator = new System.Windows.Forms.Label();
            this.SentenceCount = new System.Windows.Forms.Label();
            this.WordCount = new System.Windows.Forms.Label();
            this.CharCount = new System.Windows.Forms.Label();
            this.LineCount = new System.Windows.Forms.Label();
            this.CharLabel = new System.Windows.Forms.Label();
            this.WordLabel = new System.Windows.Forms.Label();
            this.LineLabel = new System.Windows.Forms.Label();
            this.SentenceLabel = new System.Windows.Forms.Label();
            this.RemoveDiacritics = new System.Windows.Forms.Button();
            this.RemoveLines = new System.Windows.Forms.Button();
            this.RemoveSpaces = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.cancelAction = new System.Windows.Forms.Button();
            this.Percentage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OpenButton
            // 
            this.OpenButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpenButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.OpenButton.Location = new System.Drawing.Point(134, 14);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(75, 23);
            this.OpenButton.TabIndex = 2;
            this.OpenButton.Text = "Otevřít...";
            this.OpenButton.UseVisualStyleBackColor = true;
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(29, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Vyberte soubor:";
            // 
            // CopyButton
            // 
            this.CopyButton.BackColor = System.Drawing.SystemColors.Control;
            this.CopyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CopyButton.Enabled = false;
            this.CopyButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CopyButton.Location = new System.Drawing.Point(1190, 350);
            this.CopyButton.Name = "CopyButton";
            this.CopyButton.Size = new System.Drawing.Size(157, 61);
            this.CopyButton.TabIndex = 4;
            this.CopyButton.Text = "Kopírovat";
            this.CopyButton.UseVisualStyleBackColor = false;
            this.CopyButton.Click += new System.EventHandler(this.CopyButton_Click);
            // 
            // NoFileIndicator
            // 
            this.NoFileIndicator.AutoSize = true;
            this.NoFileIndicator.BackColor = System.Drawing.SystemColors.Control;
            this.NoFileIndicator.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NoFileIndicator.ForeColor = System.Drawing.Color.Red;
            this.NoFileIndicator.Location = new System.Drawing.Point(215, 15);
            this.NoFileIndicator.Name = "NoFileIndicator";
            this.NoFileIndicator.Size = new System.Drawing.Size(228, 22);
            this.NoFileIndicator.TabIndex = 6;
            this.NoFileIndicator.Text = "Není vybrán žádný soubor";
            // 
            // CopyIndicator
            // 
            this.CopyIndicator.AutoSize = true;
            this.CopyIndicator.Font = new System.Drawing.Font("Arial", 14.25F);
            this.CopyIndicator.Location = new System.Drawing.Point(260, 205);
            this.CopyIndicator.Name = "CopyIndicator";
            this.CopyIndicator.Size = new System.Drawing.Size(0, 22);
            this.CopyIndicator.TabIndex = 7;
            // 
            // SentenceCount
            // 
            this.SentenceCount.AutoSize = true;
            this.SentenceCount.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SentenceCount.Location = new System.Drawing.Point(200, 566);
            this.SentenceCount.Name = "SentenceCount";
            this.SentenceCount.Size = new System.Drawing.Size(73, 17);
            this.SentenceCount.TabIndex = 8;
            this.SentenceCount.Text = "Počet vět:";
            // 
            // WordCount
            // 
            this.WordCount.AutoSize = true;
            this.WordCount.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.WordCount.Location = new System.Drawing.Point(478, 566);
            this.WordCount.Name = "WordCount";
            this.WordCount.Size = new System.Drawing.Size(80, 17);
            this.WordCount.TabIndex = 9;
            this.WordCount.Text = "Počet slov:";
            // 
            // CharCount
            // 
            this.CharCount.AutoSize = true;
            this.CharCount.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CharCount.Location = new System.Drawing.Point(760, 566);
            this.CharCount.Name = "CharCount";
            this.CharCount.Size = new System.Drawing.Size(93, 17);
            this.CharCount.TabIndex = 10;
            this.CharCount.Text = "Počet znaků:";
            // 
            // LineCount
            // 
            this.LineCount.AutoSize = true;
            this.LineCount.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LineCount.Location = new System.Drawing.Point(1085, 566);
            this.LineCount.Name = "LineCount";
            this.LineCount.Size = new System.Drawing.Size(90, 17);
            this.LineCount.TabIndex = 11;
            this.LineCount.Text = "Počet řádků:";
            // 
            // CharLabel
            // 
            this.CharLabel.AutoSize = true;
            this.CharLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CharLabel.Location = new System.Drawing.Point(859, 566);
            this.CharLabel.Name = "CharLabel";
            this.CharLabel.Size = new System.Drawing.Size(16, 17);
            this.CharLabel.TabIndex = 12;
            this.CharLabel.Text = "0";
            // 
            // WordLabel
            // 
            this.WordLabel.AutoSize = true;
            this.WordLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.WordLabel.Location = new System.Drawing.Point(564, 566);
            this.WordLabel.Name = "WordLabel";
            this.WordLabel.Size = new System.Drawing.Size(16, 17);
            this.WordLabel.TabIndex = 13;
            this.WordLabel.Text = "0";
            // 
            // LineLabel
            // 
            this.LineLabel.AutoSize = true;
            this.LineLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LineLabel.Location = new System.Drawing.Point(1181, 566);
            this.LineLabel.Name = "LineLabel";
            this.LineLabel.Size = new System.Drawing.Size(16, 17);
            this.LineLabel.TabIndex = 14;
            this.LineLabel.Text = "0";
            // 
            // SentenceLabel
            // 
            this.SentenceLabel.AutoSize = true;
            this.SentenceLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SentenceLabel.Location = new System.Drawing.Point(279, 566);
            this.SentenceLabel.Name = "SentenceLabel";
            this.SentenceLabel.Size = new System.Drawing.Size(16, 17);
            this.SentenceLabel.TabIndex = 15;
            this.SentenceLabel.Text = "0";
            // 
            // RemoveDiacritics
            // 
            this.RemoveDiacritics.BackColor = System.Drawing.SystemColors.Control;
            this.RemoveDiacritics.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RemoveDiacritics.Enabled = false;
            this.RemoveDiacritics.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RemoveDiacritics.Location = new System.Drawing.Point(1190, 40);
            this.RemoveDiacritics.Name = "RemoveDiacritics";
            this.RemoveDiacritics.Size = new System.Drawing.Size(157, 61);
            this.RemoveDiacritics.TabIndex = 16;
            this.RemoveDiacritics.Text = "Odstranit diakritiku";
            this.RemoveDiacritics.UseVisualStyleBackColor = false;
            this.RemoveDiacritics.Click += new System.EventHandler(this.RemoveDiacritics_Click);
            // 
            // RemoveLines
            // 
            this.RemoveLines.BackColor = System.Drawing.SystemColors.Control;
            this.RemoveLines.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RemoveLines.Enabled = false;
            this.RemoveLines.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RemoveLines.Location = new System.Drawing.Point(1190, 137);
            this.RemoveLines.Name = "RemoveLines";
            this.RemoveLines.Size = new System.Drawing.Size(157, 61);
            this.RemoveLines.TabIndex = 17;
            this.RemoveLines.Text = "Odstranit prázdné řádky";
            this.RemoveLines.UseVisualStyleBackColor = false;
            this.RemoveLines.Click += new System.EventHandler(this.RemoveLines_Click);
            // 
            // RemoveSpaces
            // 
            this.RemoveSpaces.BackColor = System.Drawing.SystemColors.Control;
            this.RemoveSpaces.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RemoveSpaces.Enabled = false;
            this.RemoveSpaces.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RemoveSpaces.Location = new System.Drawing.Point(1190, 246);
            this.RemoveSpaces.Name = "RemoveSpaces";
            this.RemoveSpaces.Size = new System.Drawing.Size(157, 61);
            this.RemoveSpaces.TabIndex = 18;
            this.RemoveSpaces.Text = "Odstranit mezery a interpunkci";
            this.RemoveSpaces.UseVisualStyleBackColor = false;
            this.RemoveSpaces.Click += new System.EventHandler(this.RemoveSpaces_Click);
            // 
            // progressBar
            // 
            this.progressBar.Enabled = false;
            this.progressBar.Location = new System.Drawing.Point(326, 487);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(787, 28);
            this.progressBar.Step = 1;
            this.progressBar.TabIndex = 19;
            this.progressBar.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial", 9.75F);
            this.textBox1.Location = new System.Drawing.Point(326, 40);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(787, 441);
            this.textBox1.TabIndex = 20;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // cancelAction
            // 
            this.cancelAction.BackColor = System.Drawing.SystemColors.Control;
            this.cancelAction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelAction.Enabled = false;
            this.cancelAction.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cancelAction.Location = new System.Drawing.Point(1119, 487);
            this.cancelAction.Name = "cancelAction";
            this.cancelAction.Size = new System.Drawing.Size(74, 28);
            this.cancelAction.TabIndex = 21;
            this.cancelAction.Text = "Zrušit";
            this.cancelAction.UseVisualStyleBackColor = false;
            this.cancelAction.Visible = false;
            this.cancelAction.Click += new System.EventHandler(this.cancelAction_Click);
            // 
            // Percentage
            // 
            this.Percentage.AutoSize = true;
            this.Percentage.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Percentage.Location = new System.Drawing.Point(680, 518);
            this.Percentage.Name = "Percentage";
            this.Percentage.Size = new System.Drawing.Size(29, 17);
            this.Percentage.TabIndex = 22;
            this.Percentage.Text = "0%";
            this.Percentage.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1417, 612);
            this.Controls.Add(this.Percentage);
            this.Controls.Add(this.cancelAction);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.RemoveSpaces);
            this.Controls.Add(this.RemoveLines);
            this.Controls.Add(this.RemoveDiacritics);
            this.Controls.Add(this.SentenceLabel);
            this.Controls.Add(this.LineLabel);
            this.Controls.Add(this.WordLabel);
            this.Controls.Add(this.CharLabel);
            this.Controls.Add(this.LineCount);
            this.Controls.Add(this.CharCount);
            this.Controls.Add(this.WordCount);
            this.Controls.Add(this.SentenceCount);
            this.Controls.Add(this.CopyIndicator);
            this.Controls.Add(this.NoFileIndicator);
            this.Controls.Add(this.CopyButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OpenButton);
            this.Name = "Form1";
            this.Text = "Analyser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CopyButton;
        private System.Windows.Forms.Label NoFileIndicator;
        private System.Windows.Forms.Label CopyIndicator;
        private System.Windows.Forms.Label SentenceCount;
        private System.Windows.Forms.Label WordCount;
        private System.Windows.Forms.Label CharCount;
        private System.Windows.Forms.Label LineCount;
        private System.Windows.Forms.Label CharLabel;
        private System.Windows.Forms.Label WordLabel;
        private System.Windows.Forms.Label LineLabel;
        private System.Windows.Forms.Label SentenceLabel;
        private System.Windows.Forms.Button RemoveDiacritics;
        private System.Windows.Forms.Button RemoveLines;
        private System.Windows.Forms.Button RemoveSpaces;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.TextBox textBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button cancelAction;
        private System.Windows.Forms.Label Percentage;
    }
}

