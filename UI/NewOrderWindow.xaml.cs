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
		
		public NewOrderWindow()
        {
            InitializeComponent();
			
        }
      

		private void CreateOrder(object sender, RoutedEventArgs e)
		{
			MainWindow main = new MainWindow();
			OrdreIDtxtb.Text = Controller.GetController().GetCountOfOrders().ToString();
			BestillingsDatotxtb.Text = DateTime.Today.ToString();
			LeveringsDatotxtb.Text = DateTime.Today.AddDays(5).ToString();

			Controller.GetController().CreateOrdre(Controller.GetController().GetCustomerByID(int.Parse(KundeIDtxtb.Text)), 
				int.Parse(OrdreIDtxtb.Text), BestillingsDatotxtb.Text, LeveringsDatotxtb.Text, false);

		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			MainWindow main = new MainWindow();
			main.Show();
			this.Close();
		}
	}
    }

