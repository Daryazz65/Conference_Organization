using Conference_Organization.AppData;
using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace Conference_Organization.View.Widows
{
    /// <summary>
    /// Логика взаимодействия для Authentication.xaml
    /// </summary>
    public partial class Authentication : Window
    {
        public Authentication()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(AutheticationHelper.CheckData(LoginTb.Text, PasswordPb.Password) == true)
            {
                // yspesh 
                SaveUserData();
                Close();

            }
            else
            {
                // neyspesh
                if (BlockSystemHelper.IncreaseIncorrectInput() == 3)
                {
                    BlockWindow blockSystemWindow = new BlockWindow();

                    if(blockSystemWindow.ShowDialog() == true)
                    {
                        BlockSystemHelper.incorrectInputCount = 0;
                    }
                }
            }
        }

        private void SaveUserData()
        {
            if (RememberMeCb.IsChecked == true)
            {
                // сохр-е данных
                Properties.Settings.Default.LoginValue = LoginTb.Text;
                Properties.Settings.Default.PasswordValue = PasswordPb.Password;
            }
            else
            {
                Properties.Settings.Default.LoginValue = string.Empty;
                Properties.Settings.Default.PasswordValue = string.Empty;
            }

            // фикс-уем изм-я
            Properties.Settings.Default.Save();
        }
      
        private void LoadUserData()
        {
            LoginTb.Text = Properties.Settings.Default.LoginValue;
            PasswordPb.Password = Properties.Settings.Default.PasswordValue;
        }

    }
}
