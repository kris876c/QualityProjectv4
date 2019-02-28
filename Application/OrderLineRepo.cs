using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Application
{
    public class OrderLineRepo
    {
        private List<SaleOrderLine> orderLineList = new List<SaleOrderLine>();
        private List<SaleOrderLine> newOrderLine;
        public void AddOrderLine(SaleOrderLine orderLine)
        {
            orderLineList.Add(orderLine);
        }

        public SaleOrderLine GetOrderLine(int orderLineId)
        {
            SaleOrderLine tempCustomer = null;
            foreach (SaleOrderLine orderLine in orderLineList)
            {
                if (orderLine.OrderLineId == orderLineId)
                {
                    tempCustomer = orderLine;
                }
            }
            return tempCustomer;
        }

        public int GetCountOfOrderLines()
        {
            return orderLineList.Count();
        }

        public List<SaleOrderLine> GetAllOrderLines(int customerID)
        {
            newOrderLine = new List<SaleOrderLine>();
            foreach (SaleOrderLine orderline in orderLineList)
            {
                if(customerID == orderline.OrderLineId)
                {
                    newOrderLine.Add(orderline);
                }
            }
            return newOrderLine;
        }
    }
}
