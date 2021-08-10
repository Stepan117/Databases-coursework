using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Степан
{
    public partial class Администратор : Form
    {
        public Администратор()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Заказы form_worker;
            form_worker = new Заказы();
            form_worker.Left = this.Left;
            form_worker.Top = this.Top;
            this.Hide();
            form_worker.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Заказчики form_worker;
            form_worker = new Заказчики();
            form_worker.Left = this.Left;
            form_worker.Top = this.Top;
            this.Hide();
            form_worker.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Склад form_worker;
            form_worker = new Склад();
            form_worker.Left = this.Left;
            form_worker.Top = this.Top;
            this.Hide();
            form_worker.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Сотрудники form_worker;
            form_worker = new Сотрудники();
            form_worker.Left = this.Left;
            form_worker.Top = this.Top;
            this.Hide();
            form_worker.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Товары form_worker;
            form_worker = new Товары();
            form_worker.Left = this.Left;
            form_worker.Top = this.Top;
            this.Hide();
            form_worker.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Услуги form_worker;
            form_worker = new Услуги();
            form_worker.Left = this.Left;
            form_worker.Top = this.Top;
            this.Hide();
            form_worker.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Неверный пароль. \nПопробуйте снова.");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Авторизация form_worker;
            form_worker = new Авторизация();
            form_worker.Left = this.Left;
            form_worker.Top = this.Top;
            this.Hide();
            form_worker.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
