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
    public partial class Заказчики : Form
    {
        public Заказчики()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Отчет_по_всем_ЗАКАЗЧИКАМ form_worker;
            form_worker = new Отчет_по_всем_ЗАКАЗЧИКАМ();
            form_worker.Left = this.Left;
            form_worker.Top = this.Top;
            this.Hide();
            form_worker.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Поиск_ЗАКАЗОВ_ЗАКАЗЧИКА form_worker;
            form_worker = new Поиск_ЗАКАЗОВ_ЗАКАЗЧИКА();
            form_worker.Left = this.Left;
            form_worker.Top = this.Top;
            this.Hide();
            form_worker.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Редактирование_данных_ЗАКАЗЧИКА form_worker;
            form_worker = new Редактирование_данных_ЗАКАЗЧИКА();
            form_worker.Left = this.Left;
            form_worker.Top = this.Top;
            this.Hide();
            form_worker.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Поиск_данных_ЗАКАЗЧИКА form_worker;
            form_worker = new Поиск_данных_ЗАКАЗЧИКА();
            form_worker.Left = this.Left;
            form_worker.Top = this.Top;
            this.Hide();
            form_worker.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Администратор form_worker;
            form_worker = new Администратор();
            form_worker.Left = this.Left;
            form_worker.Top = this.Top;
            this.Hide();
            form_worker.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
