using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_Statistics
{
    internal class Actions
    {
        Hashtable Diacritics = new Hashtable() { { 'á', 'a' }, { 'é', 'e' }, { 'ě', 'e' }, { "í", "i" }, { "ž", "z" },
                                                { "ý", "y" }, { "ó", "o" }, { "ú", "u" }, { "ů", "u" }, { "š", "s" }, 
                                                { "ř", "r" }, { "ď", "d" }, { "ť", "t" }, { "ň", "n" }, { "č", "c" }};
        public string FileContent = string.Empty;

        public Actions(string FileContent)
        {
            this.FileContent = FileContent;
        }

        public void RemoveDiacritics()
        {
            foreach(DictionaryEntry de in Diacritics)
            {
                FileContent = FileContent.Replace(de.Key.ToString(), de.Value.ToString());
            }
        }
    }
}
