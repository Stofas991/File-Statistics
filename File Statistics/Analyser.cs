using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace File_Statistics
{
    internal class Analyser
    {
        public int words = 0;
        public int characters = 0;
        public int sentences = 0;
        public int lines = 0;

        public Analyser(string FileContent)
        {
        }
        public void Count(string FileContent)
        {
            characters = FileContent.Length;
            lines = FileContent.Split('\n').Length;
            words = FileContent.Split(new char[] {' ', '\n', '\t'}, StringSplitOptions.RemoveEmptyEntries).Length;
            sentences = FileContent.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries).Length - 1;

        }
    }


}
