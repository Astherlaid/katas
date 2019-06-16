using System;
using System.Collections.Generic;
using System.Text;

namespace WordWrapKata
{
    public class Wrapper
    {
        public Wrapper()
        {
        }

        public static string WrapText(string text, int columns)
        {
            string result = default;
            int helper = text.Length;

            if (string.IsNullOrEmpty(text))
                return null;

            bool cont = true;
            while (cont)
            {
                if (helper < columns)
                {
                    result += text;
                    cont = false;
                }
                else
                {
                    result += text.Substring(0, columns) + "\n";
                    text = text.Substring(columns);
                    helper = text.Length;
                }
            }

            return result;
        }
    }
}
