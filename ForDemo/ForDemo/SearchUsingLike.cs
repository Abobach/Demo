using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ForDemo
{
    class SearchUsingLike
    {
        /// <summary>
        /// Желательно вставлять использование класса в нажатие на кнопку, но можно и в TextBox.TextChanged, тогда инфа будет искаться динамически
        /// Вся инфа будет выводиться в DataGrid
        /// </summary>
        /// <param name="text">Поле, по которому ищем информацию (типо TextBox)</param>
        /// <param name="connection">Подключение к бд</param>
        /// <param name="dataGrid">Имя элемента DataGrid на визуальной форме (окно)</param>
        public void SearchInfo(string text, SqlConnection connection, DataGrid dataGrid)
        {
            //Не оч уверен за правильность написания метода, особенно при объявлении адаптера, протестируйте

            //!!!НАВЕРНОЕ, Я НЕ ПРОБОВАЛ!!! Но точно знаю, что два процента выводят целиковое слово


            //Проценты ищут по разному, этот пример ищет все совпадение в целиковом слове (Пример: введено "при" - "привет" "приехал" "чуприн" 
            //Процент впереди слова найдёт только "привет" и "приехал"
            //Процент в конце слова, найдёт только "чуприн" 
            SqlCommand cmd = new SqlCommand("select * from [DataBase] where [Row] like '%" + text + "%'", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
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
