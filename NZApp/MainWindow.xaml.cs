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

namespace NZApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if (radio1.IsChecked == true)
            {
                text1.Visibility = Visibility.Visible;
                text2.Visibility = Visibility.Collapsed;
                text2.Visibility = Visibility.Collapsed;
            }
        }

        private void radio2_Checked(object sender, RoutedEventArgs e)
        {
            if (radio2.IsChecked == true)
            {
                text2.Visibility = Visibility.Visible;
                text1.Visibility = Visibility.Collapsed;
                text3.Visibility = Visibility.Collapsed;
            }
        }

        private void radio3_Checked(object sender, RoutedEventArgs e)
        {
            if (radio3.IsChecked == true)
            {
                text3.Visibility = Visibility.Visible;
                text1.Visibility = Visibility.Collapsed;
                text2.Visibility = Visibility.Collapsed;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            Window1 window1 = new Window1();
            this.Visibility = Visibility.Hidden;
            window1.Show();
        }
    }
}
