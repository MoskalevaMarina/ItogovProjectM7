using System;
using System.Collections.Generic;
using System.Text;

namespace ItogovProjectM7.WorkProduct
{
    static class ProductExtensions
    {
        //  метод расширения: увеличение цены на kol процентов
        public static Product GetProcent(this Product sr, decimal kol)
        { 
            return new Product(sr.Naimenovanie, sr.Price + sr.Price / 100 * kol); 
        }
    }
}
