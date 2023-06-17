using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForDemo
{
    class Registration
    {
        /// <summary>
        /// Функция регистрации (Соединение не открывается в классе!)
        /// Добавляется только логин и пароль в бд, измените строку запроса и добавьте в метод больше данных, чтобы заполнить больше полей
        /// </summary>
        /// <param name="login">Поле логина</param>
        /// <param name="password">Поле пароля</param>
        /// <param name="connection">Подключение к бд</param>
        /// <returns></returns>
        public bool Reg(string login, string password, SqlConnection connection) 
        {
            bool succ = false;
            SqlCommand cmd = new SqlCommand("insert into [DataBase] ([Login], [Password]) values (@l, @p)", connection);
            cmd.Parameters.AddWithValue("@l", login);
            cmd.Parameters.AddWithValue("@p", password);
            try
            {
                cmd.ExecuteNonQuery();
                succ = true;
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            return succ;
        }
    }
}
