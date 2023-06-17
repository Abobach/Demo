using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ЦПКиО_им_Маяковского
{
    /// <summary>
    /// Логика взаимодействия для MainWindows.xaml
    /// </summary>
    public partial class MainWindows : Window
    {
        public MainWindows()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var timer = new System.Windows.Threading.DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.IsEnabled = true;
            timer.Tick += (o, t) => { time.Content = DateTime.Now.ToString(); };
            timer.Start();

           

        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            PatronomicLabel.Content = DataBank.name;
            NameLabel.Content = DataBank.role;
        }

        private void Grid_Loaded_1(object sender, RoutedEventArgs e)
        {
           

            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (NameLabel.Content.ToString().Contains("Продавец"))
            {
                RenderPages.Children.Clear();
                RenderPages.Children.Add(new SellPage());
            }
            else if (NameLabel.Content.ToString().Contains("Администратор"))
            {
                RenderPages.Children.Clear();
                RenderPages.Children.Add(new AdminPage());
            }
            else if (NameLabel.Content.ToString().Contains("Старший смены"))
            {
                RenderPages.Children.Clear();
                RenderPages.Children.Add(new Smena());
            }

        }
    }
}
