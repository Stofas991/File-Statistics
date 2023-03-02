using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


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

        public void RemoveEmptyLines()
        {
            var array = FileContent.Split("\n\r".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            FileContent = string.Join("\n", array);
        }

        public void RemovePunctuation(ProgressBar progressBar)
        {
            var NewFileContent = new StringBuilder();
            bool NextUpper = true;
            Console.WriteLine(FileContent);
            for (int i=0; i < FileContent.Length; i++)
            {
                char c = FileContent[i];

                if (!char.IsPunctuation(c))
                {
                    if (c == ' ')
                        NextUpper = true;       

                    else if (c == '\n' || c == '\t')
                    {
                        NextUpper = true;
                        NewFileContent.Append(c);
                    }

                    else
                    {
                        if (NextUpper)
                        { 
                            NewFileContent.Append(char.ToUpper(c, new System.Globalization.CultureInfo("cs-CZ", false)));
                            NextUpper = false;
                        }
                        else
                            NewFileContent.Append(char.ToLower(c, new System.Globalization.CultureInfo("cs-CZ", false)));

                    }
                }
                progressBar.PerformStep();
            }
            FileContent = NewFileContent.ToString();
        }
    }
}
