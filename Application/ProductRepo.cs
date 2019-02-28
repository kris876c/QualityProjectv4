using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Application
{
    public class ProductRepo
    {
        private List<Product> productList = new List<Product>();
        private List<Product> newProductList;
        public void AddProduct(Product product)
        {
            productList.Add(product);
        }

        public Product GetProduct(int productId)
        {
            Product tempProduct = null;
            foreach (Product product in productList)
            {
                if (product.ProductID == productId)
                {
                    tempProduct = product;
                }
            }
            return tempProduct;
        }

        public int GetCountOfProducts()
        {
            return productList.Count();
        }

        public List<Product> GetAllProducts(int customerID)
        {
            newProductList = new List<Product>();
            foreach (Product product in newProductList)
            {
                if (customerID == product.ProductID)
                {
                    newProductList.Add(product);
                }
            }
            return newProductList;
        }
    }
}
