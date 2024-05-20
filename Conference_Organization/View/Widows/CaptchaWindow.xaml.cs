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
    /// Логика взаимодействия для Captcha.xaml
    /// </summary>
    public partial class Captcha : Window
    {
        public Captcha()
        {
            InitializeComponent();
            //CaptchTbl.Text = AutheticationHelper;
            //CaptchTbl.Text = captcha; 

            // НЕПОНЯТНО ЧТО ТУТ ДЕЛАТЬ !!!!!!!!!! У МЕНЯ НЕТ КАПЧИ В ЦЕЛОМ. ДОДЕЛАТЬ КАК ТО.
        } 

        private void EnterBtn_Click(object sender, RoutedEventArgs e)
        {
            //if (CaptchTb.Text == _captcha)
            //{
            //    DialogResult = true;
            //    Close();
            //}
            //else
            //{
            //    MessageBox.Show("Капча введена неправильно");
            //}
        }
    }
}
