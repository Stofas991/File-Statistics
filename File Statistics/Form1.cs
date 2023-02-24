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

namespace File_Statistics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            OpenButton.Click += new EventHandler(OpenButton_Click);
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            FileManager OpenFile = new FileManager();

        }
        
    }
}
