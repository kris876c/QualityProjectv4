using System.Collections.Generic;
using System.Linq;
using Domain;

namespace Application
{

	public class OrderRepo
    { 
		private List<Order> orderList = new List<Order>();

		public void AddOrder(Order order)
		{
			orderList.Add(order);
		}
		
		public List<Order> GetOrderList()
		{		
			return orderList;
		}


		public Order Getorder(int orderId)
		{
			Order tempOrder = null;
			foreach (Order order in orderList)
			{
				if (order.OrderId == orderId)
				{
					tempOrder = order;
				}
			}
			return tempOrder;
		}
		public int GetCountOfOrders()
		{
			return orderList.Count();
		}
		
	}
}
