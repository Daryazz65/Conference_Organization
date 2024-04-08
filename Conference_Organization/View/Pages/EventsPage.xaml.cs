using Conference_Organization.Model;
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
        public EventsPage()
        {
            InitializeComponent();

            EventsLv.ItemsSource = App.context.Event.ToList();

            // Заполняем выпадающий список данными из таблицы Direction.
            DirectionsCmb.ItemsSource = App.context.Direction.ToList();
        }

        private void DirectionsCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Direction selectedDirection = DirectionsCmb.SelectedItem as Direction;

            EventsLv.ItemsSource = App.context.Event.Where(ev => ev.DirectionId == selectedDirection.Id).ToList();
        }
    }
}
