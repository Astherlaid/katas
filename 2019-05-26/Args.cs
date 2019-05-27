using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KataArgs3
{
    public class Args
    {
        readonly string data;

        public Args(string message)
        {
            ValidateMessage(message);

            data = message.Trim();
        }

        public List<string> GetData => data.Split(" ").ToList();

        public Dictionary<string, object> ExtractCommandsWithValues()
        {
            var result = new Dictionary<string, object>();
            string previousItem = default;
            var splitedData = GetData;

            foreach (var item in splitedData)
            {
                var isNumber = int.TryParse(item, out int number);

                if (previousItem != null && item.Substring(0, 1) == "-")
                {
                    if(isNumber == true)
                        result.Add(previousItem, item);
                    else
                        result.Add(previousItem, false);

                    previousItem = null;
                }

                if (previousItem == null && item.Substring(0, 1) == "-")
                    previousItem = item;
                else if (previousItem != null && item.Substring(0, 1) != "-")
                {
                    result.Add(previousItem, item);

                    previousItem = default;
                }
                else
                {
                    result.Add(item, false);

                    previousItem = null;
                }

                if (GetData.IndexOf(item) == GetData.Count - 1 && item.Substring(0, 1) == "-1")
                    result.Add(item, false);
            }

            return result;
        }

        private void ValidateMessage(string message)
        {
            if (string.IsNullOrEmpty(message))
                throw new ArgumentOutOfRangeException("No se admiten valores nulos o vacíos");
            if (message.Length < 2)
                throw new ArgumentOutOfRangeException("Debe mandar información válida");
        }
    }
}
