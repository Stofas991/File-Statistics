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
        Dictionary<char, char> Diacritics = new Dictionary<char, char>() { { 'á', 'a' }, { 'é', 'e' }, { 'ě', 'e' }, { 'í', 'i' }, { 'ž', 'z' },
                                                { 'ý', 'y' }, { 'ó', 'o' }, { 'ú', 'u' }, { 'ů', 'u' }, { 'š', 's' }, 
                                                { 'ř', 'r' }, { 'ď', 'd' }, { 'ť', 't' }, { 'ň', 'n' }, { 'č', 'c' }};
        public string FileContent = string.Empty;

        public Actions(string FileContent)
        {
            this.FileContent = FileContent;
        }

        public void RemoveDiacritics()
        {
            StringBuilder NewFileContent = new StringBuilder(FileContent);
            for (int i = 0; i < FileContent.Length; i++)
            {
                char c = FileContent[i];
                if (Diacritics.ContainsKey(c))
                {

                    NewFileContent[i] = Diacritics[c];
                }
                else if (Diacritics.ContainsKey(Char.ToLower(c)))
                {
                    NewFileContent[i] = Char.ToUpper(Diacritics[Char.ToLower(c)]);
                }
            }    
            FileContent = NewFileContent.ToString();
        }


    }
}
