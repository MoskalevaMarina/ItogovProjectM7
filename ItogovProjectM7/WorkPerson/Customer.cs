using System;
using System.Collections.Generic;
using System.Text;

namespace ItogovProjectM7.WorkPerson
{
    class Customer : Person
    {
        public string telephone { get; set; }
        public string email { get; set; }

        // реализация композиции
        public Card<int> nomer;

        //переопределение свойства
        public override int Age
        {
            get { return age; }
            set
            {
                if (value > 18)
                { Console.WriteLine("Возраст должен быть > 18"); }
                else
                { age = value; }
            }
        }
        public override void Display()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Данные о заказчике");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"ФИО:{FIO}  Возраст:{age}  Телефон:{telephone}  E-mail:{email} ");
            nomer.Display();
        }
        public Customer(string name, int age, string tel, string email, int nomerscheta) : base(name, age)
        {
            telephone = tel;
            this.email = email;
            // реализация композиции
            nomer = new Card<int>(nomerscheta);
        }

    }
}
