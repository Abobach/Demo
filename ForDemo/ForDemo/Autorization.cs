using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForDemo
{
    class Autorization
    {
        /// <summary>
        /// Авторизация пользователя (Соежинение не открывается в классе!)
        /// </summary>
        /// <param name="login">Поле логина</param>
        /// <param name="password">Поле пароля</param>
        /// <param name="connection">Подключение к бд</param>
        /// <returns></returns>
        public bool Aut(string login, string password, SqlConnection connection)
        {
            bool succ = false;
            SqlCommand cmd = new SqlCommand("select * from [DataBase] where [Login] = '" + login + "' and [Password] = '" + password + "'", connection);
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
