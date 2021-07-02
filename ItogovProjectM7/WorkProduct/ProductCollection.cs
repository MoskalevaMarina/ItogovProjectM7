using System;
using System.Collections.Generic;
using System.Text;

namespace ItogovProjectM7.WorkProduct
{
    class ProductCollection
    {
        private Product[] collection;
        public ProductCollection(Product[] collection)
        {
            this.collection = collection;
        }

        //оператор + общая стоимость всех товаров из двух коллекций
        public static decimal operator +(ProductCollection a, ProductCollection b)
        {
            return a.Sum() + b.Sum();
        }
        //оператор + стоимость всех товаров из одной коллеции с добавлением стоимости за доставку
        public static decimal operator +(ProductCollection a, decimal b)
        {
            return a.Sum() + b;
        }

        //индексатор
        public Product this[int index]
        {
            get
            {
                if (index >= 0 && index < collection.Length)
                { return collection[index]; }
                else
                { return null; }
            }
            set
            {
                if (index >= 0 && index < collection.Length)
                { collection[index] = value; }
            }
        }

        public void Display()
        {
            foreach (var item in collection)
                Console.WriteLine($"Наименование товара:{item.Naimenovanie}, цена:{item.Price}");
        }

        public void Display(string str)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(str);
            Console.ForegroundColor = ConsoleColor.White;
            foreach (var item in collection)
                Console.WriteLine($"Наименование товара:{item.Naimenovanie}, цена:{item.Price}");
        }

        public int Kol()
        {
            return collection.Length;
        }

        public decimal Sum()
        {
            decimal s = 0;
            foreach (var item in collection)
                s = s + item.Price;
            return s;
        }

    }
}
