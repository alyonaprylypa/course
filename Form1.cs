using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_Enter(object sender, EventArgs e)
        {
            if (loginField.Text == "Логин")
            {
                loginField.Text = "";

                loginField.ForeColor = Color.Black;
            }
        }

        private void login_Leave(object sender, EventArgs e)
        {
            if (loginField.Text == "")
            {
                loginField.Text = "Логин";

                loginField.ForeColor = Color.Silver;
            }
        }

        private void password_Enter(object sender, EventArgs e)
        {
            if (passwordField.Text == "Пароль")
            {
                passwordField.Text = "";
                passwordField.PasswordChar = '*';
                passwordField.ForeColor = Color.Black;
            }
        }

        private void password_Leave(object sender, EventArgs e)
        {
            if (passwordField.Text == "")
            {
                passwordField.Text = "Пароль";
                passwordField.PasswordChar = '\0';
                passwordField.ForeColor = Color.Silver;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrationForm regForm = new RegistrationForm();
            regForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String login = loginField.Text;
            String pass = passwordField.Text;

            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `agents` WHERE `login` = @login AND `password` = @password", db.getConnection());
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = login;
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = pass;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                if (table.Rows[0][4].ToString()=="False")
                {
                    Form2 form2 = new Form2(table.Rows[0][0].ToString());
                    this.Hide();
                    form2.Show();
                }
                else
                {
                    AdminForm admForm = new AdminForm();
                    this.Hide();
                    admForm.Show();
                }
            }
            else
            {
                MessageBox.Show("Введите правильный логин или пароль");
            }


        }

        private void label3_Enter(object sender, EventArgs e)
        {
            RegistrationForm regForm = new RegistrationForm();
            regForm.Show();
        }

    }
}
