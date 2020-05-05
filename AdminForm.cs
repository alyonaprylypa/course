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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT `agents`.`lastname` As `Фамилия`, `agents`.`firstname`As `Имя`, `agents`.`secondname` As `Отчество`, `contracts`.`agentId` As `Номер агента`, COUNT(*) As `Количество заключенных договоров` FROM `contracts` LEFT JOIN `agents` ON `contracts`.`agentId`=`agents`.`id` GROUP BY `contracts`.`agentId`", db.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            dataGridView1.DataSource = table.DefaultView;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT `agents`.`lastname` As `Фамилия`, `agents`.`firstname`As `Имя`, `agents`.`secondname` As `Отчество`, `contracts`.`agentId` As `Номер агента`, SUM(`contracts`.`comission`) As `Общие выплаты агентам` FROM `contracts` LEFT JOIN `agents` ON `contracts`.`agentId`=`agents`.`id` GROUP BY `contracts`.`agentId`;", db.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            dataGridView1.DataSource = table.DefaultView;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT SUM(`contracts`.`summ`) As `Сумма заработка` FROM `contracts` WHERE DATE(`contracts`.`begin`) BETWEEN @begin AND @end;", db.getConnection());
            command.Parameters.Add("@begin", MySqlDbType.DateTime).Value = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            command.Parameters.Add("@end", MySqlDbType.DateTime).Value = dateTimePicker2.Value.ToString("yyyy-MM-dd");
            if (dateTimePicker1.Value > dateTimePicker2.Value)
            {
                MessageBox.Show("Дата начала не должна быть позже даты окончания");
                return;
            }
            adapter.SelectCommand = command;
            adapter.Fill(table);
            dataGridView1.DataSource = table.DefaultView;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT `contracts`.`isonce` AS `Тип страховых услуг`, COUNT(*) As `Количество заключенных договоров` FROM `contracts` GROUP BY `contracts`.`isonce`;", db.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            dataGridView1.DataSource = table.DefaultView;
        }
    }
}
