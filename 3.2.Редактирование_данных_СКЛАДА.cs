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
    public partial class Редактирование_данных_СКЛАДА : Form
    {
        SqlConnection con1 = new SqlConnection(@"Data Source=LAPTOP-SS7MA5DF; Initial Catalog=Степан; Integrated Security=True");

        public Редактирование_данных_СКЛАДА()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Склад(ID_Склад, Название, Телефон, Адрес)values('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "')", con1);
            cmd.ExecuteNonQuery();
            Load_Data();
            clear_fun();
            MessageBox.Show("Сохранено");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("UPDATE Склад SET Название='" + textBox2.Text + "', Телефон='" + textBox3.Text + "', Адрес='" + textBox4.Text + "' where ID_Склад='" + textBox1.Text + "'", con1);
            cmd.ExecuteNonQuery();
            Load_Data();
            clear_fun();
            MessageBox.Show("Обнавленно");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand del_cmd = new SqlCommand("DELETE FROM Склад WHERE ID_Склад='" + textBox1.Text + "'", con1);
            del_cmd.ExecuteNonQuery();
            Load_Data();
            clear_fun();
            MessageBox.Show("Удаленно");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            clear_fun();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Склад form_worker;
            form_worker = new Склад();
            form_worker.Left = this.Left;
            form_worker.Top = this.Top;
            this.Hide();
            form_worker.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Редактирование_данных_СКЛАДА_Load(object sender, EventArgs e)
        {
            con1.Open();
            Load_Data();
        }

        void clear_fun()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Enabled = false;

            int cri = dataGridView1.CurrentCell.RowIndex;
            textBox1.Text = dataGridView1.Rows[cri].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[cri].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[cri].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.Rows[cri].Cells[3].Value.ToString();
        }

        void Load_Data()
        {
            SqlDataAdapter DataAdapter = new SqlDataAdapter("SELECT * FROM Склад", con1);
            DataTable DataTable = new DataTable();
            DataAdapter.Fill(DataTable);
            dataGridView1.DataSource = DataTable;
        }
    }
}
