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
    public partial class Form2 : Form
    {
        public Form2(string agentId)
        {
            InitializeComponent();
            agentNum.Text = agentId;
            agentNum.ReadOnly = true;
            comission.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!checkParameters())
            {
                return;
            }

            if (!int.TryParse(contractNum.Text, out int contrNum))
            {
                MessageBox.Show("Введите корректный номер договора");
                return;
            }
            if (!int.TryParse(bankAccount.Text, out int bankAcc))
            {
                MessageBox.Show("Введите корректный номер договора");
                return;
            }
            if (!float.TryParse(summ.Text, out float summa))
            {
                MessageBox.Show("Введите корректную сумму страхования");
                return;
            }
            if (!float.TryParse(prize.Text, out float priz))
            {
                MessageBox.Show("Введите корректную страховую премию");
                return;
            }

            if (dateTimePicker1.Value > dateTimePicker2.Value)
            {
                MessageBox.Show("Дата начала не должна быть позже даты окончания");
                return;
            }
            Form2 form2 = new Form2("");
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            String isOnce = "once";
            if (radioButton2.Checked)
            {
                isOnce = "month";
            }
            MySqlCommand commandAddClient = new MySqlCommand("INSERT INTO `clients` (`agents_id`, `firstname`, `lastname`, `secondname`, `contract_num`, `bank_account`) VALUES (@agentId, @first, @last, @second, @contr, @bankacc);", db.getConnection());
            commandAddClient.Parameters.Add("@agentId", MySqlDbType.VarChar).Value = agentNum.Text;
            commandAddClient.Parameters.Add("@first", MySqlDbType.VarChar).Value = firstname.Text;
            commandAddClient.Parameters.Add("@last", MySqlDbType.VarChar).Value = lastname.Text;
            commandAddClient.Parameters.Add("@second", MySqlDbType.VarChar).Value = secondname.Text;
            commandAddClient.Parameters.Add("@contr", MySqlDbType.Int32).Value = contrNum;
            commandAddClient.Parameters.Add("@bankacc", MySqlDbType.Int32).Value = bankAcc;

            MySqlCommand commandAddContract = new MySqlCommand("INSERT INTO `contracts` (`id`, `summ`, `prize`, `begin`, `end`, `isonce`, `comission`, `agentId`) VALUES (@id, @summ, @prize, @begin, @end, @isonce, @comission, @agentId)", db.getConnection());
            
            commandAddContract.Parameters.Add("@id", MySqlDbType.Int32).Value = contrNum;
            commandAddContract.Parameters.Add("@summ", MySqlDbType.Float).Value = summa;
            commandAddContract.Parameters.Add("@prize", MySqlDbType.Float).Value = priz;
            commandAddContract.Parameters.Add("@begin", MySqlDbType.DateTime).Value = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            commandAddContract.Parameters.Add("@end", MySqlDbType.DateTime).Value = dateTimePicker2.Value.ToString("yyyy-MM-dd");
            commandAddContract.Parameters.Add("@isonce", MySqlDbType.Enum).Value = isOnce;
            commandAddContract.Parameters.Add("@comission", MySqlDbType.Float).Value = comission.Text;
            commandAddContract.Parameters.Add("@agentId", MySqlDbType.Int32).Value = agentNum.Text;
            db.openConnection();
            if (commandAddClient.ExecuteNonQuery() == 1 && commandAddContract.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Договор успешно добавлен");
                this.Hide();
                Form2 form22 = new Form2(agentNum.Text);
                form22.Show();
            }
            else
            {
                MessageBox.Show("Ошибка добавления договора");
            }

            db.closeConnection();
        }
        private Boolean checkParameters()
        {
            if (firstname.Text == "")
            {
                MessageBox.Show("Введите имя клиента");
                return false;
            }
            if (lastname.Text == "")
            {
                MessageBox.Show("Введите фамилию клиента");
                return false;
            }
            if (secondname.Text == "")
            {
                MessageBox.Show("Введите отчество клиента");
                return false;
            }
            if (contractNum.Text == "" || bankAccount.Text == "")
            {
                MessageBox.Show("Введите номер договора и банковские реквизиты");
                return false;
            }
            if (firstname.Text == "")
            {
                MessageBox.Show("Введите имя клиента");
                return false;
            }
            if (contractNum.Text == "")
            {
                MessageBox.Show("Введите номер договора");
                return false;
            }
            if (bankAccount.Text == "")
            {
                MessageBox.Show("Введите банковский счет");
                return false;
            }
            if (summ.Text == "")
            {
                MessageBox.Show("Введите страховую сумму");
                return false;
            }
            if (prize.Text == "")
            {
                MessageBox.Show("Введите страховую премию");
                return false;
            }
            return true;
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void summ_Leave(object sender, EventArgs e)
        {
            if (summ.Text != "")
            {
                if(float.TryParse(summ.Text, out float summa)){
                    comission.Text = (summa * 0.05).ToString();
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
