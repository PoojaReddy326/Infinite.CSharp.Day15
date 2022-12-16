using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Infinite.CSharp.Day15
{
    internal class Product
    {
        private static int count;

        public int CategoryId { get; set; }
        public double Price { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }

        public Product()
        {
            count++;
            ProductId = 999 + count;
            
        }
    }

    class WishList
    {
        private List<Product> products;

        public void AddProduct(Product p)
        {
            products.Add(p);
        }

        public void DisplayProductInWishList()
        {
            foreach(Product p in products)
            {
                Console.WriteLine(p.ProductName,p.CategoryId,p.ProductId,p.Price,p.Quantity);
            }
        }
        public int GetTotalNumberOfProducts()
        {
            return products.Count;
        }

        public void InsertProduct(int index, Product p)
        {
            products.Insert(index, p);
        }

        public void RemoveProduct(int CategoryId)
        {
            bool flag = true;
            foreach (Product item in products)
            {

                if (item.ProductId == CategoryId)
                {
                    products.Remove(item);

                    flag = false;
                    break;
                }
            }
            if (flag)
            {
                Console.WriteLine("Wrong CategoryId provided.");
            }
            else
            {
                Console.WriteLine("Successfully deleted");
            }
        }
        public void RemoveProductAtIndex(int index)
        {
            bool flag = true;
            foreach (Product item in products)
            {
                
                if (item.ProductId == index)
                {
                    products.Remove(item);
                   
                    flag = false;
                    break;
                }
            }
            if(flag)
            {
                Console.WriteLine("Wrong index provided.");
            }
            else
            {
                Console.WriteLine("Successfully deleted");
            }
        }

        public WishList()
        {
            products = new List<Product>();
        }

        static void Main1(string[] args)
        {
            
        }
    }
}
