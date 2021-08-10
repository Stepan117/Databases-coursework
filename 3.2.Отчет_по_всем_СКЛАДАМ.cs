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
    public partial class Отчет_по_всем_СКЛАДАМ : Form
    {
        SqlConnection con1 = new SqlConnection(@"Data Source=LAPTOP-SS7MA5DF; Initial Catalog=Степан; Integrated Security=True");

        public Отчет_по_всем_СКЛАДАМ()
        {
            InitializeComponent();
        }

        void Load_Data()
        {
            SqlDataAdapter DataAdapter = new SqlDataAdapter("SELECT * FROM Склад", con1);
            DataTable DataTable = new DataTable();
            DataAdapter.Fill(DataTable);
            dataGridView1.DataSource = DataTable;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Склад form_worker;
            form_worker = new Склад();
            form_worker.Left = this.Left;
            form_worker.Top = this.Top;
            this.Hide();
            form_worker.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Отчет_по_всем_СКЛАДАМ_Load(object sender, EventArgs e)
        {
            con1.Open();
            Load_Data();
        }
    }
}
