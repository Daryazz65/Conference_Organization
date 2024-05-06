using Conference_Organization.Model;
using Conference_Organization.View.Pages;
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
        public static string captcha;
        public static bool CheckData(string login, string password)

        {
            // Получаем одну запись по условию из таблицы БД.
            currentUser = App.context.User.FirstOrDefault(u => u.Login == login && u.Password == password);

            if (currentUser != null)
            {
                // Загружаем страницы.
                MessageBox.Show("Пользователь авторизовался!");

                switch (currentUser.RoleId)
                {
                    case 1:
                        // открываем стр участника
                        FrameHelper.mainFrame.Navigate(new Participant());
                        break;
                    case 2:
                        // открываем стр модера
                        FrameHelper.mainFrame.Navigate(new Moderator());

                        break;

                    case 3:
                        // открываем стр жюри
                        FrameHelper.mainFrame.Navigate(new Jury());

                        break;

                    case 4:
                        // открываем стр орг-ора
                        FrameHelper.mainFrame.Navigate(new Organizator());

                        break;

                }

                return true;
            }
            return false;
        }
        public static bool GenerateCaptcha()
        {
            // Создаем генератор случайных символов.
            Random random = new Random();


            // Создаем цикл, который сделает 4 итерации.
            for (int i = 1; i<=4; i++)
            {
                // Генерируем число и конвертируем его в символ.
                char character = Convert.ToChar(random.Next(65, 91));
                // Складываем символы.
                captcha += character;
            }

            // Открываем окно с капчей.

        }
    }
}
