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
            this.label2 = new System.Windows.Forms.Label();
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
            this.SuspendLayout();
            // 
            // OpenButton
            // 
            this.OpenButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpenButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.OpenButton.Location = new System.Drawing.Point(167, 14);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(75, 23);
            this.OpenButton.TabIndex = 2;
            this.OpenButton.Text = "Open...";
            this.OpenButton.UseVisualStyleBackColor = true;
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(29, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select file to analyze:";
            // 
            // CopyButton
            // 
            this.CopyButton.BackColor = System.Drawing.SystemColors.Control;
            this.CopyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CopyButton.Enabled = false;
            this.CopyButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CopyButton.Location = new System.Drawing.Point(167, 205);
            this.CopyButton.Name = "CopyButton";
            this.CopyButton.Size = new System.Drawing.Size(75, 23);
            this.CopyButton.TabIndex = 4;
            this.CopyButton.Text = "Save as...";
            this.CopyButton.UseVisualStyleBackColor = false;
            this.CopyButton.Click += new System.EventHandler(this.CopyButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(29, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Copy file:";
            // 
            // NoFileIndicator
            // 
            this.NoFileIndicator.AutoSize = true;
            this.NoFileIndicator.BackColor = System.Drawing.SystemColors.Control;
            this.NoFileIndicator.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NoFileIndicator.ForeColor = System.Drawing.Color.Red;
            this.NoFileIndicator.Location = new System.Drawing.Point(260, 15);
            this.NoFileIndicator.Name = "NoFileIndicator";
            this.NoFileIndicator.Size = new System.Drawing.Size(142, 22);
            this.NoFileIndicator.TabIndex = 6;
            this.NoFileIndicator.Text = "No file selected";
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
            this.SentenceCount.Font = new System.Drawing.Font("Arial", 9.75F);
            this.SentenceCount.Location = new System.Drawing.Point(29, 62);
            this.SentenceCount.Name = "SentenceCount";
            this.SentenceCount.Size = new System.Drawing.Size(138, 16);
            this.SentenceCount.TabIndex = 8;
            this.SentenceCount.Text = "Number of sentences: ";
            // 
            // WordCount
            // 
            this.WordCount.AutoSize = true;
            this.WordCount.Font = new System.Drawing.Font("Arial", 9.75F);
            this.WordCount.Location = new System.Drawing.Point(29, 94);
            this.WordCount.Name = "WordCount";
            this.WordCount.Size = new System.Drawing.Size(108, 16);
            this.WordCount.TabIndex = 9;
            this.WordCount.Text = "Number of words:";
            // 
            // CharCount
            // 
            this.CharCount.AutoSize = true;
            this.CharCount.Font = new System.Drawing.Font("Arial", 9.75F);
            this.CharCount.Location = new System.Drawing.Point(29, 127);
            this.CharCount.Name = "CharCount";
            this.CharCount.Size = new System.Drawing.Size(135, 16);
            this.CharCount.TabIndex = 10;
            this.CharCount.Text = "Number of characters:";
            // 
            // LineCount
            // 
            this.LineCount.AutoSize = true;
            this.LineCount.Font = new System.Drawing.Font("Arial", 9.75F);
            this.LineCount.Location = new System.Drawing.Point(29, 160);
            this.LineCount.Name = "LineCount";
            this.LineCount.Size = new System.Drawing.Size(97, 16);
            this.LineCount.TabIndex = 11;
            this.LineCount.Text = "Number of lines";
            // 
            // CharLabel
            // 
            this.CharLabel.AutoSize = true;
            this.CharLabel.Font = new System.Drawing.Font("Arial", 9.75F);
            this.CharLabel.Location = new System.Drawing.Point(183, 127);
            this.CharLabel.Name = "CharLabel";
            this.CharLabel.Size = new System.Drawing.Size(14, 16);
            this.CharLabel.TabIndex = 12;
            this.CharLabel.Text = "0";
            this.CharLabel.Click += new System.EventHandler(this.CharLabel_Click);
            // 
            // WordLabel
            // 
            this.WordLabel.AutoSize = true;
            this.WordLabel.Font = new System.Drawing.Font("Arial", 9.75F);
            this.WordLabel.Location = new System.Drawing.Point(183, 94);
            this.WordLabel.Name = "WordLabel";
            this.WordLabel.Size = new System.Drawing.Size(14, 16);
            this.WordLabel.TabIndex = 13;
            this.WordLabel.Text = "0";
            // 
            // LineLabel
            // 
            this.LineLabel.AutoSize = true;
            this.LineLabel.Font = new System.Drawing.Font("Arial", 9.75F);
            this.LineLabel.Location = new System.Drawing.Point(183, 160);
            this.LineLabel.Name = "LineLabel";
            this.LineLabel.Size = new System.Drawing.Size(14, 16);
            this.LineLabel.TabIndex = 14;
            this.LineLabel.Text = "0";
            // 
            // SentenceLabel
            // 
            this.SentenceLabel.AutoSize = true;
            this.SentenceLabel.Font = new System.Drawing.Font("Arial", 9.75F);
            this.SentenceLabel.Location = new System.Drawing.Point(183, 62);
            this.SentenceLabel.Name = "SentenceLabel";
            this.SentenceLabel.Size = new System.Drawing.Size(14, 16);
            this.SentenceLabel.TabIndex = 15;
            this.SentenceLabel.Text = "0";
            // 
            // RemoveDiacritics
            // 
            this.RemoveDiacritics.BackColor = System.Drawing.SystemColors.Control;
            this.RemoveDiacritics.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RemoveDiacritics.Enabled = false;
            this.RemoveDiacritics.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RemoveDiacritics.Location = new System.Drawing.Point(264, 205);
            this.RemoveDiacritics.Name = "RemoveDiacritics";
            this.RemoveDiacritics.Size = new System.Drawing.Size(138, 23);
            this.RemoveDiacritics.TabIndex = 16;
            this.RemoveDiacritics.Text = "Remove diacritics";
            this.RemoveDiacritics.UseVisualStyleBackColor = false;
            this.RemoveDiacritics.Click += new System.EventHandler(this.RemoveDiacritics_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(551, 279);
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
            this.Controls.Add(this.label2);
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
        private System.Windows.Forms.Label label2;
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
    }
}

