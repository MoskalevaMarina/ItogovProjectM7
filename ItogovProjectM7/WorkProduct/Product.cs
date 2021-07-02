using System;
using System.Collections.Generic;
using System.Text;

namespace ItogovProjectM7.WorkProduct
{
    //класс Товар
    class Product
    {  
        //автосвойство
        public string Naimenovanie { get; set; }
        //закрытое поле
        private decimal price;
        //свойство
        public decimal Price
        {
            get { return price; }
            set
            {
                if (value < 0)
                { Console.WriteLine("Цена должна быть > 0"); }
                else
                { price = value; }
            }
        }
        //конструктор без параметров
        public Product()
        {
            Naimenovanie = "";
            price = 0;
        }
        //конструктор с параметрами
        public Product(string naimenovanie, decimal price)
        {
            Naimenovanie = naimenovanie;
            this.price = price;
        }
       
        // оператора +
        public static Product operator +(Product a, decimal b)
        {
            return new Product { Naimenovanie = a.Naimenovanie, price = a.price + b };
        }
        //оператор -
        public static Product operator -(Product a, decimal b)
        {
            decimal p;
            if (a.price - b < 0) { p = 0; Console.WriteLine("Цена была снижена до 0"); }
            else p = a.price - b;
            return new Product { Naimenovanie = a.Naimenovanie, price = p };
        }

        //метод
        public void Display(string str)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(str);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"Наименование товара:{Naimenovanie}, цена:{price}");
        }
        public void Display()
        {
            Console.WriteLine($"Наименование товара:{Naimenovanie}, цена:{price}");
        }
    }

}
