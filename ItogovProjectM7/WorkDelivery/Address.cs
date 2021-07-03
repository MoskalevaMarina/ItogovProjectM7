using System;
using System.Collections.Generic;
using System.Text;

namespace ItogovProjectM7.WorkDelivery
{
    class Address
    {
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string NumberHouse { get; set; }

        public Address(string par1, string par2, string par3, string par4)
        {
            Country = par1;
            City = par2;
            Street = par3;
            NumberHouse = par4;
        }

        public virtual void Display()
        {
            Console.WriteLine($"Страна: {Country}  Город: {City}  Улица: {Street}  Номер дома: {NumberHouse}");
        }
    }
}
