using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            //а) Дописать класс для работы с одномерным массивом.
            //Реализовать конструктор, создающий массив определенного размера и заполняющий массив числами от начального значения с заданным шагом.
            //Создать свойство Sum, которое возвращает сумму элементов массива,
            //метод Inverse, возвращающий новый массив с измененными знаками у всех элементов массива(старый массив, остается без изменений),
            //метод Multi, умножающий каждый элемент массива на определённое число
            //свойство MaxCount, возвращающее количество максимальных элементов.
            //б)**Создать библиотеку содержащую класс для работы с массивом.Продемонстрировать работу библиотеки
            //в) ***Подсчитать частоту вхождения каждого элемента в массив(коллекция Dictionary< int,int>)

            //Владимирова Анастасия

            Console.WriteLine("Введите количество элементов в массиве: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите начальный элемнт: ");
            int value = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите шаг: ");
            int step = int.Parse(Console.ReadLine());

            int sum = 0;

            Massive mas = new Massive(n, value, step, sum);
            Massive tmas = new Massive(n, value, step, sum);
            Console.WriteLine("Массив: ");
            mas.AddMassive();
            mas.Print();
            Console.WriteLine("Сумма: ");
            mas.Sum = 2;
            mas.Inverse();
            mas.Multi();

            Massive nmas = new Massive(n, value, step, sum);
            nmas.MaxCount = 0;
        }
    }

    class Massive
    {
        public int[] myMas;
        public int n;
        public int value; 
        public int step;
        public int sum;
        public int[] twoMas;

        public Massive(int n, int value, int step, int sum)
        {
            this.n = n;
            this.value = value;
            this.step = step;
            this.sum = sum;
        }

        public void AddMassive()
        {
            myMas = new int[n];
            myMas[0] = value;
            for (int i = 1; i < n; i++)
            {
                myMas[i] = value + step;
                value += step;
            }
        }

        public int Sum
        {
            get
            {
                return kol;
            }
            set 
            {
                for (int i = 0; i < n; i++)
                {
                    kol++;
                }
                Console.WriteLine(sum);
            }
        }

        public void Inverse()
        {
            twoMas = new int[n];
            for (int i = 0; i < n; i++)
            {
                twoMas[i] = -myMas[i];
            }

            Console.WriteLine("Новый массив: ");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(twoMas[i]);
            }
        }

        public void Multi()
        {
            Console.WriteLine("Введите число, на которое хотите умножить каждый элемент массива: ");
            int count = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                myMas[i] = myMas[i] * count;
                Console.Write($"{myMas[i]} ");
            }  
        }

        public int[] myArray;
        public int kol = 0;

        public int max;
        public int kolv;
        public int MaxCount
        {
            get
            {
                return max;
                return kolv;
            }
            set
            {
                Console.WriteLine();
                myArray = new int[10];

                Random r = new Random();
                Console.WriteLine("Новый массив: ");
                for (int i = 0; i < 10; i++)
                {
                    myArray[i] = r.Next(-3, 3);
                    Console.Write($"{myArray[i]} ");
                }
                Console.WriteLine();

                for (int i = 0; i < 9; i++)
                {
                    if (myArray[i] > myArray[i + 1])
                    {
                        max = myArray[i];
                    }
                    else
                    {
                        max = myArray[i + 1];
                    }
                }
                Console.WriteLine("Максимальное число в новом массиве: ");
                Console.WriteLine(MaxCount);

                for (int i = 0; i < 10; i++)
                {
                    if (myArray[i] == max)
                    {
                        kolv++;
                    }
                }
                Console.WriteLine("Количество раз, которое число повторяется в новом массиве: ");
                Console.WriteLine(kolv);
            }
        }

        public void Print()
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(myMas[i]);
            }
        }
    }

}
