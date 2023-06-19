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

namespace WpfAppCoinStore
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FirstWindow.Children.Clear();
            LoginUserControl loginUserControl = new LoginUserControl();
            FirstWindow.Children.Add(loginUserControl);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            FirstWindow.Children.Clear();
            SingUpUserControl singUpUserControl = new SingUpUserControl();
            FirstWindow.Children.Add(singUpUserControl);
        }
    }
}
