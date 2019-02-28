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
using Application;

namespace UI
{
    /// <summary>
    /// Interaction logic for NewOrderWindow.xaml
    /// </summary>
    public partial class NewOrderWindow : Window
    {
        OrderLineRepo orderline = new OrderLineRepo();
        public NewOrderWindow()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }

        private void ProductList_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            int kundeNr = int.Parse(kundeNrBox.Text);
            foreach (object orderline in orderline.GetAllOrderLines)
            {

            }
            ProductList.Items.Add()
        }

    }
}
