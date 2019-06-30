using System;
using System.Collections.Generic;
using System.Linq;

namespace RomanNumeralsKata
{
    public class RomanConverter
    {
        Dictionary<int, string> romanNumbers;

        public RomanConverter()
        {
            romanNumbers = new Dictionary<int, string>()
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

        public string ConvertNumber(int number)
        {
            if (number == 0)
                return "Cero";

            string result = default;

            if (romanNumbers.TryGetValue(number, out result))
                return result;

            while (number != 0)
            {
                foreach (var item in romanNumbers.OrderByDescending(u => u.Key))
                {
                    if (number > item.Key)
                    {
                        var helper = (number / item.Key);
                        number = number % item.Key;

                        result += string.Concat(Enumerable.Repeat(item.Value, helper));
                    }
                }
            }

            return result;
        }
    }
}
