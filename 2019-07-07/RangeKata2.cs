using System;
using System.Collections.Generic;
using System.Linq;

namespace RangeKata2
{
    public class Range
    {
        public bool IsValidRange(string range)
        {
            if (string.IsNullOrEmpty(range))
                return false;

            range = range.Substring(1, range.Length - 2);
            var splitedData = range.Split(',').ToList();

            return splitedData.Count() > 1;
        }

        public RangeType CheckRangeType(string range)
        {
            char firstSign = range.First();
            char lastSign = range.Last();

            if (firstSign == '[' && lastSign == ']')
                return RangeType.Closed;
            else if (firstSign == '(' && lastSign == ']')
                return RangeType.HalfClosed;
            else if (firstSign == '[' && lastSign == ')')
                return RangeType.HalfOpened;
            else
                return RangeType.Opened;
        }

        public List<short> GetFormattedRange(string range)
        {
            if (!IsValidRange(range))
                return null ;

            var type = CheckRangeType(range);

            var formatedRange = new List<short>();

            range = range.Substring(1, range.Length - 2);
            range.Split(',').ToList().ForEach(r =>
            {
                formatedRange.Add(Convert.ToInt16(r));
            });

            switch (type)
            {
                case RangeType.Closed:

                    break;
                case RangeType.HalfClosed:
                    break;
                case RangeType.HalfOpened:
                    break;
                case RangeType.Opened:
                    break;
            }

            return formatedRange;
        }
    }

    public enum RangeType
    {
        Closed,
        Opened,
        HalfClosed,
        HalfOpened
    }
}
