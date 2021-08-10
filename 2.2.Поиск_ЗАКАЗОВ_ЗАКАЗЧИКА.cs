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
    public partial class Поиск_ЗАКАЗОВ_ЗАКАЗЧИКА : Form
    {
        SqlConnection con1 = new SqlConnection(@"Data Source=LAPTOP-SS7MA5DF; Initial Catalog=Степан; Integrated Security=True");

        public Поиск_ЗАКАЗОВ_ЗАКАЗЧИКА()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlDataAdapter DataAdapter = new SqlDataAdapter("SELECT ID_Заказ, Дата, ФИО, Наименование, Тип FROM Заказчик JOIN Заказ ON Заказ.ID_Заказчика=Заказчик.ID_Заказчика JOIN Товар ON Товар.ID_Товар=Заказ.ID_Товара JOIN Услуга ON Услуга.ID_Услуги=Заказ.ID_Услуги WHERE ФИО LIKE '%" + textBox1.Text + "%'", con1);
            DataTable DataTable = new DataTable();
            DataAdapter.Fill(DataTable);
            dataGridView1.DataSource = DataTable;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Поиск_ЗАКАЗОВ_ЗАКАЗЧИКА_Load(object sender, EventArgs e)
        {

        }
    }
}
