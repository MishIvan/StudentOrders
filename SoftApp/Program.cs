using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Soft[] arr = new Soft[3];
            for (int i = 0; i < 3; i++)
            {
                arr[i] = new Soft();
                Console.WriteLine("Введите наименование программного продукта:");
                string name = Console.ReadLine();

                Console.WriteLine("\r\nВведите производителя программного продукта:");
                string vendor = Console.ReadLine();

                Console.WriteLine("\r\nВведите стоимость программного продукта (0, если ПО сбоводное):");
                string spricе = Console.ReadLine();
                double price = 0.0;
                try
                {
                    price = Convert.ToDouble(spricе);
                }
                catch (Exception)
                {
                    Console.WriteLine("\r\nНеверный формат ввода цены");
                    return;
                }
                if(price < 0.0)
                {
                    Console.WriteLine("\r\nЦена не может быть отрицательной");
                    return;
                }
                Console.WriteLine("\r\n");
                arr[i].SoftName = name;
                arr[i].SoftVendor = vendor;
                arr[i].SoftPrice = price;
            }

            Console.WriteLine("Вы ввели:\r\n");
            for(int i = 0;i < 3;i++)
            {
                Console.WriteLine($"Наименование ПО: {arr[i].SoftName}, Производитель: {arr[i].SoftVendor}, " +
                    (arr[i].IsFreeSoft ? "Свободное ПО\r\n" : $"Цена: {arr[i].SoftPrice}\r\n"));
            }
            Console.WriteLine("Нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}
