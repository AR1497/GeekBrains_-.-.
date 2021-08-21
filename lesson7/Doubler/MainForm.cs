using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UdvoitelGame
{
    public partial class MainForm : Form
    {
        private int number;
        private int numberMoves;
        private int randomNumber;
        private int minCount;
        public MainForm()
        {
            InitializeComponent();
            RandomNumber(); // Получение рандомного победного числа
            MessageBox.Show($"Победное число: {randomNumber}. Количество ходов для выигрыша: {minCount}");
            number = 0; // Изначальное значение текущего числа
            numberMoves = 0; // Количество ходов
            SetNumber();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (numberMoves < minCount)
            {
                number++;
                numberMoves++;
            }
            SetNumber();
        }

        private void SetNumber()
        {
            lblNumber.Text = number.ToString();
            NumberMoves.Text = numberMoves.ToString();
            TotalNumber.Text = randomNumber.ToString();
            if ((number == randomNumber) && (numberMoves == minCount))   // Проверка соответствия полученого числа с победным числом
            {
                MessageBox.Show("Поздравляем,вы победили!" + " Количество ходов: " + numberMoves);
                this.Close();
            }
            else if ((number != randomNumber) && (numberMoves == minCount))
            {
                MessageBox.Show($"Увы,вы не уложились в нужное количество ходов: {minCount}");
            }
            else if (number > randomNumber)
            {
                MessageBox.Show($"Число получилось больше нужного: {randomNumber}");
            }
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            if (numberMoves < minCount)
            {
                number *= 2;
                numberMoves++;
            }
            SetNumber();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            number = 0;
            numberMoves = 0;
            SetNumber();
        }

        private void btnShowForm_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RandomNumber()
        {
            Random rnd = new Random();
            randomNumber = rnd.Next(1, 100);

            int f = Convert.ToInt32(randomNumber);
            while (f != 0)
            {
                if (f % 2 == 0)
                {
                    f = f / 2;
                    minCount++;
                }
                else
                {
                    f = f - 1;
                    minCount++;
                }
            }
        }
    }
}
