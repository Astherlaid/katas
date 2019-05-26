using System;

namespace KataArgs2
{
    class Program
    {
        static void Main(string[] args)
        {
            var kata = new Kata("-l prueba -g 2 -h 3 -n -y esta-camiseta");

            var data = kata.ExtractData();
        }
    }
}
