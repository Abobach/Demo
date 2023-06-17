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

namespace Theatre_ARM
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }
        public string id;

        private void Main_Form_Load(object sender, EventArgs e)
        {
            DB db = new DB();
            DataTable table = new DataTable();
            db.openConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            string queryy = "SELECT email, login, name, surname, number FROM   autorizacia WHERE id = '" + id + "' ";
            MySqlCommand command = new MySqlCommand(queryy, db.getConnection());


            adapter.SelectCommand = command;
            adapter.Fill(table);
            //Создание читателя
            MySqlDataReader reader = command.ExecuteReader();



            //Пока читатель читает, записываем данные
            while (reader.Read())
            {

                DataBank.emails = reader["email"].ToString();

                DataBank.login = reader["login"].ToString();
                DataBank.name = reader["name"].ToString();
                DataBank.surname = reader["surname"].ToString();
                DataBank.number = reader["number"].ToString();

                label1.Text = DataBank.emails;
                label2.Text = DataBank.name + " " + DataBank.surname;
            }
            db.closeConnection();

            ch2 = 0;
            ch3 = 0;
            ch4 = 0;
        }

        private void Main_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Autorizacia auto = new Autorizacia();
            auto.Show();
            this.Hide();
        }
        public int ch2;
        public int ch3;
        public int ch4;
        private void button3_Click(object sender, EventArgs e)
        {
            string name = Microsoft.VisualBasic.Interaction.InputBox("Имя клиента: ");
            string surname = Microsoft.VisualBasic.Interaction.InputBox("Фамилия клиента: ");
            string number = Microsoft.VisualBasic.Interaction.InputBox("Телефон клиента: ");
            if (ch2 <= 0)
            {
                MessageBox.Show("выберите количество");
            }
            else if(name ==""| surname ==""| number =="")
            {
                MessageBox.Show("Заполниет форму клиента");
            }
            else
            {
                string sum = label9.Text;
                int sum2 = Convert.ToInt32(sum);
                int obsum = sum2 * ch2;

                string datatime = dateTimePicker1.Value + "";
                DB db = new DB();

                MySqlCommand command = new MySqlCommand("INSERT INTO zakaz (name, surname, number, datatime, position, cassmen, summa) VALUES (@nm, @sr, @nb, @dt, @ps, @cs, @ob)", db.getConnection());

                command.Parameters.Add("@nm", MySqlDbType.VarChar).Value = name;
                command.Parameters.Add("@sr", MySqlDbType.VarChar).Value = surname;
                command.Parameters.Add("@nb", MySqlDbType.VarChar).Value = number;
                command.Parameters.Add("@dt", MySqlDbType.VarChar).Value = datatime;
                command.Parameters.Add("@ps", MySqlDbType.VarChar).Value = label3.Text;
                command.Parameters.Add("@cs", MySqlDbType.VarChar).Value = DataBank.name +" "+ DataBank.surname;
                command.Parameters.Add("@ob", MySqlDbType.VarChar).Value = obsum;
                db.openConnection();

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Билеты добавлены в заказ");
                }
                else
                    MessageBox.Show("Билеты  не добавлены в заказ");

                db.closeConnection();
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (ch2 <= 0)
            {
                MessageBox.Show("минимальное значение");
            }
            else
            {
                ch2--;
                textBox1.Text = "" + ch2 + "";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (ch2 < 5)
            {
                ch2++;
                textBox1.Text = "" + ch2 + "";
            }
            else
            {
                MessageBox.Show("максимальное значение");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string name = Microsoft.VisualBasic.Interaction.InputBox("Имя клиента: ");
            string surname = Microsoft.VisualBasic.Interaction.InputBox("Фамилия клиента: ");
            string number = Microsoft.VisualBasic.Interaction.InputBox("Телефон клиента: ");
            if (ch3 <= 0)
            {
                MessageBox.Show("выберите количество");
            }
            else if (name == "" | surname == "" | number == "")
            {
                MessageBox.Show("Заполниет форму клиента");
            }
            else
            {
                string datatime = dateTimePicker1.Value + "";
                string sum = label8.Text;

                int sum2 = Convert.ToInt32(sum);

                int obsum = sum2 * ch3;
                DB db = new DB();

                MySqlCommand command = new MySqlCommand("INSERT INTO zakaz (name, surname, number, datatime, position, cassmen, summa) VALUES (@nm, @sr, @nb, @dt, @ps, @cs, @ob)", db.getConnection());

                command.Parameters.Add("@nm", MySqlDbType.VarChar).Value = name;
                command.Parameters.Add("@sr", MySqlDbType.VarChar).Value = surname;
                command.Parameters.Add("@nb", MySqlDbType.VarChar).Value = number;
                command.Parameters.Add("@dt", MySqlDbType.VarChar).Value = datatime;
                command.Parameters.Add("@ps", MySqlDbType.VarChar).Value = label4.Text;
                command.Parameters.Add("@cs", MySqlDbType.VarChar).Value = DataBank.name + " " + DataBank.surname;
                command.Parameters.Add("@ob", MySqlDbType.VarChar).Value = obsum;

                db.openConnection();

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Билеты добавлены в заказ");
                }
                else
                    MessageBox.Show("Билеты  не добавлены в заказ");

                db.closeConnection();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ch3 <= 0)
            {
                MessageBox.Show("минимальное значение");
            }
            else
            {
                ch3--;
                textBox2.Text = "" + ch3 + "";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (ch3 < 5)
            {
                ch3++;
                textBox2.Text = "" + ch3 + "";
            }
            else
            {
                MessageBox.Show("максимальное значение");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string name = Microsoft.VisualBasic.Interaction.InputBox("Имя клиента: ");
            string surname = Microsoft.VisualBasic.Interaction.InputBox("Фамилия клиента: ");
            string number = Microsoft.VisualBasic.Interaction.InputBox("Телефон клиента: ");
            if (ch4 <= 0)
            {
                MessageBox.Show("выберите количество");
            }
            else if (name == "" | surname == "" | number == "")
            {
                MessageBox.Show("Заполниет форму клиента");
            }
            else
            {
                string datatime = dateTimePicker1.Value + "";
                string sum = label11.Text;

                int sum2 = Convert.ToInt32(sum);

                int obsum = sum2 * ch4;
                DB db = new DB();

                MySqlCommand command = new MySqlCommand("INSERT INTO zakaz (name, surname, number, datatime, position, cassmen, summa) VALUES (@nm, @sr, @nb, @dt, @ps, @cs, @ob)", db.getConnection());

                command.Parameters.Add("@nm", MySqlDbType.VarChar).Value = name;
                command.Parameters.Add("@sr", MySqlDbType.VarChar).Value = surname;
                command.Parameters.Add("@nb", MySqlDbType.VarChar).Value = number;
                command.Parameters.Add("@dt", MySqlDbType.VarChar).Value = datatime;
                command.Parameters.Add("@ps", MySqlDbType.VarChar).Value = label5.Text;
                command.Parameters.Add("@cs", MySqlDbType.VarChar).Value = DataBank.name + " " + DataBank.surname;
                command.Parameters.Add("@ob", MySqlDbType.VarChar).Value = obsum;

                db.openConnection();

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Билеты добавлены в заказ");
                }
                else
                    MessageBox.Show("Билеты  не добавлены в заказ");

                db.closeConnection();
            }
        }
    }
}
