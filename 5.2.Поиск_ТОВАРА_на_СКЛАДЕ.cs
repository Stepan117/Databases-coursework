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
    public partial class Поиск_ТОВАРА_на_СКЛАДЕ : Form
    {
        SqlConnection con1 = new SqlConnection(@"Data Source=LAPTOP-SS7MA5DF; Initial Catalog=Степан; Integrated Security=True");

        public Поиск_ТОВАРА_на_СКЛАДЕ()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlDataAdapter DataAdapter = new SqlDataAdapter("select ID_Склад, Наименование,Название, Телефон, Адрес from Товар join Склад on Склад.ID_Склад=Товар.ID_Склада where Наименование like '%" + textBox1.Text + "%'", con1);
            DataTable DataTable = new DataTable();
            DataAdapter.Fill(DataTable);
            dataGridView1.DataSource = DataTable;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Товары form_worker;
            form_worker = new Товары();
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
