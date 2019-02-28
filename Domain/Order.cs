using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Order
    {
        private List<SaleOrderLine> orderlines = new List<SaleOrderLine>();
        public Customer Customer { get; set; }
        public int OrderId { get; set; }
        public string OrderDate { get; set; }
        public string DeliveryDate { get; set; }
        public bool Picked { get; set; }

		public Order (Customer customer, int orderId, string orderDate, string deliveryDate, bool picked)
		{
			Customer = customer;
			OrderId = orderId;
			OrderDate = orderDate;
			DeliveryDate = deliveryDate;
			Picked = picked;
		}

        //public void AddOrderLine(Product product, int quantity, int price, int orderId)
        //{
        //    SaleOrderLine saleOrderLine = new SaleOrderLine(product, quantity, price, orderId);
        //    orderlines.Add(saleOrderLine);
        //}

        //public void RemoveOrderLines(int index)
        //{
        //    orderlines.RemoveAt(index);
        //}

        //public List<SaleOrderLine> GetOrderLines()
        //{
        //    return orderlines;
        //}
    }
}
