using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            //2.Разработать статический класс Message, содержащий следующие статические методы для обработки текста:
            //а) Вывести только те слова сообщения, которые содержат не более n букв.
            //б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
            //в) Найти самое длинное слово сообщения.
            //г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
            //д) ***Создать метод, который производит частотный анализ текста.
            //В качестве параметра в него передается массив слов и текст,
            //в качестве результата метод возвращает сколько раз каждое из слов массива входит в этот текст.
            //Здесь требуется использовать класс Dictionary.

            //Владимирова Анастасия.

            string text = "Новая модель организационной деятельности напрямую зависит от экономической целесообразности принимаемых решений. \n Сложно сказать, почему представители современных социальных резервов ассоциативно распределены по отраслям. \n Принимая во внимание показатели успешности, базовый вектор развития говорит о возможностях новых предложений. \n С учётом сложившейся международной обстановки, перспективное планирование говорит о возможностях переосмысления внешнеэкономических политик. \n В рамках спецификации современных стандартов, интерактивные прототипы могут быть представлены в исключительно положительном свете. \n А также сторонники тоталитаризма в науке, которые представляют собой яркий пример континентально-европейского типа политической культуры, \n будут заблокированы в рамках своих собственных рациональных ограничений. Для современного мира сплочённость команды профессионалов играет определяющее \n значение для модели развития.";

            Console.WriteLine();
            Console.WriteLine("Введите количество символов в слове:");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("\nВыведем слова текста, которые содержат не более 5 букв:");
            Message.Value(text, n);

            Console.WriteLine();
            Console.Write("\nУдалим из текста слова, заканчивающиеся на 'т': ");
            Message.Delete(text, 'т');

            Console.WriteLine();
            Console.WriteLine("Самое длинное слово: ");
            Message.LengthWord(text);

            Console.WriteLine();
            Console.WriteLine("Сторока из самых длинных слов: ");
            Message.WordsLong(text);

            Console.WriteLine();
            Message.WordsLong(text);
        }

        static class Message
        {
            internal static void Value(string text, int n)
            {
                string[] words = text.Split(new Char[] { ' ', ',', '.', '-', '\n' });

                foreach (string word in words)
                {
                    if (word == "") continue;
                    if (word.Length <= n) Console.Write(word + " ");
                }
            }

            internal static void Delete(string text, char v)
            {
                string[] words = text.Split(new Char[] { ' ', ',', '.', '-', '\n' });

                foreach (string word in words)
                {
                    if (word == "") continue;
                    if (word[word.Length - 1] == v)
                    {
                        Console.Write(word + " ");
                        text.Replace(word, "");
                    }
                }
            }

            internal static string LengthWord(string text)
            {
                string[] words = text.Split(new Char[] { ' ', ',', '.', '-', '\n' });
                string maxLength = words[0];
                int count = words[0].Length;

                foreach (string word in words)
                {
                    if (word.Length > count)
                    {
                        count = word.Length;
                        maxLength = word;
                    }
                }
                Console.WriteLine(maxLength);
                return maxLength;
            }

            static public StringBuilder WordsLong(string text)
            {
                string[] words = text.Split(new Char[] { ' ', ',', '.', '-', '\n' });
                StringBuilder str = new StringBuilder();
                int maxLength = Message.LengthWord(text).Length;

                foreach (string word in words)
                {
                    if (word.Length == maxLength)
                    {
                        str.Append(word.ToLower() + " ");
                    }
                }
                return str;
            }
        }
    }
}