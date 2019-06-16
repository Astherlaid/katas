using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AnagramKata3
{
    public class AnagramKata
    {
        List<string> fileData;

        public AnagramKata(string path)
        {
            if (File.Exists(path))
                fileData = File.ReadAllLines(path).ToList();
            else
                throw new FileNotFoundException();
        }

        public string ReorderWord(string word) => new string(word.OrderBy(w => w).ToArray());

        
    }
}
