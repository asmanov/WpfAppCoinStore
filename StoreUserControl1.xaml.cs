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
    /// Interaction logic for StoreUserControl1.xaml
    /// </summary>
    public partial class StoreUserControl1 : UserControl
    {
        public StoreUserControl1()
        {
            InitializeComponent();
            
            using (MyDbContext dbContext = new MyDbContext())
            {
                myList.ItemsSource = dbContext.Coins.ToList();
                
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = Window.GetWindow(this) as MainWindow;
            mainWindow.FirstWindow.Children.Clear();
            mainWindow.Width = 1200;
            mainWindow.Height = 800;
            MyCoinsUserControl myCoinsUserControl = new MyCoinsUserControl();
            mainWindow.FirstWindow.Children.Add(myCoinsUserControl);
        }
    }
}
