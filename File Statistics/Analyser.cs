using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace File_Statistics
{
    internal class Analyser
    {
        public int words = 0;
        public int characters = 0;
        public int sentences = 0;
        public int lines = 0;
        public string FileContent = string.Empty;

        public Analyser(string FileContent)
        {
            this.FileContent = FileContent;
        }
        public void CountChars()
        {
            characters = FileContent.Length;
        }
        
        public void CountLines()
        {
            lines = FileContent.Split('\n').Length;
        }
    }


}
