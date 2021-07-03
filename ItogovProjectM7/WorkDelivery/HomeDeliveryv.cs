using System;
using System.Collections.Generic;
using System.Text;

namespace ItogovProjectM7.WorkDelivery
{
    //доставка на дом
    class HomeDelivery<TAddress> : Delivery<TAddress> where TAddress : Address
    {
        private string nameCourier;
        private string telephone;
        public HomeDelivery(TAddress address, string par5, string par6) : base(address)
        {
            nameCourier = par5;
            telephone = par6;
        }
        public override void Display()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Доставка на дом");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"Ваш курьер: {nameCourier} Телефон: {telephone}");
            Console.WriteLine("Адресс доставки");
            base.Display();
        }
    }
}
