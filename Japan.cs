using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripPlanner
{
    public class Japan : Countries
    {
        public Japan(string Hotel, string Airlines,int dateNumber)
        {
            this.Hotel = Hotel;
            this.Airlines = Airlines;
            this.dateNumber=dateNumber;
        }

        public override double HotelPrices()
        {
            if (Hotel == "Sotetsu Grand Fresa Tokyo-Bay Ariake")
            {
                HotelPrice = 70.54;
                return HotelPrice;
            }

            else if (Hotel == "Tokyo Bay Ariake Washington Hotel")
            {
                HotelPrice = 119.99;
                return HotelPrice;
            }

            else if (Hotel == "Haneda Excel Hotel Tokyu")
            {
                HotelPrice = 65.50;
                return HotelPrice;
            }

            else
                return 0;
        }

        public override double AirPlanePrices()
        {
            if (Airlines == "EgyptAir")
            {
                AirPlanePrice = 3000 * 2;
                return AirPlanePrice;
            }

            else if (Airlines == "Air Arabia Egypt")
            {
                AirPlanePrice = 2000 * 2;
                return AirPlanePrice;
            }

            else if (Airlines == "Corendon Airlines Europe")
            {
                AirPlanePrice = 2500 * 2;
                return AirPlanePrice;
            }

            else if (Airlines == "Air Cairo")
            {
                AirPlanePrice = 3500 * 2;
                return AirPlanePrice;
            }

            else if (Airlines == "EasyJet")
            {
                AirPlanePrice = 2850 * 2;
                return AirPlanePrice;
            }

            else
                return 0;
        }
    }
}
