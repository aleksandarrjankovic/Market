using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market
{
    class Silver : Market
    {
        public double turnover, purchaseValue, discountRate;

        public Silver(double turnover, double purchaseValue)
        {
            this.turnover = turnover;
            this.purchaseValue = purchaseValue;
        }

        public override double DiscountRate()
        {
            if (turnover < 300) { discountRate = 2; }
            else { discountRate = 3.5; }
           
            return discountRate;
        }

        public override double Discount()
        {
            return Math.Round(purchaseValue * (discountRate / 100),2);
        }

        public override double TotalPurchase()
        {
            return purchaseValue - purchaseValue * (discountRate / 100);
        }
    }
}
