using System;
using System.Linq;
using System.Text;
using static System.Console;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Дан целочисленный массив из 20 элементов.
            //Элементы массива могут принимать целые значения от –10 000 до 10 000 включительно.
            //Заполнить случайными числами.
            //Написать программу, позволяющую найти и вывести количество пар элементов массива,
            //в которых только одно число делится на 3.
            //В данной задаче под парой подразумевается два подряд идущих элемента массива.
            //Например, для массива из пяти элементов: 6; 2; 9; –3; 6 ответ — 2.

            //Владимирова Анастасия

            int[] myArray;
            myArray = new int[21];

            Random r = new Random();

            Console.WriteLine("Набор чисел: ");
            for (int i = 0; i < 20; i++)
            {
                myArray[i] = r.Next(-10000, 10001);
                Console.Write($"{myArray[i]} "); 
            }
            Console.WriteLine();

            int kolvo = 0;
            for (int i = 0; i < 20; i++)
            {
                if (((myArray[i] % 3 == 0) && (myArray[i + 1] % 3 != 0))
                    || ((myArray[i] % 3 != 0) && (myArray[i + 1] % 3 == 0)))
                {
                    kolvo++;
                }
                else continue;
            }
            Console.WriteLine($"Количесвто: {kolvo} ");
        }
    }
}
