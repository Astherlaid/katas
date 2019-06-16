using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AnagramKata
{
    public class Anagram
    {
        public List<string> AnagramFile { get; private set; }

        public Anagram(string filePath)
        {
            if(File.Exists(filePath))
                AnagramFile = File.ReadAllLines(filePath).ToList();
            else
                throw new FileNotFoundException();
        }

        public string OrderedWord(string word) => new string(word.OrderBy(w => w).ToArray());

        public List<string> GetAnagrams()
        {
            List<string> result = null;

            foreach(var line in AnagramFile)
            {
                string anagramWords = line;

                foreach(var helper in AnagramFile)
                {
                    //if()
                }

                result.Add(line);
            }

            return result;
        }
    }
}
