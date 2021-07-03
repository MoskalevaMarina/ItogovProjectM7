using System;
using System.Collections.Generic;
using System.Text;

namespace ItogovProjectM7.WorkPerson
{
    class Employee : Person
    {
        public string Position { get; set; }

        // реализация агрегации
        private Card<int> number;
        
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

        public void DisplayDop()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Данные о сотруднике");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"ФИО:{FIO}  Возраст:{age}  Должность:{Position}");
            number.Display();
        }

        public override void Display()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Данные о сотруднике, принявщем заказ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"ФИО:{FIO}  Возраст:{age}  Должность:{Position}");
        }

        public Employee(string name, int age, string dol, Card<int> nomerscheta) : base(name, age)
        {
            Position = dol;
            // реализация агрегации
            number = nomerscheta;
        }

    }
}
