using System;
using System.Linq;

namespace StringCalculatorKata
{
    public class StringCalculator
    {
        public string SumNumbers(params string[] text)
        {
            string result = default;

            foreach(var numberCombination in text)
            {
                if (string.IsNullOrEmpty(numberCombination))
                {
                    result += "0, ";
                    continue;
                }

                if (numberCombination.Substring(numberCombination.Length - 1) == ",")
                {
                    result += "Number expected but EOF found., ";
                    continue;
                }

                if (!numberCombination.ToCharArray().Any(x => x == ','))
                {
                    result += $"{Convert.ToDouble(numberCombination)}, ";
                    continue;
                }

                var numbers = numberCombination.Split(',', '\n');

                double sumOfNumbers = default;

                foreach (var number in numbers)
                    sumOfNumbers += Convert.ToDouble(number);

                result += $"{sumOfNumbers}, ";
            }            

            return result.Substring(0,result.Length - 2);
        }
    }
}
