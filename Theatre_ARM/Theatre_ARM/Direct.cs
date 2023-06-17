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
    public partial class Direct : Form
    {
        public Direct()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string connectString = "server = localhost; port = 3307; username = root; password = root; database = teather_arm; SSL Mode = None";

            MySqlConnection myConnection = new MySqlConnection(connectString);

            myConnection.Open();

            string query = "SELECT * FROM autorizacia";
            MySqlDataAdapter ms_data = new MySqlDataAdapter(query, connectString);

            DataTable table = new DataTable();
            ms_data.Fill(table);
            dataGridView1.DataSource = table;
        }
        public int colihectvo = 0;
        private void button2_Click(object sender, EventArgs e)
        {


            colihectvo++;
            if (colihectvo == 1)
            {
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    object[] items = new object[row.Cells.Count];
                    for (int i = 0; i < row.Cells.Count; i++)
                    {
                        items[i] = row.Cells[i].Value;
                    }
                    dataGridView1.Rows.Add(items);
                }
                for (int j = 0; j <= dataGridView1.Rows.Count - 1; j++)
                {
                    dataGridView1.Rows[j].Selected = false;
                }
                printPreviewDialog1.Document = printDocument1;
                printPreviewDialog1.ShowDialog();

                for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
                {
                    dataGridView1.Rows[i].Selected = false;
                }
                colihectvo = 0;
            }
        }

        private void printDocument1_PrintPage_1(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap objBmp = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height);
            dataGridView1.DrawToBitmap(objBmp, new Rectangle(0, 0, this.dataGridView1.Width, this.dataGridView1.Height));
            dataGridView1.AllowUserToAddRows = false;
            e.Graphics.DrawImage(objBmp, 0, 0);
        }
    }
}
