using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Application
{
	public class Controller
	{
		private static Controller instance;
		protected Controller()
		{
		}
		public static Controller GetController()
		{
			if(instance == null)
			{
				instance = new Controller();
			}
			return instance;
		}
        CustomerRepo customerRepo = new CustomerRepo();
		OrderRepo orderRepo = new OrderRepo();
        public bool CheckCustomerID(int customerID)
        {
            if (customerRepo.GetCustomer(customerID) == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public void CreateCustomer(int id, string name, string address, string zip, string town, string telephone)
        {
            Customer customer = new Customer(id, name, address, zip, town, telephone);
            customerRepo.AddCustomer(customer);
        }
        public int GetCountOfCustomers()
        {
            return customerRepo.GetCountOfCustommers();
        }
		public string GetProducts()
		{
			return null;
		}
		public int GetCountOfOrders()
		{
			return orderRepo.GetCountOfOrders()+1;
		}
		public void CreateOrdre(Customer customer, int orderId, string orderDate, string deliveryDate, bool picked)
		{
			Order order = new Order(customer, orderId, orderDate, deliveryDate, false);
			orderRepo.AddOrder(order);
		}
		public Customer GetCustomerByID(int id)
		{
			return customerRepo.GetSpecificCustomer(id);
		}
		public List<Order> GetOrderList()
		{
			return orderRepo.GetOrderList();
		}

	}
}
