using System;

namespace OrderManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Product[] products = new Product[5];

            products[0] = new Product(1, "Ноутбук", 450000, 5, ProductCategory.Electronics);
            products[1] = new Product(2, "Футболка", 7000, 40, ProductCategory.Clothing);
            products[2] = new Product(3, "Хлеб", 150, 100, ProductCategory.Food);
            products[3] = new Product(4, "Учебник C#", 12000, 15, ProductCategory.Books);
            products[4] = new Product(5, "Рюкзак", 18000, 12, ProductCategory.Other);

            Console.WriteLine("Список товаров:");
            Console.WriteLine();

            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine(products[i]);
            }

            Console.WriteLine();
            Console.WriteLine("Список заказов:");
            Console.WriteLine();

            Order[] orders = new Order[3];

            orders[0] = new Order(1, "Иванов Иван Иванович", products[0].Id, 1, products[0].Price * 1);
            orders[1] = new Order(2, "Петрова Анна Сергеевна", products[1].Id, 3, products[1].Price * 3);
            orders[2] = new Order(3, "Сидоров Пётр Олегович", products[3].Id, 2, products[3].Price * 2);

            for (int i = 0; i < orders.Length; i++)
            {
                orders[i].DisplayInfo();
                Console.WriteLine();
            }

            Console.WriteLine("Проверка некорректных данных:");

            try
            {
                Order badOrder = new Order(4, "Тест Тест Тестович", 1, 0, 1000);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }

            try
            {
                Order badOrder = new Order(5, "Тест Тест Тестович", 1, 2, -500);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }

            Console.ReadKey();
        }
    }
}
