using Conference_Organization.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Ink;

namespace Conference_Organization.AppData
{
    internal class AutheticationHelper
    {
        public static User currentUser;

        public static bool CheckData(string login, string password)
        {
            // Получаем одну запись по условию из таблицы БД.
            currentUser = App.context.User.FirstOrDefault(u => u.Login == login && u.Password == password);

            if (currentUser != null)
            {
                // Загружаем страницы.
                MessageBox.Show("Пользователь авторизовался!");

                MainFrame.Navigate();

                return true;
            }
            MessageBox.Show("Пользователь не найден!");
            return false;
        }
    }
}
