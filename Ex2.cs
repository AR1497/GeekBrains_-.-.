using System;

namespace Ex2
{
    class Summa
    {
        public int sum = 0;
        
        public void Print()
        {
            Console.WriteLine("Введите числа: ");
        }
    }

    class Program
    {
        struct Analysis
        {
            private static int x;

            public static int An(int x, int sum)
            {
                while (x != 0)
                {
                    //bool input = false;
                    //input = int.TryParse(Console.ReadLine(), out x);

                    if ((x > 0) && (x % 2 == 1))
                    {
                        sum = sum + x;
                    }
                    
                    bool input = false;
                    input = int.TryParse(Console.ReadLine(), out x);
                }
                
                Console.WriteLine(sum);
                return sum;
            }


            static void Main(string[] args)
            {
                //а) С клавиатуры вводятся числа, пока не будет введён 0(каждое число в новой строке).
                //Требуется подсчитать сумму всех нечётных положительных чисел.
                //Сами числа и сумму вывести на экран, используя tryParse.

                Summa summma1 = new Summa();
                summma1.Print();
                int x = int.Parse(Console.ReadLine());
                if (x != 0)
                {
                    An(x, 0);
                }
            }
        }
    }
}
