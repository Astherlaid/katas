using System;

namespace KataArgs3
{
    class Program
    {
        static void Main(string[] args)
        {
            var argsKata = new Args("-w -l -a -123");

            Console.WriteLine("Comando : valor\n\n");

            foreach(var item in argsKata.ExtractCommandsWithValues())
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }
        }
    }
}
