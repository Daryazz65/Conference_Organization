using Conference_Organization.Model;
using Conference_Organization.View.Pages;
using Conference_Organization.View.Widows;
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
        public static bool GenerateCaptcha()
        {
            Random random = new Random();
            string captcha = "";
            for (int i = 1; i <= 4; i++)
            {
                char captchaChar = Convert.ToChar(random.Next(65, 91));
                captcha += captchaChar;
            }
            Captcha captchaWindow = new Captcha();
            captchaWindow.ShowDialog();
            if(captchaWindow.DialogResult == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool CheckData(string login, string password)
        {
            currentUser = App.context.User.FirstOrDefault(u => u.Login == login && u.Password == password);
            if (currentUser != null)
            {
                switch (currentUser.RoleId)
                {
                    case 1:
                        FrameHelper.mainFrame.Navigate(new Participant());
                        break;
                    case 2:
                        FrameHelper.mainFrame.Navigate(new Moderator());
                        break;
                    case 3:
                        FrameHelper.mainFrame.Navigate(new Jury());
                        break;
                    case 4:
                        FrameHelper.mainFrame.Navigate(new Organizator());
                        break;
                } 
                MessageBox.Show("Пользователь авторизовался!");
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
