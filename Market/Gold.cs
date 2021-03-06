using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market
{
    class Gold : Market
    {
        public double turnover, purchaseValue, discountRate;

        public Gold(double turnover, double purchaseValue)
        {
            this.turnover = turnover;
            this.purchaseValue = purchaseValue;
        }

        public override double DiscountRate()
        { 
            discountRate = 2;
            if (turnover >= 100 && turnover <= 800) {
                discountRate = turnover / 100 + discountRate;
            }
            else { discountRate = 10; }

            return discountRate;
        }

        public override double Discount()
        {
            return Math.Round(purchaseValue * (discountRate / 100), 2);
        }

        public override double TotalPurchase()
        {
            return purchaseValue - purchaseValue * (discountRate / 100);
        }
    }
   
}
