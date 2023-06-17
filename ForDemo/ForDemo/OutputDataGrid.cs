using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Xml.Linq;

namespace ForDemo
{
    class OutputDataGrid
    {
        /// <summary>
        /// Вывод ВСЕХ данных в DataGrid (в классе лежит xaml код с привязкой данных)
        /// </summary>
        /// <param name="connection">Подключение к бд</param>
        /// <param name="dataGrid">Имя элемента DataGrid на визуальной форме (окно)</param>
        public void Grid(SqlConnection connection, DataGrid dataGrid) 
        {
            SqlDataAdapter adapter = new SqlDataAdapter("select * from [DataBase]", connection);
            DataTable dataTable = new DataTable();
            try 
            {
                adapter.Fill(dataTable);
                dataGrid.ItemsSource = dataTable.DefaultView;
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }
    }
}
//Пижня, чтобы создать датагрид с привязками, где имена колонок выводятся в Header такими, как вы их зададите

//< DataGrid x: Name = "dataGrid" HorizontalAlignment = "Center" VerticalAlignment = "Center" AutoGenerateColumns = "False" IsSynchronizedWithCurrentItem = "True" SelectionUnit = "Cell" >
//            < DataGrid.Columns >
//                < DataGridTextColumn Header = "Логин" Binding = "{Binding Login}" />
//                < DataGridTextColumn Header = "Пароль" Binding = "{Binding Password}" />
//            </ DataGrid.Columns >
//        </ DataGrid >

//Вы можете указать для каждого поля отдельно Readonly или же для всего DataGrid целиком