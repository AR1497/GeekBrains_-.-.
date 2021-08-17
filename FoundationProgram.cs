using System;
using System.Collections.Generic;
using System.IO;

namespace Ex3
{
    class FoundationProgram
    {
        public static void Print(int magistr_5, int magistr_6, int kol_1, int kol_2, int kol_3, int kol_4, int kol_5, int kol_6, List<Student> list, DateTime dt)
        {
            static int MyDelegat(Student st1, Student st2)
            {
                return String.Compare(st1.firstName, st2.firstName);
            }

            static int AgeF(Student st1, Student st2)
            {
                if (st1.age > st2.age)
                    return 1;
                if (st1.age < st2.age)
                    return -1;
                return 0;
            }

            static int CourceAge(Student st1, Student st2)
            {
                if (st1.course > st2.course)
                    return 1;
                if (st1.course < st2.course)
                    return -1;
                if (st1.age > st2.age)
                    return 1;
                if (st1.age < st2.age)
                    return -1;
                return 0;
            }
            
            StreamReader sr = new StreamReader("course.txt");
            while (!sr.EndOfStream)
            {
                try
                {
                    string[] s = sr.ReadLine().Split(' ');
                    list.Add(new Student(s[0], s[1], int.Parse(s[2]), int.Parse(s[3])));
                    if ((int.Parse(s[3]) > 17) && (int.Parse(s[3]) < 21))
                    {
                        switch (int.Parse(s[2]))
                        {
                            case 1:
                                kol_1++;
                                break;
                            case 2:
                                kol_2++;
                                break;
                            case 3:
                                kol_3++;
                                break;
                            case 4:
                                kol_4++;
                                break;
                            case 5:
                                kol_5++;
                                break;
                            case 6:
                                kol_6++;
                                break;
                        }
                    }

                    if (int.Parse(s[2]) == 5) magistr_5++;
                    else if (int.Parse(s[2]) == 6) magistr_6++;
                }
                catch
                {
                }
            }
            sr.Close();

            list.Sort(new Comparison<Student>(MyDelegat));
            Console.WriteLine("Всего студентов:" + list.Count);
            Console.WriteLine("Магистр 5 курс:{0}", magistr_5);
            Console.WriteLine("Магистр 6 курс:{0}", magistr_6);
            Console.WriteLine();
            Console.WriteLine($"Первый курс: {kol_1}");
            Console.WriteLine($"Второй курс: {kol_2}");
            Console.WriteLine($"Третий курс: {kol_3}");
            Console.WriteLine($"Четвёртый курс: {kol_4}");
            Console.WriteLine($"Пятый курс: {kol_5}");
            Console.WriteLine($"Шестой курс: {kol_6}");
            Console.WriteLine();

            list.Sort(new Comparison<Student>(AgeF));
            Console.WriteLine("\nОтсортируем студентов по возрасту: ");
            foreach (var v in list) Console.WriteLine($"{v.firstName} - возраст {v.age}");

            list.Sort(new Comparison<Student>(CourceAge));
            Console.WriteLine("\nОтсортируем студентов по курсу и возрасту: ");
            foreach (var v in list) Console.WriteLine($"{v.firstName} - курс {v.course}, возраст {v.age}");

            Console.WriteLine(DateTime.Now - dt);
            Console.ReadKey();
        }

        public static void Counting(out int magistr_5, out int magistr_6, out int kol_1, out int kol_2, out int kol_3, out int kol_4, out int kol_5, out int kol_6, out List<Student> list, out DateTime dt)
        {
            magistr_5 = 0;
            magistr_6 = 0;
            kol_1 = 0;
            kol_2 = 0;
            kol_3 = 0;
            kol_4 = 0;
            kol_5 = 0;
            kol_6 = 0;
            list = new List<Student>();
            dt = DateTime.Now;
        }
    }
}