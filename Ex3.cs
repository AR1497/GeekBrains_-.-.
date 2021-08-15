using System;
using System.Linq;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            //3. * Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой.
            //Например: badc являются перестановкой abcd.

            //Владимирова Анастасия.

            Console.WriteLine("Введите первую строку(через пробел): ");
            string str_1 = Convert.ToString(Console.ReadLine());
            Console.WriteLine("введите вторую строку(через пробел): ");
            string str_2 = Convert.ToString(Console.ReadLine());
            Rearrangement(str_1, str_2);
        }

        private static void Rearrangement(string str_1, string str_2)
        {
            Console.WriteLine(str_1.Select(Char.ToLower).OrderBy(x => x).SequenceEqual(str_2.Select(Char.ToLower).OrderBy(x => x)));
        }
    }
}
