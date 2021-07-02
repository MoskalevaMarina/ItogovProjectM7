using System;
using System.Collections.Generic;
using System.Text;

namespace ItogovProjectM7.WorkPerson
{
    //класс карт-счет
    class Card<T>
    {
        private T accountNumber;
        public T AccountNumber
        {
            get { return accountNumber; }
            set { accountNumber = value; }
        }

        private DateTime openingDate;
        public DateTime OpeningDate
        {
            get { return openingDate; }
            set { openingDate = value; }
        }

        private decimal sumAccount;
        public decimal SumAccount
        {
            get { return sumAccount; }
            set { if (value >= minSum) sumAccount = value; }
        }
        
        //оператор +
        public static Card<T> operator +(Card<T> a, decimal b)
        {
            return new Card<T>(a.accountNumber, a.openingDate, a.sumAccount + b);
        }

        //оператор +
        public static Card<T> operator -(Card<T> a, decimal b)
        {
            decimal p;
            if (a.sumAccount - b < minSum) { p = minSum; Console.WriteLine("Цена была снижена до минимальной"); }
            else p = a.sumAccount - b;
            return new Card<T>(a.accountNumber, a.openingDate, p);
        }

        // статическая переменная, хранящая минимальную допустимую сумму для счета
        private static decimal minSum = 10;
        public static decimal MinSum
        {
            get { return minSum; }
            set { if (value > 0) minSum = value; }
        }

        public Card(T par1, DateTime par2, decimal par3)
        {
            accountNumber = par1;
            openingDate = par2;
            if (par3 >= minSum) sumAccount = par3;
        }

        public Card(T par1)
        {
            accountNumber = par1;
            openingDate = DateTime.Now;
            sumAccount = minSum;
        }

        public Card()
        {
            accountNumber = default(T);
            openingDate = DateTime.Now;
            sumAccount = minSum;
        }

        public void Display()
        {
            Console.WriteLine("Сведения о картсчете");
            Console.WriteLine($"Номер счета:{accountNumber}  Дата открытия счета:{openingDate}  Сумма на счете:{sumAccount} рублей");
        }

        public void Display<T>(T par1)
        {
            Console.WriteLine($"Номер счета:{accountNumber}  Дата открытия счета:{openingDate}  Сумма на счете:{sumAccount} " + par1.ToString());
        }

    }
}
