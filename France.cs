using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripPlanner
{
    public class France : Countries
    {
        public France(string Hotel, string Airlines,int dateNumber)
        {
            this.Hotel = Hotel;
            this.Airlines = Airlines;
            this.dateNumber = dateNumber;
        }

        public override double HotelPrices()
        {
            if (Hotel == "Hôtel de l'Abbaye")
            {
                HotelPrice = 74.54;
                return HotelPrice;
            }

            else if (Hotel == "Maison Villeroy")
            {
                HotelPrice = 59.99;
                return HotelPrice;
            }

            else if (Hotel == "Hôtel La Canopée")
            {
                HotelPrice = 65.00;
                return HotelPrice;
            }

            else
                return 0;
        }

        public override double AirPlanePrices()
        {
            if (Airlines == "EgyptAir")
            {
                AirPlanePrice = 700 * 2;
                return AirPlanePrice;
            }

            else if (Airlines == "Air Arabia Egypt")
            {
                AirPlanePrice = 1000 * 2;
                return AirPlanePrice;
            }

            else if (Airlines == "Corendon Airlines Europe")
            {
                AirPlanePrice = 2000 * 2;
                return AirPlanePrice;
            }

            else if (Airlines == "Air Cairo")
            {
                AirPlanePrice = 1500 * 2;
                return AirPlanePrice;
            }

            else if (Airlines == "EasyJet")
            {
                AirPlanePrice = 850 * 2;
                return AirPlanePrice;
            }

            else
                return 0;
        }
    }
}
