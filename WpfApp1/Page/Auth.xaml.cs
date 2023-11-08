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

namespace WpfApp1.Page
{
    /// <summary>
    /// Логика взаимодействия для Auth.xaml
    /// </summary>
    public partial class Auth
    {
        public Auth()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Auth_Btn(object sender, RoutedEventArgs e)
        {
            if (BoxLogin.Text == "admin" && BoxPassword.Password == "admin")
            {
                GuestMod.IsGuest = false;
                NavigationService.Navigate(new TableDB());
            }
            else
            {
                Error.Visibility = Visibility.Visible;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Goest_mod(object sender, RoutedEventArgs e)
        {
            GuestMod.IsGuest = true;
            NavigationService.Navigate(new TableDB());
        }
    }
    public static class GuestMod
    {
        public static bool IsGuest { get; set; }
    }
}
