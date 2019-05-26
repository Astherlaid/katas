using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ArgsKata
{
    public class Kata
    {
        readonly string data;

        public Kata(string _data) =>
            data = _data;

        public List<string> RetrieveArgs() => data.Split(" ").ToList();

        public Dictionary<string, object> ExtractArgs()
        {
            var helper = RetrieveArgs();
            var result = new Dictionary<string, object>();

            string previousValue = default;
            foreach(var item in helper)
            {
                if (previousValue == default && item.Contains("-"))
                    previousValue = item;
                else if (previousValue != default && item.Contains("-"))
                    result.Add(previousValue, false);
                else if (previousValue != default && !item.Contains("-"))
                    result.Add(previousValue, item);
                else
                    throw new ArgumentException("No puede digitar un argumento sin un flag");

            }

            return result;
        }
    }
}
