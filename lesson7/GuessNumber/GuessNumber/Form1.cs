using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessNumber
{
    public partial class Form1 : Form
    {
        int number;
        int count = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            number = rnd.Next(1, 101);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var protection = int.TryParse(textBox1.Text, out var userNum);
            if (!protection)
            {
                lblprint.Text = ("Введите число");
                textBox1.Clear();
                return;
            }

            if (!((userNum >= 1) && (userNum <= 100)))
            {
                lblprint.Text = ("Введите число от 1 до 100");
                textBox1.Clear();
                return;
            }

            count++;
            label2.Text = Convert.ToString(count);

            if (userNum == number)
            {
                MessageBox.Show($"Поздравляю! Вы угадали за {count} ходов =)");
                if (count > 7) MessageBox.Show($"Можно было угадать за 7 ходов.");
            }
            else if (number > userNum) lblprint.Text = ($"Загаданное число больше {userNum}.");
            else lblprint.Text = ($"Загаданное число меньше {userNum}.");
            textBox1.Clear();
            textBox1.Focus();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void рестартToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
