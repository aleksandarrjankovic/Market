using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market
{
    abstract class Market
    {
        public abstract double DiscountRate();
        public abstract double Discount();
        public abstract double TotalPurchase();
    }
}
