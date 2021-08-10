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
    public partial class Отчет_по_всем_ЗАКАЗЧИКАМ : Form
    {
        SqlConnection con1 = new SqlConnection(@"Data Source=LAPTOP-SS7MA5DF; Initial Catalog=Степан; Integrated Security=True");

        public Отчет_по_всем_ЗАКАЗЧИКАМ()
        {
            InitializeComponent();
        }

        void Load_Data()
        {
            SqlDataAdapter DataAdapter = new SqlDataAdapter("SELECT * FROM Заказчик", con1);
            DataTable DataTable = new DataTable();
            DataAdapter.Fill(DataTable);
            dataGridView1.DataSource = DataTable;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Заказчики form_worker;
            form_worker = new Заказчики();
            form_worker.Left = this.Left;
            form_worker.Top = this.Top;
            this.Hide();
            form_worker.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Отчет_по_всем_ЗАКАЗЧИКАМ_Load(object sender, EventArgs e)
        {
            con1.Open();
            Load_Data();
        }
    }
}
