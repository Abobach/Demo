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
    public partial class Autorizacia : Form
    {
        public Autorizacia()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox_log.Text=="poma1"| textBox_pass.Text=="12345")
            {
                Main_user user = new Main_user();
                user.Show();
                this.Hide();
            }
            else if(textBox_log.Text == "direct" | textBox_pass.Text == "12")
            {
                Direct user = new Direct();
                user.Show();
                this.Hide();
            }

            else
            {
                DB db = new DB();

                DataTable table = new DataTable();

                MySqlDataAdapter adapter = new MySqlDataAdapter();

                MySqlCommand command = new MySqlCommand("SELECT * FROM autorizacia WHERE login = @ul AND password = @up", db.getConnection());
                command.Parameters.Add("@ul", MySqlDbType.VarChar).Value = textBox_log.Text;
                command.Parameters.Add("@up", MySqlDbType.VarChar).Value = textBox_pass.Text;

                adapter.SelectCommand = command;
                adapter.Fill(table);

                if (textBox_log.Text == "" | textBox_pass.Text == "")
                {
                    MessageBox.Show("Заполните все поля!!!");
                }
                else
                {
                    if (table.Rows.Count > 0)
                    {
                        string iduser = table.Rows[0][0].ToString();

                        Main_Form mainform = new Main_Form();
                        mainform.id = iduser;
                        mainform.Show();
                        this.Hide();

                    }
                    else
                        MessageBox.Show("Неверный email или пароль");
                    return;
                }
            }

        }

        private void label6_Click(object sender, EventArgs e)
        {
            Regisrtacia reg = new Regisrtacia();
            reg.Show();
            this.Hide();
        }

        private void Autorizacia_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
