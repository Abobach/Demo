using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Theatre_ARM
{
    public partial class Regisrtacia : Form
    {
        public Regisrtacia()
        {
            InitializeComponent();
        }

        private void Regisrtacia_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void reg_but_Click(object sender, EventArgs e)
        {
            string uniq = textBox_block.Text;
            if (EmailField.Text == "" | NameField.Text == "" | SurnameField.Text == "" | NumberField.Text == "" | LoginField.Text == "" | PassField.Text.Length < 8 | textBox_block.Text =="")
            {
                MessageBox.Show("Заполните все поля!!!");
                return;
            }
            else if (uniq == z)
            {
                DB db1 = new DB();

                DataTable table1 = new DataTable();

                MySqlDataAdapter adapter1 = new MySqlDataAdapter();

                MySqlCommand command1 = new MySqlCommand("SELECT * FROM autorizacia WHERE email= @ul ", db1.getConnection());
                command1.Parameters.Add("@ul", MySqlDbType.VarChar).Value = EmailField.Text;


                adapter1.SelectCommand = command1;
                adapter1.Fill(table1);

                if (table1.Rows.Count > 0)
                {
                    MessageBox.Show("Пользователь с такой почтой уже существует");
                }
                else
                {
                    DB db = new DB();

                    MySqlCommand command = new MySqlCommand("INSERT INTO autorizacia (email, password, login, name, surname, number) VALUES (@em, @ps, @lg, @nm, @sr, @nb)", db.getConnection());

                    command.Parameters.Add("@em", MySqlDbType.VarChar).Value = EmailField.Text;
                    command.Parameters.Add("@ps", MySqlDbType.VarChar).Value = PassField.Text;
                    command.Parameters.Add("@lg", MySqlDbType.VarChar).Value = LoginField.Text;
                    command.Parameters.Add("@nm", MySqlDbType.VarChar).Value = NameField.Text;
                    command.Parameters.Add("@sr", MySqlDbType.VarChar).Value = SurnameField.Text;
                    command.Parameters.Add("@nb", MySqlDbType.VarChar).Value = NumberField.Text;

                    db.openConnection();

                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Аккаунт был создан");
                        Autorizacia loginform = new Autorizacia();
                        loginform.Show();
                        this.Hide();

                    }
                    else
                        MessageBox.Show("Аккаунт не был создан");

                    db.closeConnection();
                }

            }
        }
        public int c = 0;
        public string z = "";
        private void button_block_Click(object sender, EventArgs e)
        {
            if (c == 3)
            {
                MessageBox.Show("Вам уже отправлен код подтверждения");
                return;
            }
            else
            {
                Random rnd = new Random();
                int value = rnd.Next(10000);
                z = Convert.ToString(value);

                MailAddress fromAdress = new MailAddress("gorders.228@gmail.com", "Театр Filadelfia");

                MailAddress toAdress = new MailAddress(EmailField.Text);

                MailMessage messadge = new MailMessage(fromAdress, toAdress);

                messadge.Body = "Код подтверждения: " + z + "";
                messadge.Subject = "Регистрация";

                SmtpClient smtpClient = new SmtpClient();
                smtpClient.Host = "smtp.gmail.com";
                smtpClient.Port = 587;
                smtpClient.EnableSsl = true;
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential(fromAdress.Address, "Poma2003_");

                smtpClient.Send(messadge);
                c++;

            }
        }
    }
}
