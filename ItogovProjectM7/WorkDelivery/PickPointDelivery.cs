using System;
using System.Collections.Generic;
using System.Text;

namespace ItogovProjectM7.WorkDelivery
{
    //доставка в пункт выдачи
    class PickPointDelivery<TAddress> : Delivery<TAddress> where TAddress : Address
    {
        private string namePoint;
        private string telephone;
        public PickPointDelivery(TAddress address, string par5, string par6) : base(address)
        {
            namePoint = par5;
            telephone = par6;
        }
        public override void Display()
        {
            Console.WriteLine("Доставка в пункт выдачи");
            Console.WriteLine($"Наименование пункта выдачи: {namePoint} Телефон: {telephone}");
            Console.WriteLine("Адресс доставки");
            base.Display();
        }
    }

}
