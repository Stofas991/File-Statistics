﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace File_Statistics
{
    public class FileManager
    {
        public int Size;
        public string Name;
        public string fileContent = string.Empty;
        public string filePath = string.Empty;
        public string savePath = string.Empty;

        public FileManager()
        {

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                //filters and initial directories
                openFileDialog.InitialDirectory = @"../"+Directory.GetCurrentDirectory();
                openFileDialog.Filter = "txt files (*.txt)|*.txt";    
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;
                    Name = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream, Encoding.Default))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                }
            }
        }

        //Function to copy opened file into directory selected
        public void Save()
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.InitialDirectory = Name;
                saveFileDialog.Filter = "txt files (*.txt)|*.txt";
                saveFileDialog.FileName = Name + " - Copy";
                saveFileDialog.Title = "Save an text file";
                saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog.FileName, fileContent);
                    savePath = saveFileDialog.FileName;
                }
            }
        }
    }

}
