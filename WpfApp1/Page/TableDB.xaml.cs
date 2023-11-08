using DBtest;
using DBtest.Models;
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
using WpfApp1.Window;

namespace WpfApp1.Page
{
    /// <summary>
    /// Логика взаимодействия для TableDB.xaml
    /// </summary>
    public partial class TableDB
    {
        public TableDB()
        {
            InitializeComponent();
            using (var context = new MalContext())
            {
                List<Prod> prods = context.Prods.ToList();
                listView.ItemsSource = prods;
            }
            if (GuestMod.IsGuest == true)
            {
                Admin_mod.Visibility = Visibility.Hidden;
            }
        }

        private void Button_Click_Buket(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            Prod prod = (Prod)button.Tag;

            using (var context = new MalContext())
            {
                bool itemInBuket = context.Bukets.Any(item => item.Bulet_Name == prod.Name);
                if (!itemInBuket)
                {
                    Buket buket = new Buket
                    {
                        Bulet_Name = prod.Name,
                        Bulet_Image = prod.Image,
                    };
                    context.Bukets.Add(buket);
                    context.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Дубликат");
                }
            }
        }

        private void Open_Buket(object sender, RoutedEventArgs e)
        {
            ButonWindow butonWindow = new ButonWindow();
            butonWindow.ShowDialog();
        }

        private void Goest_mod(object sender, RoutedEventArgs e)
        {

        }
    }
}
