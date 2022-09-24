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

namespace WPF_Rassokhin_PR1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void K1(object sender, RoutedEventArgs e)
        {
            t1.Background = Brushes.White;
        }
        private void K2(object sender, RoutedEventArgs e)
        {
            t2.Background = Brushes.White;
        }
        private void K3(object sender, RoutedEventArgs e)
        {
            t3.Background = Brushes.White;
        }
        private void K4(object sender, RoutedEventArgs e)
        {
            t4.Background = Brushes.White;
        }
    }
}
