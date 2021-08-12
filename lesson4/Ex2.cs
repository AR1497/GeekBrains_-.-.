using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Ex2
{
    partial class Program
    {
        static void Main(string[] args)
        {
            //2. Реализуйте задачу 1 в виде статического класса StaticClass;
            //а) Класс должен содержать статический метод, который принимает на вход массив и решает задачу 1;
            //б) Добавьте статический метод для считывания массива из текстового файла.
            //Метод должен возвращать массив целых чисел;
            //в)*Добавьте обработку ситуации отсутствия файла на диске.

            //Владимирова Анастасия

            StaticClass sc_1 = new StaticClass();
            sc_1.Print();
            sc_1.Save("db.json");
        }
    }

    class StaticClass
    {
        public int[] myArray;
        public int kol = 0;

        public void Add()
        {
            myArray = new int[20];

            Random r = new Random();
            Console.WriteLine("набор цифр: ");
            for (int i = 0; i < 19; i++)
            {
                myArray[i] = r.Next(-10000, 10001);
                Console.Write($"{myArray[i]} ");
            }
            Console.WriteLine();
        }

        

        public void Save(string path)
        {
            var json = JsonConvert.SerializeObject(myArray);
            File.WriteAllText(path, json); 
        }

        public int Kol()
        {
            Console.Write("Массив из файла: {0}", String.Join(", ", myArray));
            for (int i = 0; i < 19; i++)
            {
                if (((myArray[i] % 3 == 0) && (myArray[i + 1] % 3 != 0))
                    || ((myArray[i] % 3 != 0) && (myArray[i + 1] % 3 == 0)))
                {
                    kol++;
                }  
                else continue;
            }
            Console.WriteLine("Количество пар: " + kol);
            return kol;
        }

        public void Print()
        {
            Add();
            Kol();
        }
    }
}
        
