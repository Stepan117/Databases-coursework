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
    public partial class Сотрудник123 : Form
    {
        public Сотрудник123()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Заказы1 form_worker;
            form_worker = new Заказы1();
            form_worker.Left = this.Left;
            form_worker.Top = this.Top;
            this.Hide();
            form_worker.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Заказчики1 form_worker;
            form_worker = new Заказчики1();
            form_worker.Left = this.Left;
            form_worker.Top = this.Top;
            this.Hide();
            form_worker.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Склады1 form_worker;
            form_worker = new Склады1();
            form_worker.Left = this.Left;
            form_worker.Top = this.Top;
            this.Hide();
            form_worker.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Сотрудники1 form_worker;
            form_worker = new Сотрудники1();
            form_worker.Left = this.Left;
            form_worker.Top = this.Top;
            this.Hide();
            form_worker.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Товары1 form_worker;
            form_worker = new Товары1();
            form_worker.Left = this.Left;
            form_worker.Top = this.Top;
            this.Hide();
            form_worker.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Услуги1 form_worker;
            form_worker = new Услуги1();
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

        }
    }
}
