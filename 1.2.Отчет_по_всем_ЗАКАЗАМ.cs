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
    public partial class Отчет_по_всем_ЗАКАЗАМ : Form
    {
        SqlConnection con1 = new SqlConnection(@"Data Source=LAPTOP-SS7MA5DF; Initial Catalog=Степан; Integrated Security=True");

        public Отчет_по_всем_ЗАКАЗАМ()
        {
            InitializeComponent();
        }

        void Load_Data()
        {
            SqlDataAdapter DataAdapter = new SqlDataAdapter("select ID_Заказ, Дата, Заказчик.ФИО, Наименование, Тип, Сотрудник.ФИО, Стоимость  from Заказ  join Заказчик on Заказ.ID_Заказчика=Заказчик.ID_Заказчика join Товар on Товар.ID_Товар=Заказ.ID_Товара join Услуга on Услуга.ID_Услуги=Заказ.ID_Услуги Join Сотрудник on Сотрудник.ID_Сотрудник=Заказ.ID_Сотрудника", con1);
            DataTable DataTable = new DataTable();
            DataAdapter.Fill(DataTable);
            dataGridView1.DataSource = DataTable;
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
            Application.Exit();
        }

        private void Отчет_по_всем_ЗАКАЗАМ_Load(object sender, EventArgs e)
        {
            con1.Open();
            Load_Data();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
