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
        static int background;
        public MainWindow()
        {
            InitializeComponent();
            background = 0;
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            control.SelectedIndex++;
        }

        private void Backbtn_Click(object sender, RoutedEventArgs e)
        {
            control.SelectedIndex--;
        }

        private void Background_Click(object sender, RoutedEventArgs e)
        {
            if (background % 4 == 0)
            {
                control.Background = new LinearGradientBrush(Colors.LightBlue,Colors.White, 45);
            }
            else if (background % 4 == 1)
            {
                control.Background = new LinearGradientBrush(Colors.DarkGray , Colors.White, 45);
            }
            else if (background % 4 == 2)
            {
                control.Background = new LinearGradientBrush(Colors.SkyBlue , Colors.LightYellow, 90);
            }
            else
            {
                control.Background = Brushes.White;
            }
            background++;
        }
    }
}
