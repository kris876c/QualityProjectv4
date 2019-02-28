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
            object price = null; 
            object quantity = null; 
            string orderlineString = name + price + quantity;
            productList = productRepo.GetAllProducts(customerId);
            saleOrderLines = orderline.GetAllOrderLines(customerId);
            while(name == null)
            {
                foreach (SaleOrderLine orderline in saleOrderLines)
                {
                    if(orderline.OrderLineId )
                }
            }
            foreach (Product product in productList)
            {
                name = .Name;
            }
        }
    }
}
            



    

