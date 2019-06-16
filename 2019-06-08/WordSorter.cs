using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SortKata
{
    public class WordSorter
    {
        string text;
        List<char> allowedChars;

        public string GetText => text;

        public WordSorter(string text)
        {
            if (string.IsNullOrEmpty(text))
                throw new ArgumentOutOfRangeException();
            else
                this.text = text;

            allowedChars = new List<char>()
            {
                'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 
                'ñ', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'
            };

            ClearText();
        }

        public string DeleteSpaces() => text.Replace(" ", string.Empty);

        public string ReorderChars() => new string(text.OrderBy(t => t).ToArray());

        public void ClearText()
        {
            string result = default;

            text = text.ToLower();

            foreach(var letter in text)
                if (allowedChars.Contains(letter))
                    result += letter;

            text = result;
        }
    }
}
