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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
        }

        private void Test(object sender, RoutedEventArgs e)
        {
            if (checkBox1.IsChecked == true & checkBox2.IsChecked == false & checkBox3.IsChecked == true & checkBox4.IsChecked == false
                & radioBtn6.IsChecked == true & checkBox9.IsChecked == true & checkBox10.IsChecked == false & checkBox11.IsChecked == false & checkBox12.IsChecked == true &
                radioBtn.IsChecked == true)
            {
                MessageBox.Show("Тест пройден, урааа");
                Window3 window3 = new Window3();
                window3.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Чо то не то");
            }

            
        }

        //private void MenuItem_Click(object sender, RoutedEventArgs e)
        //{
        //    Application.Current.Shutdown();
        //}
    }
}
