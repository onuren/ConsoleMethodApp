using System;
using System.Linq;

namespace ConsoleMethodApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int choise = 0;
            Functions func = new Functions();
            Product[] productArray = new Product[0];

            while (choise != 4)
            {
                Console.WriteLine("\n" +
                  "         |*******************************************|\n" +
                  "         | Lütfen yapmak istediğiniz işlemi seçiniz. |\n" +
                  "         | 1- Ürün ekle.                             |\n" +
                  "         | 2- Ürün sil.                              |\n" +
                  "         | 3- Ürünleri listele.                      |\n" +
                  "         | 4- Çıkış.                                 |\n" +
                  "         |*******************************************|\n");

                choise = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (choise)
                {
                    case 1:
                        Product[] temp = new Product[productArray.Length + 1];
                        Array.Copy(productArray, temp, productArray.Length);
                        Product p = func.AddProduct();
                        temp[temp.Length - 1] = p;
                        productArray = temp;
                        break;
                    case 2:
                        Console.WriteLine("Silinecek ürün numarasını giriniz:");
                        int numToRemove = Convert.ToInt32(Console.ReadLine());
                        productArray = productArray.Where(val => val.id != numToRemove).ToArray();
                        break;
                    case 3:
                        func.ListProducts(productArray);
                        break;

                }
            }


        }
    }
}
