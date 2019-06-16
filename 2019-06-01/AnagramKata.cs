using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AnagramKata2
{
    public class AnagramKata
    {
        List<string> data;

        public AnagramKata(string path)
        {
            if (File.Exists(path))
                data = File.ReadAllLines(path).ToList();
            else
                throw new FileNotFoundException();
        }

        public string ReorderWord(string data) => new string(data.OrderBy(w => w).ToArray());
        public bool VerifyAnagram(string first, string second)
        {
            first = ReorderWord(first);
            second = ReorderWord(second);

            return first == second;
        }

        public List<string> GetAnagramList()
        {
            var result = new List<string>();
            var checkedWords = new List<string>();

            foreach(var word in data)
            {
                if (!checkedWords.Contains(word))
                {
                string anagrams = word + ", ";

                foreach (var item in data)
                {

                    if(word != item && !checkedWords.Contains(item))
                        if(VerifyAnagram(word, item))
                        {
                            anagrams += $"{item}, ";
                            checkedWords.Add(item);
                        }
                }

                if(!string.IsNullOrEmpty(anagrams))
                    result.Add(anagrams.Substring(0, anagrams.LastIndexOf(", ")));

                }
            }

            return result;
        }
    }
}
