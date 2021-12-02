using System;

namespace Ucu.Poo.Defense
{
    public class PromoCode : IOfferItem
    {
        public string code {get;set;}
        public int amount;

        public int SubTotal
        {
            get
            {
                return this.amount;
            }
            set
            {

                if (value > 0)
                {
                    throw new ArgumentException();
                }
                else
                {
                    this.amount = value;
                }

            }
        }

        

        public PromoCode(string PromoCode,int amount)
        {
            this.code = code;
            this.SubTotal = amount;
        }
    }
}