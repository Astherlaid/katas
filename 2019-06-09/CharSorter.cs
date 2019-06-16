using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SortKata2
{
    public class CharSorter
    {
        public string Text { get; private set; }
        List<char> allowedChars;

        public CharSorter(string text)
        {
            if (string.IsNullOrEmpty(text))
                throw new ArgumentOutOfRangeException();
            else
            {
                Text = text;

                allowedChars = new List<char>()
                {
                    'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k',
                    'l', 'm', 'n', 'ñ', 'o', 'p', 'q', 'r', 's', 't', 'v', 'u', 'w', 'x', 'y', 'z'
                };

                ClearText();
            }
        }

        public void ClearText()
        {
            string helper = default;

            Text = Text.ToLower();

            foreach(var item in Text)
            {
                if (allowedChars.Contains(item))
                    helper += item;
            }

            Text = helper;
        }

        public string SortedText() => new string(Text.OrderBy(t => t).ToArray());
    }
}
