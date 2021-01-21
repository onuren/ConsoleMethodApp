using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleMethodApp
{
    class Functions
    {
        public Product AddProduct()
        {
            Product p = new Product();
            Console.Write("|    Ürün kodunu yazınız: ");
            p.id = Convert.ToInt32(Console.ReadLine());
            Console.Write("|       Ürün adı giriniz: ");
            p.name = Console.ReadLine();
            Console.Write("|Ürünün fiyatını giriniz: ");
            p.price = Convert.ToDouble(Console.ReadLine());
            Console.Write("|     Ürün adedi yazınız: ");
            p.stock = Convert.ToInt32(Console.ReadLine());

            return p;
        }
        public void ListProducts(Product[] p)
        {
            foreach (var pro in p)
            {
                Console.WriteLine(pro.id);
                Console.WriteLine(pro.name);
                Console.WriteLine(pro.price+" TL");
                Console.WriteLine(pro.stock+" ADT");
                Console.WriteLine("***********************************");
            }
        }
    }

    class Product
    {
        public int id { get; set; }
        public string name { get; set; }
        public double price { get; set; }
        public int stock { get; set; }
    }
}
