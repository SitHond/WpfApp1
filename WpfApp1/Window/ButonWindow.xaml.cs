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
using System.Windows.Shapes;

namespace WpfApp1.Window
{
    /// <summary>
    /// Логика взаимодействия для ButonWindow.xaml
    /// </summary>
    public partial class ButonWindow
    {
        public ButonWindow()
        {
            InitializeComponent();
            using (var context = new MalContext())
            {
                List<Buket> bukets = context.Bukets.ToList();
                listView.ItemsSource = bukets;
            }
        }
    }
}
