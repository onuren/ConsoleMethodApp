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

            while (choise != 5)
            {
                Console.WriteLine("\n" +
                  "         |*******************************************|\n" +
                  "         | Lütfen yapmak istediğiniz işlemi seçiniz. |\n" +
                  "         | 1- Ürün ekle.                             |\n" +
                  "         | 2- Ürün sil.                              |\n" +
                  "         | 3- Ürünleri listele.                      |\n" +
                  "         | 4- Ürünü düzenle.                         |\n" +
                  "         | 5- Çıkış.                                 |\n" +
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
                    case 4:
                        Console.WriteLine("Düzenlenecek ürün numarasını giriniz:");
                        int numToEdit = Convert.ToInt32(Console.ReadLine());
                        int indexEdit = 0;
                        foreach (var product in productArray )
                        {  
                            if (product.id == numToEdit)
                            {
                                break;
                            }
                            indexEdit = indexEdit + 1;
                        }
                        Console.Write("|    Ürün kodunu yazınız: ");
                        productArray[indexEdit].id = Convert.ToInt32(Console.ReadLine());
                        Console.Write("|       Ürün adı giriniz: ");
                        productArray[indexEdit].name = Console.ReadLine();
                        Console.Write("|Ürünün fiyatını giriniz: ");
                        productArray[indexEdit].price = Convert.ToDouble(Console.ReadLine());
                        Console.Write("|     Ürün adedi yazınız: ");
                        productArray[indexEdit].stock = Convert.ToInt32(Console.ReadLine());
                        
                        break;
                }
            }
        }
    }
}
