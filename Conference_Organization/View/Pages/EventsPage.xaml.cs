using Conference_Organization.Model;
using Conference_Organization.View.Widows;
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
    /// Логика взаимодействия для EventsPage.xaml
    /// </summary>
    public partial class EventsPage : Page
    {
        // Передали записи из таблицы БД в программный список (направления).
        List<Direction> directions = App.context.Direction.ToList(); 

        // Передали записи из таблицы БД в программный список (мероприятия).
        List<Event> events = App.context.Event.ToList();

        public EventsPage()
        {
            InitializeComponent();

            EventsLv.ItemsSource = App.context.Event.ToList();

            // Вставляем программно направление в ComboBox.
            directions.Insert(0, new Direction { Name = "Все направления" });

            // Заполняем выпадающий список данными из таблицы Direction.
            DirectionsCmb.ItemsSource = directions;
        }

        private void DirectionsCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Direction selectedDirection = DirectionsCmb.SelectedItem as Direction;

            if (DirectionsCmb.SelectedIndex == 0)
            {
                EventsLv.ItemsSource = events;
            }
            else
            {
            EventsLv.ItemsSource = events.Where(ev => ev.DirectionId == selectedDirection.Id).ToList();
            }
        }

        

        // Реализовать поиск по дате.
        private void EventDateDp_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            if (EventDateDp.SelectedDate != null)
            {
                EventsLv.ItemsSource = events.Where(ev => ev.Date == EventDateDp.SelectedDate);
            }
            else
            {
                EventsLv.ItemsSource = events;
            }
        }

        // Реализовать переход на окно авторизации и само окно.
        private void enterBtn_Click(object sender, RoutedEventArgs e)
        {
            
         
        }

        private void LoginBtn_Click(object sender, RoutedEventArgs e)
        {
            Authentication authentication = new Authentication();
            authentication.ShowDialog();
        }
    }
}
