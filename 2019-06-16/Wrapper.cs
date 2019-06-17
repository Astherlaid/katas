using System;

namespace WordWrapKata2
{
    public class Wrapper
    {
        public string WrapText(string data, int columns)
        {
            if (string.IsNullOrEmpty(data))
                return null;
            if (columns < 1)
                return null;

            bool iterate = true;
            string helper = default;

            while (iterate)
            {
                if (data.Length <= columns)
                {
                    helper += data;
                    iterate = false;
                }
                else
                {
                    helper += data.Substring(0, columns) + "\n";
                    data = data.Substring(columns);
                }
            }

            return helper;
        }
    }
}
