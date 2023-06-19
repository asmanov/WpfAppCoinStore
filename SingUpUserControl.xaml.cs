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
    /// Interaction logic for SingUpUserControl.xaml
    /// </summary>
    public partial class SingUpUserControl : UserControl
    {
        public SingUpUserControl()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            using(MyDbContext db = new MyDbContext())
            {
                if (!(db.Users.Any(x => x.Login == login.Text)))
                {
                    if (pas1.Password == pas2.Password)
                    {
                        db.Users.Add(new User() { Login = login.Text, Password = pas1.Password });
                        db.SaveChanges();
                    }
                    else
                    {
                        MessageBox.Show("Check password", "Check password", MessageBoxButton.OK, MessageBoxImage.Error);
                        pas1.Password = pas2.Password = "";
                    }
                }
                else
                {
                    MessageBox.Show("Login existe", "Login", MessageBoxButton.OK, MessageBoxImage.Error);
                    pas1.Password = pas2.Password = "";
                    login.Text = "";
                }
            }
            
        }
    }
}
