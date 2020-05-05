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
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void regSername_Enter(object sender, EventArgs e)
        {
            if (regSername.Text == "Фамилия")
            {
                regSername.Text = "";

                regSername.ForeColor = Color.Black;
            }
        }

        private void regSername_Leave(object sender, EventArgs e)
        {
            if (regSername.Text == "")
            {
                regSername.Text = "Фамилия";

                regSername.ForeColor = Color.Silver;
            }
        }

        private void regName_Enter(object sender, EventArgs e)
        {
            if (regName.Text == "Имя")
            {
                regName.Text = "";
                
                regName.ForeColor = Color.Black;
            }
        }

        private void regName_Leave(object sender, EventArgs e)
        {
            if (regName.Text == "")
            {
                regName.Text = "Имя";
                
                regName.ForeColor = Color.Silver;
            }
        }

        private void regLastName_Enter(object sender, EventArgs e)
        {
            if (regLastName.Text == "Отчество")
            {
                regLastName.Text = "";

                regLastName.ForeColor = Color.Black;
            }
        }

        private void regLastName_Leave(object sender, EventArgs e)
        {
            if (regLastName.Text == "")
            {
                regLastName.Text = "Отчество";

                regLastName.ForeColor = Color.Silver;
            }
        }

        private void loginField_Enter(object sender, EventArgs e)
        {
            if (loginField.Text == "Логин")
            {
                loginField.Text = "";

                loginField.ForeColor = Color.Black;
            }
        }

        private void loginField_Leave(object sender, EventArgs e)
        {
            if (loginField.Text == "")
            {
                loginField.Text = "Логин";

                loginField.ForeColor = Color.Silver;
            }
        }


        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (regPassword.Text == "Пароль")
            {
                regPassword.Text = "";
                regPassword.PasswordChar = '*';
                regPassword.ForeColor = Color.Black;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (regPassword.Text == "")
            {
                regPassword.Text = "Пароль";
                regPassword.PasswordChar = '\0';
                regPassword.ForeColor = Color.Silver;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            int isAdmin = 0;
            if (radioButton1.Checked)
            {
                isAdmin = 1;
            }
            MySqlCommand commandAddAgent = new MySqlCommand("INSERT INTO `agents` (`id`, `firstname`, `lastname`, `secondname`, `isadmin`, `login`, `password`) VALUES (NULL, @agentName, @agentSername, @agentSecondname, @isAdmin, @login, @password);", db.getConnection());
            commandAddAgent.Parameters.Add("@agentName", MySqlDbType.VarChar).Value = regName.Text;
            commandAddAgent.Parameters.Add("@agentSername", MySqlDbType.VarChar).Value = regSername.Text;
            commandAddAgent.Parameters.Add("@agentSecondname", MySqlDbType.VarChar).Value = regLastName.Text;
            commandAddAgent.Parameters.Add("@isAdmin", MySqlDbType.VarChar).Value = isAdmin;
            commandAddAgent.Parameters.Add("@login", MySqlDbType.VarChar).Value = loginField.Text;
            commandAddAgent.Parameters.Add("@password", MySqlDbType.VarChar).Value = regPassword.Text;
            db.openConnection();
            if (commandAddAgent.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Регистрация прошла успешно");
                LoginForm logForm = new LoginForm();
                this.Hide();
                logForm.Show();
            }
            else
            {
                MessageBox.Show("Ошибка при регистрации");
                this.Refresh();
            }

            db.closeConnection();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
