using System;
using System.Linq;

namespace RangeKata
{
    public class Range
    {
        private string range;

        public Range(string range)
        {
            if (string.IsNullOrEmpty(range))
                throw new ArgumentNullException();
        }

        public bool IntegerRangeContains(string data)
        {
            if (string.IsNullOrEmpty(data))
                throw new ArgumentNullException();

            bool firstContains = range.Substring(0, 1) == "[";
            bool lastContains = range.Substring(0, 1) == "]";
            bool result = true;

            var items = data.Substring(1, data.Length - 1).Split(',');
            var rangeItems = range.Substring(1, range.Length - 1).ToList();

            rangeItems[0] = firstContains ? (char)(Convert.ToInt32(rangeItems[0]) + 1) : rangeItems[0];
            rangeItems[rangeItems.Count - 1] = lastContains
                ? (char)(Convert.ToInt32(rangeItems[rangeItems.Count - 1]) + 1) 
                : rangeItems[rangeItems.Count - 1];


            dataItems.ForEach(d =>
            {
                if (!rangeItems.Contains(d))
                    result = false;
            });

            return true;
        }
    }
}
