using System;
using System.Reflection;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.С помощью рефлексии выведите все свойства структуры DateTime.

            //Владимирова Анастасия.

            Type t = typeof(DateTime);
            foreach (var prop in t.GetProperties())
                Console.WriteLine(prop.Name);
            Console.ReadKey();
        }
    }
}
