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
		OrderRepo orderRepo = new OrderRepo();
        OrderLineRepo orderline = new OrderLineRepo();
        CustomerRepo customerRepo = new CustomerRepo();
        ProductRepo productRepo = new ProductRepo();
        private List<SaleOrderLine> saleOrderLines;
        private List<Product> productList;
        private static Controller controller;
        protected Controller()
        {
        }
        public static Controller GetController()
        {
            if (controller == null)
            {
                controller = new Controller();
            }
            return controller;
        }

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

        public string CreateOrderLine(int customerId)
        {
            string name = null;
            string price = null; 
            string quantity = null; 
            string orderlineString = null;
            productList = productRepo.GetAllProducts(customerId);
            saleOrderLines = orderline.GetAllOrderLines(customerId);
            while(orderlineString == null)
            {
                foreach (SaleOrderLine orderline in saleOrderLines)
                {
                    name = orderline.Product.Name;
                    price = orderline.Price.ToString();
                    quantity = orderline.Quantity.ToString();
                    orderlineString = name + " " + price + " " + quantity + " ";
                }
            }
            return orderlineString;
        }
		public List<Order> GetOrderList()
		{
			return orderRepo.GetOrderList();
		}
    }
}
            



    

