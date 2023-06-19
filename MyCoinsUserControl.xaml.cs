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
    /// Interaction logic for MyCoinsUserControl.xaml
    /// </summary>
    public partial class MyCoinsUserControl : UserControl
    {
        public MyCoinsUserControl()
        {
            InitializeComponent();
            DataGrid myList = new DataGrid();
            myList.ColumnWidth = 100;
            myList.RowBackground = System.Windows.Media.Brushes.LightGreen;
            myList.AlternatingRowBackground = System.Windows.Media.Brushes.LightBlue;
            using (MyDbContext dbContext = new MyDbContext())
            {
                myList.ItemsSource = dbContext.Coins.ToList();
                this.storeView.Children.Add(myList);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
