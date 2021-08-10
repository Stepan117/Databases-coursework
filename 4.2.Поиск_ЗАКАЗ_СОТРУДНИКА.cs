using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Степан
{
    public partial class Поиск_ЗАКАЗ_СОТРУДНИКА : Form
    {
        SqlConnection con1 = new SqlConnection(@"Data Source=LAPTOP-SS7MA5DF; Initial Catalog=Степан; Integrated Security=True");

        public Поиск_ЗАКАЗ_СОТРУДНИКА()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlDataAdapter DataAdapter = new SqlDataAdapter("select ID_Заказ, Дата, Заказчик.ФИО,Сотрудник.ФИО, Наименование,Тип from Сотрудник join Заказ on Сотрудник.ID_Сотрудник=Заказ.ID_Заказ join Товар on Товар.ID_Товар=Заказ.ID_Товара join Заказчик on Заказчик.ID_Заказчика=Заказ.ID_Заказчика join Услуга on Услуга.ID_Услуги=Заказ.ID_Услуги where Сотрудник.ФИО like '%" + textBox1.Text + "%'", con1);
            DataTable DataTable = new DataTable();
            DataAdapter.Fill(DataTable);
            dataGridView1.DataSource = DataTable;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Сотрудники form_worker;
            form_worker = new Сотрудники();
            form_worker.Left = this.Left;
            form_worker.Top = this.Top;
            this.Hide();
            form_worker.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
