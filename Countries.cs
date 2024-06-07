using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripPlanner
{
    public class Countries
    {
        public string Hotel;
        public string Airlines;
        public string ArivalDate;
        public string DepatureDate;
        public int Days;
        public double HotelPrice;
        public double AirPlanePrice;
        public int dateNumber;

        public virtual double HotelPrices()
        {
            return 0;
        }    
        public virtual double AirPlanePrices()
        {
            return 0;
        }


        public virtual double TotalPrice()
        {
            double BUDGET;
            BUDGET = AirPlanePrices() + HotelPrices()*dateNumber;

            return BUDGET;
        }
    }
}
