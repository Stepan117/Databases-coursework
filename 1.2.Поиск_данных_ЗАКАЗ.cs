﻿using System;
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
    public partial class Поисе_данных_ЗАКАЗ : Form
    {
        SqlConnection con1 = new SqlConnection(@"Data Source=LAPTOP-SS7MA5DF; Initial Catalog=Степан; Integrated Security=True");
        public Поисе_данных_ЗАКАЗ()
        {
            InitializeComponent();
            comboBox1.Items.Add("Дата");
            comboBox1.Items.Add("Стоимость");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlDataAdapter DataAdapter = new SqlDataAdapter("SELECT * FROM Заказ WHERE " + comboBox1.Text + " LIKE '%" + textBox1.Text + "%' ", con1);
            DataTable DataTable = new DataTable();
            DataAdapter.Fill(DataTable);
            dataGridView1.DataSource = DataTable;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Заказы form_worker;
            form_worker = new Заказы();
            form_worker.Left = this.Left;
            form_worker.Top = this.Top;
            this.Hide();
            form_worker.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
