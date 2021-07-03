using System;
using System.Collections.Generic;
using System.Text;

namespace ItogovProjectM7.WorkDelivery
{
    abstract class Delivery<TAddress> where TAddress : Address
    {
        protected TAddress address;
        public Delivery(TAddress address)
        {
            this.address = address;
        }
        public virtual void Display()
        {
            Console.WriteLine($"Страна: {address.Country}  Город: {address.City}  Улица: {address.Street}  Номер дома: {address.NumberHouse}");
        }
    }
}
