using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ЦПКиО_им_Маяковского
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-O038IN6;Initial Catalog=Demo;Integrated Security=True");
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-O038IN6;Initial Catalog=Demo;Integrated Security=True");
            string email = loginBox.Text;
            string pass = passBox.Text;
            string passReverd = passBoxShow.Password;
            SqlDataAdapter da = new SqlDataAdapter("SELECT [Логин ], [Пароль], [ФИО ], [Должность]  FROM Employees WHERE [Логин ] = '" + email + "'and [Пароль] ='" + pass + "'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                MainWindows m = new MainWindows();
                DataBank.name = dt.Rows[0][2].ToString();
                DataBank.role = dt.Rows[0][3].ToString();



                m.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Данные были введены неверно!", "Ошибка");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            


        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            passBox.Text = passBoxShow.Password;
        }

        private void Button_PreviewMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            
        }

        private void Button_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            passBoxShow.Visibility = Visibility.Visible;
            passBox.Text = passBoxShow.Password;
        }

        private void BtnAuth_MouseDown(object sender, MouseButtonEventArgs e)
        {
           
        }

        private void ShowBtn_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            passBoxShow.Visibility = Visibility.Hidden;
            passBox.Text = passBoxShow.Password;
            ShowBtn.Content = "Скрыть";
        }
    }
}
