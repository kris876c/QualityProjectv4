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
		public ShowOrderWin()
		{
			InitializeComponent();
			OrderRepo order = new OrderRepo();
			foreach (var item in collection)
			{

			}
			OrderDatetxtb.Text = 
		}
	}
}
