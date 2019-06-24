using System;
using System.Collections.Generic;
using System.Linq;

namespace StringCalculator2
{
    public class StringCalculator
    {
        public string SumStringNumbers(string stringNumber)
        {
            if (string.IsNullOrEmpty(stringNumber))
                return "0";

            if (stringNumber.EndsWith(","))
                return "Number expected but EOF found.";

            if(!stringNumber.ToCharArray().Any(x => x == ','))
                return stringNumber;

            double sumOfNumbers = default;
            var numbers = stringNumber.Split(',', '\n');
            var errorNumbers = new List<string>();

            foreach (var number in numbers)
            {
                if (Convert.ToDouble(number) < 0)
                    errorNumbers.Add(number.ToString());
                else
                    sumOfNumbers += Convert.ToDouble(number);
            }
            
            if(errorNumbers.Count != 0)
            {
                string negativeNumbers = default;

                foreach (var number in errorNumbers)
                    negativeNumbers += number + ", ";

                return $"Negative not allowed : {negativeNumbers.Substring(0, negativeNumbers.Length - 2)}";
            }

            return sumOfNumbers.ToString();
        }
    }
}
