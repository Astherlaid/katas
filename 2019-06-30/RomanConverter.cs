using System;
using System.Collections.Generic;
using System.Linq;

namespace RomanNumeralsKata2
{
    public class RomanConverter
    {
        Dictionary<int, string> romanNumerals;

        public RomanConverter()
        {
            romanNumerals = new Dictionary<int, string>()
            {
                { 1, "I" },
                { 4, "IV" },
                { 5, "V" },
                { 9, "IX" },
                { 10, "X" },
                { 40, "XL" },
                { 50, "L" },
                { 90, "XC" },
                { 100, "C" },
                { 400, "CD" },
                { 500, "D" },
                { 900, "CM" },
                { 1000, "M" }
            };
        }

        public string ConvertNumberToRomanNumeral(int decimalNumber)
        {
            if (decimalNumber <= 0)
                return "Zero";

            string transformedNumber = default;

            if (romanNumerals.TryGetValue(decimalNumber, out transformedNumber))
                return transformedNumber;

            while(decimalNumber != 0)
            {
                foreach(var romanItem in romanNumerals.OrderByDescending(numeral => numeral.Key))
                {
                    if(decimalNumber >= romanItem.Key)
                    {
                        var helper = decimalNumber / romanItem.Key;
                        decimalNumber %= romanItem.Key;

                        transformedNumber += string.Concat(Enumerable.Repeat(romanItem.Value, helper));
                    }
                }
            }

            return transformedNumber;
        }
    }
}
