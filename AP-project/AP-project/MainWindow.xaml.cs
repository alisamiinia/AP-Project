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

namespace AP_project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static int a = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        public static void checkline()
        {
            a++;
            if (a >= 76)
            {
                
            }
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            control.SelectedIndex++;
        }

        private void Backbtn_Click(object sender, RoutedEventArgs e)
        {
            control.SelectedIndex--;
        }
    }
}
