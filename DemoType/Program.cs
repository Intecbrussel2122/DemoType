using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            products.Add(new TV() { Id = 1, Name = "Samsung", Price = 680.50m });
            products.Add(new TV() { Id = 2, Name = "Philips", Price = 450.50m });
            products.Add(new Telephone() { Id = 3, Name = "Iphone", Price = 9900.50m });
            products.Add(new Telephone() { Id = 4, Name = "Samsung Galaxy", Price = 980.50m });
            products.Add(new Computer() { Id = 5, Name = "Asus", Price = 750.50m });
            products.Add(new Computer() { Id = 6, Name = "Dell", Price = 760.50m });

            TV tv = new TV() { Id = 5, Name = "Whatever", Price = 350.00m };
            TV tV1 = new TV();
            tV1.Id = 15;
            tV1.Name = "Atlas";
            tV1.Price = 150.00m;

            products.Add(tv);
            products.Add(tV1);


            foreach (var item in products)
            {   
                if (item is Telephone)
                {
                    Console.WriteLine(item);
                }
                
            }
        }
    }
}
