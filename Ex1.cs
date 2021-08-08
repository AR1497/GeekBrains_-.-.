using System;
using System.Numerics;


namespace Ex1
{
    struct Complex
    {
        public int a, b;    // private - не доступен ниоткуда. public - доступен.

        public Complex(int re, int im)
        {
            a = re;
            b = im;
        }

        public static Complex Sum(Complex x, Complex y)
        {
            return new Complex(re: x.a + y.a, im: x.b + y.b);
        }

        public static Complex operator +(Complex x, Complex y)
        {
            return new Complex(re: x.a + y.a, im: x.b + y.b);
        } //Бинарный минус - к двум операторам.

        public static Complex operator -(Complex x)
        {
            return new Complex(re: -x.a, im: -x.b);
        }//Унарный минус - к одному оператору.

        public override string ToString()
        {
            return b >= 0 ? $"{a} + {b}i" : $"{a} - {-b}i";
        }
    }

    class Complex1
    {
        public double im;
        public double re;
        private int z4;

        public Complex1 Minus(Complex1 z3)
        {
            Complex1 z4 = new Complex1();
            z4.im = z3.im - this.im;
            z4.re = z3.re - this.re;
            return z4;
        }

        public Complex1 Multi(Complex1 z3)
        {
            Complex1 z4 = new Complex1();
            z4.im = this.re * z3.im + this.im * z3.re;
            z4.re = this.re * z3.re - this.im * z3.im;
            return z4;
        }


        public string ToString_1()
        {
            return z4 > 0 ? $"{re} - {im}i" : $"{-re} + {-im}i"; //re + "-" + im + "i";// b >= 0 ? $"{a} + {b}i" : $"{a} - {-b}i";
        }

        public string ToString_2()
        {
            //return re + "+" + im + "i";
            return z4 >= 0 ? $"{re} + {im}i" : $"{-re} + {im}i";
        }
    }

    class Program
    {
        static void M(ref Complex z)
        {
            z.a = 2020;
        }

        static void Main(string[] args)
        {
            //а) Дописать структуру Complex, добавив метод вычитания комплексных чисел.Продемонстрировать работу структуры.
            //б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса.
            //в) Добавить диалог с использованием switch демонстрирующий работу класса.

            Complex1 complex_1 = new Complex1();
            complex_1.re = -1;
            complex_1.im = 1;

            Complex1 complex_2 = new Complex1();
            complex_2.re = 2;
            complex_2.im = -2;

            Console.WriteLine("Введите: 1 - вычитание; 2 - произведение");
            var choise = int.Parse(Console.ReadLine());

            switch (choise)
            {
                case 1:
                    Complex1 result_1 = complex_1.Minus(complex_2);
                    Console.WriteLine(result_1.ToString_1());
                    break;
                case 2:
                    Complex1 result_2 = complex_1.Multi(complex_2);
                    Console.WriteLine(result_2.ToString_2());
                    break;
                default:
                    Console.WriteLine("Не корректно введён выбор.");
                    break;
            }

            //////if (choise == 1)
            //////{
            //////    Complex1 result_1 = complex_1.Minus(complex_2);
            //////    Console.WriteLine(result_1.ToString_1());
            //////}
            //////else
            //////{
            //////    Complex1 result_2 = complex_1.Multi(complex_2);
            //////    Console.WriteLine(result_2.ToString_2());
            //////}

            //Complex1 complex_1 = new Complex1();
            //var z4;
            //complex_1.Minus(z4);
            //complex_1.ToString();

            //Complex1 result = complex1.Minus(complex2);
            //Console.WriteLine(result.ToString());



            Complex z1 = new Complex(re: 1, im: 33);
            Console.WriteLine(z1);
            M(ref z1);
            Console.WriteLine(z1);

            return;


            //Console.WriteLine(z1);
            Complex z2 = new Complex(re: 31, im: 13);
            Console.WriteLine(z2);

            //Complex z3 = z1.Sum(z1, z2);    //Эти две строчки не работают так как добавили static в: public Complex Sum(Complex x, Complex y)

            Complex z3 = Complex.Sum(z1, z2);    //Все что не static - это экземплярные члены, то что static - статические члены.
                                                 //z3 = Complex.Sum(z2, z1);

            z3 = z1 + z2;
            z3 = -z1;

            Console.WriteLine(z3);

            //Console.WriteLine(z1.Print());  //для: public string Print()
            //Console.WriteLine(z1);  //для: public override string ToString()

            //Choice c = (Choice)(new Random()).Next(0, 2);
            //switch (c)
            //{
            //    case Choice.Minus:
            //        Console.WriteLine("The color is red");
            //        break;
            //    case Choice.Multi:
            //        Console.WriteLine("The color is green");
            //        break;
            //    default:
            //        Console.WriteLine("The color is unknown.");
            //        break;

        }
    }
}
