using System;
using System.Collections.Generic;
using System.Text;

namespace ItogovProjectM7.WorkDelivery
{
    //доставка в розничный магазин
    class ShopDelivery<TAddress> : Delivery<TAddress> where TAddress : Address
    {
        private string numbershop;

        public ShopDelivery(TAddress address, string par5) : base(address)
        {
            numbershop = par5;
        }
        public override void Display()
        {
            Console.WriteLine("Доставка в розничный магазин");
            Console.WriteLine($"Номер магазина для выдачи: {numbershop}");
            Console.WriteLine("Адресс");
            base.Display();
        }
    }
}
