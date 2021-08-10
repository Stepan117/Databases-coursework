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
    public partial class Отчеты_по_всем_СОТРУДНИКАМ : Form
    {
        SqlConnection con1 = new SqlConnection(@"Data Source=LAPTOP-SS7MA5DF; Initial Catalog=Степан; Integrated Security=True");

        public Отчеты_по_всем_СОТРУДНИКАМ()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Сотрудники form_worker;
            form_worker = new Сотрудники();
            form_worker.Left = this.Left;
            form_worker.Top = this.Top;
            this.Hide();
            form_worker.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Отчеты_по_всем_СОТРУДНИКАМ_Load(object sender, EventArgs e)
        {
            con1.Open();
            Load_Data();
        }
        void Load_Data()
        {
            SqlDataAdapter DataAdapter = new SqlDataAdapter("SELECT * FROM Сотрудник", con1);
            DataTable DataTable = new DataTable();
            DataAdapter.Fill(DataTable);
            dataGridView1.DataSource = DataTable;
        }
    }
}
