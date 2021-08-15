using System;
using VisioForge.Shared.MediaFoundation.OPM;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Создать программу, которая будет проверять корректность ввода логина.
            //Корректным логином будет строка от 2 до 10 символов,
            //содержащая только буквы латинского алфавита или цифры, при этом цифра не может быть первой:
            //а) без использования регулярных выражений;
            //б) **с использованием регулярных выражений.

            //Владимирова Анастасия.

            Console.WriteLine("Введите логин: ");
            var login = Console.ReadLine();
            if (!(Char.IsDigit(login[0])))
            {
                bool log = Values(login);
                Test(login, log);
            }
            else Console.WriteLine("Неверный формат ввода логина");

        }

        private static void Test(string login, bool log)
        {
            if ((login.Length > 1) && (login.Length < 11) && log)
            {
                Console.WriteLine("Логин шикарен ^^");
            }
            else Console.WriteLine("Логин должен содержать от 2 до 10 символов(цифры и латиница)");
        }

        private static bool Values(string login)
        {
            

            bool log = true;
            for (int i = 0; i < login.Length; i++)
            {
                if (!(login[i] >= 'a' && login[i] <= 'z' || login[i] >= 'A' && login[i] <= 'Z' || (Char.IsDigit(login[i]))))
                {   
                    log = false;
                    Console.WriteLine("Введены недопустимые символы");
                    break;
                }
            }

            return log;
        }
    }
}
