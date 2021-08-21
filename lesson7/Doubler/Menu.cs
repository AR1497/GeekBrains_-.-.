using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace UdvoitelGame
{
    public partial class Menu : Form
    {
        public int randomNumber;

        public Menu()
        {
            InitializeComponent();
        }

        private void btnPlay_Click_1(object sender, EventArgs e)
        {
            Thread.Sleep(500);
            MainForm mainForm = new MainForm();
            mainForm.Show();// Открытие главного поля
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}

