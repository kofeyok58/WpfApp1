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
    /// Interaction logic for Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();
        }

        private void Test(object sender, RoutedEventArgs e)
        {
            if (checkBox01.IsChecked == true & checkBox02.IsChecked == true & checkBox03.IsChecked == true & checkBox04.IsChecked == true &
                radioBtn05.IsChecked == true &
                checkBox09.IsChecked == true & checkBox010.IsChecked == false & checkBox011.IsChecked == true & checkBox012.IsChecked == false &
                radioBtn01.IsChecked == true)
            {
                MessageBox.Show("Доп тест пройден, еееее");
                Window3 window3 = new Window3();
                window3.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("нет");
            }

            
        }
    }
}
