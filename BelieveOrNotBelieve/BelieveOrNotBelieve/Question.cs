using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelieveOrNotBelieve
{
    public class Question
    {
        string text;       // Текст вопроса
        bool trueFalse;    // Правда или нет

        public string Text { get { return text; } set { if (value.GetType() == typeof(string)) text = value; } }
        public bool TrueFalse { get { return trueFalse; } set { if (value.GetType() == typeof(bool)) trueFalse = value; } }


        /// <summary>Для сериализации приводится пустой конструктор</summary>
        public Question()
        {
        }

        /// <summary>Метод записи вопроса</summary>
        /// <param name="text">Текст вопроса</param>
        /// <param name="trueFalse">Правильный ответ</param>
        public Question(string text, bool trueFalse)
        {
            this.text = text;
            this.trueFalse = trueFalse;
        }
    }
}
