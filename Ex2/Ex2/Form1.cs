using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex2
{
    //2. Создайте простую форму
    //на котором свяжите свойство Text элемента TextBox
    //со свойством Value элемента NumericUpDown.

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
       
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var mult = (int)numericUpDown1.Value * (int)numericUpDown2.Value;
            textBox1.Text = Convert.ToString(mult);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
        }
    }
}
