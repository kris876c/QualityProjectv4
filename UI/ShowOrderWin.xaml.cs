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
	/// Interaction logic for ShowOrderWin.xaml
	/// </summary>
	public partial class ShowOrderWin : Window
	{
		OrderRepo orderrepo = new OrderRepo();
		public ShowOrderWin()
		{
			InitializeComponent();		
		
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			
			foreach (var order in Controller.GetController().GetOrderList())
			{
				OrderDatetxtb.Text += order.OrderDate+"\n";
				DeliveryDatetxtb.Text += order.DeliveryDate + "\n";
				OrderIDtxtb.Text += order.OrderId + "\n";
				CustomerIDtxtb.Text += order.Customer.ID + "\n";
				Pickedtxtb.Text += "False\n";
			}
		}

		private void Button_Click_1(object sender, RoutedEventArgs e)
		{
			MainWindow main = new MainWindow();
			main.Show();
			this.Close();
		}
	}
}
