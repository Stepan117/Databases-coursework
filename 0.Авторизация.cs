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
    public partial class Авторизация : Form
    {
        string selectedState;
        public Авторизация()
        {
            InitializeComponent();
            logincomboBox.Items.Add("Администратор");
            logincomboBox.Items.Add("Сотрудник");
        }

        private void logincomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedState = logincomboBox.SelectedItem.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Сотрудник123 form_worker;
            form_worker = new Сотрудник123();
            Администратор form_admin;
            form_admin = new Администратор();
            if (selectedState == "Администратор")
            {
                if (this.passwordtextBox.Text == "1")
                {
                    form_admin.Left = this.Left;
                    form_admin.Top = this.Top;
                    this.Hide();
                    form_admin.Show();
                }
                else MessageBox.Show("Неверный пароль. Попробуйте снова.");
            }
            if (selectedState == "Сотрудник")
            {
                if (this.passwordtextBox.Text == "2")
                {
                    form_worker.Left = this.Left;
                    form_worker.Top = this.Top;
                    this.Hide();
                    form_worker.Show();
                }
                else MessageBox.Show("Неверный пароль. Попробуйте снова.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
