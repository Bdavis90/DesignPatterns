using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    #region Original Class
#if false
    // Bad Code
    public class Beverage
    {
        public string description = "Unknown Beverage";
        private bool milk;
        private bool soy;
        private bool mocha;
        private bool whip;
        public virtual double Cost()
        {
            double totalCost = 0.00;
            if (milk)
            {
                totalCost += .10;
            }
            if (soy)
            {
                totalCost += .15;
            }
            if (mocha)
            {
                totalCost += .20;
            }
            if (whip)
            {
                totalCost += .10;
            }

            return totalCost;
        }
        public string GetDescription()
        {
            return description;
        }

        public bool HasMilk()
        {
            return milk;
        }
        public void SetMilk(bool milk)
        {
            this.milk = milk;
        }
        public bool HasSoy()
        {
            return soy;
        }
        public void SetSoy(bool soy)
        {
            this.soy = soy;
        }

        public bool HasMocha()
        {
            return mocha;
        }
        public void SetMocha(bool mocha)
        {
            this.mocha= mocha;
        }

        public bool HasWhip()
        {
            return whip;
        }
        public void SetWhip(bool whip)
        {
            this.whip = whip;
        }
    }
#endif

    #endregion

    public interface IBeverage
    {
        public string Description { get; set; }
        public double Cost();
        public string GetDescription();

    }

}
