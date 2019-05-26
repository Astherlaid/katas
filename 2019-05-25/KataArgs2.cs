using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace KataArgs2
{
    public class Kata
    {
        readonly string message;

        public Kata(string _message)
        {
            ValidateMessage(_message);

            message = _message;
        }

        public List<string> GetSplittedMessage => message.Split(" ").ToList();

        public Dictionary<string, object> ExtractData()
        {
            var result = new Dictionary<string, object>();
            int count = default;
            string previousItem = default;

            int helper = GetSplittedMessage.Count;

            foreach (var item in GetSplittedMessage)
            {
                count++;

                if (previousItem == null && item.Substring(0, 1) == "-")
                    previousItem = item;
                else if (previousItem != null && item.Substring(0, 1) != "-")
                {
                    result.Add(previousItem, item);
                    previousItem = default;
                }
                else
                {
                    result.Add(previousItem, false);
                    previousItem = default;
                }

                if(count == GetSplittedMessage.Count)
                {
                    if (previousItem != null)
                        result.Add(previousItem, item);
                    else
                        result.Add(item, false);
                }
            }

            return result;
        }

        private void ValidateMessage(string message)
        {
            if (string.IsNullOrEmpty(message))
                throw new ArgumentOutOfRangeException("Debe mandar información; no puede ser nulo ni vacio");
            if (message.Substring(0, 1) != "-")
                throw new ArgumentException("Debe iniciar con un comando");
        }
    }
}
