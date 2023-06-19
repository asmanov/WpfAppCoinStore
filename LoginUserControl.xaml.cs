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
    /// Interaction logic for LoginUserControl.xaml
    /// </summary>
    public partial class LoginUserControl : UserControl
    {
        public LoginUserControl()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            using(MyDbContext db = new MyDbContext())
            {
                User user = new User();
                user.Login = login.Text;
                user.Password = pas.Password;
                if (db.Users.Any(x => x.Login == user.Login && x.Password == user.Password))
                {
                   MainWindow mainWindow = Window.GetWindow(this) as MainWindow;
                   mainWindow.FirstWindow.Children.Clear();
                   mainWindow.Width = 1200;
                   mainWindow.Height = 800;
                   StoreUserControl1 storeUserControl1 = new StoreUserControl1();
                   mainWindow.FirstWindow.Children.Add(storeUserControl1);
                }
            }
        }
    }
}
