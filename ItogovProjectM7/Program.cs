using System;
using ItogovProjectM7.WorkDelivery;
using ItogovProjectM7.WorkPerson;
using ItogovProjectM7.WorkProduct;

namespace ItogovProjectM7
{
    class Program
    {
        public static void Print(string str, ConsoleColor cl)
        {
            Console.ForegroundColor = cl;
            Console.WriteLine(str);
            Console.ForegroundColor = ConsoleColor.White;

        }

        static void Main(string[] args)
        {
            //работа с классами Product и ProductCollection
            Product product1 = new Product("Вафельный торт", 8);
            product1.Display();
            product1 = product1 + 5;
            product1.Display("Увеличение цены на 5р");

            var array = new Product[] {
                new Product { Naimenovanie="Шоколадный кекс", Price=2.5m},
                new Product { Naimenovanie="Австрийские вафли", Price=15},
                new Product { Naimenovanie="Клубничный кекс", Price=7} };

            ProductCollection col = new ProductCollection(array);
            col.Display("Коллекция товаров");
            //установка цены через индексатор
            col[0].Price = 3;
            col[2] = col[2] + 5;
            col.Display($"Установка через индексатор цены товара {col[0].Naimenovanie} и {col[2].Naimenovanie}");
            col[1] = col[1].GetProcent(10);
            col.Display($"Увеличение цены товара {col[1].Naimenovanie} на 10% с использованием метода расширения");

            //работа с классами Customer, Employee,Card
            Customer user1 = new Customer("Сидоров В.В.", 20, "+375295698745", "sidorov@yandex.ru", 1234567);
            user1.nomer.SumAccount = user1.nomer.SumAccount + 850;
            user1.Display();

            Card<int> cart1 = new Card<int>(2356892);
            cart1.OpeningDate = Convert.ToDateTime("01/02/2021");
            cart1 = cart1 + 300;
            cart1.Display<string>("$");

            Employee user2 = new Employee("Петров В.В.", 30, "менеджер", cart1);
            user2.DisplayDop();

            //работа с заказом
            Print("Работа с заказом", ConsoleColor.Red);
            Address address1 = new Address("Беларусь", "Гомель", "Свиридова", "6а");
            HomeDelivery<Address> homeDelivery1 = new HomeDelivery<Address>(address1, "Вася", "+375287412583");
            decimal stoimostDostavki = 8;
            Order<int, HomeDelivery<Address>> order1 = new Order<int, HomeDelivery<Address>>(1235, homeDelivery1, col, user1, user2);
            order1.Display();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Итоговая стоимомть, с учетом доставки ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"{order1.collection + stoimostDostavki}");
        }
    }
}
