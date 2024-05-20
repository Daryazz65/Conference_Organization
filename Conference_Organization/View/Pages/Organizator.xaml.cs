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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Conference_Organization.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для Organizator.xaml
    /// </summary>
    public partial class Organizator : Page
    {
        public Organizator()
        {
            InitializeComponent();
        }
         
        private void GenerateGreeting()
        {
            string greeting = string.Empty;
            // 1) Генерация времени работы.
            TimeSpan CurrentTime = DateTime.Now.TimeOfDay;
            
            if(new TimeSpan(5, 0, 0)< CurrentTime && new TimeSpan(11, 0, 0) >= CurrentTime)
            {
                greeting = "Доброе утро!\n";
            }
            else if (new TimeSpan(11, 1, 0) < CurrentTime && new TimeSpan(18, 0, 0) >= CurrentTime)
            {
                greeting = "Добрый день!\n";
            }
            else if (new TimeSpan(18, 1, 0) < CurrentTime && new TimeSpan(24, 0, 0) >= CurrentTime)
                {
                    greeting = "Добрый вечер!\n";
                }
            else
            {
                greeting = "Доброй ночи!\n";
            }
            // 2) Определение пола пользователя.

            // 3) Извлчение имени и отчества пользователя.
        }
        private void MeropritBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void YchastnikBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void JuryBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ProfilBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
