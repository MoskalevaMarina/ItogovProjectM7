using System;
using System.Collections.Generic;
using System.Text;
using ItogovProjectM7.WorkDelivery;
using ItogovProjectM7.WorkPerson;
using ItogovProjectM7.WorkProduct;

namespace ItogovProjectM7
{
    //класс Заказ
    class Order<TNum, TDelivery> where TDelivery : Delivery<Address>
    {
        public TNum Number { get; set; }
        public TDelivery Delivery;
        //количество созданных заказов
        static int count = 0;

        public ProductCollection collection;

        public Customer customer;
        public Employee employee;
        public Order(TNum num, TDelivery delivery, ProductCollection collection, Customer customer, Employee employee)
        {
            Number = num;
            this.Delivery = delivery;
            this.collection = collection;
            this.customer = customer;
            this.employee = employee;
            count++;
        }
        public void Display()
        {
            Console.WriteLine($"Номер заказа: {Number}");
            customer.Display();
            employee.Display();
            Delivery.Display();
            collection.Display("Выбранные товары");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Итоговая стоимость: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"{collection.Sum()}");
        }
    }
}
