using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripPlanner
{
    public class USA : Countries
    {
        public USA(string Hotel, string Airlines,int dateNumber)
        {
            this.Hotel = Hotel;
            this.Airlines = Airlines;
            this.dateNumber = dateNumber;
        }

        public override double HotelPrices()
        {
            if (Hotel == "AVALLO POINT LODGE, SAN FRANCISCO")
            {
                HotelPrice = 139.54;
                return HotelPrice;
            }

            else if (Hotel == "MANDARIN ORIENTAL NEW YORK")
            {
                HotelPrice = 154.99;
                return HotelPrice;
            }

            else if (Hotel == "FOUR SEASONS RESORT HUALALAI, BIG ISLAND")
            {
                HotelPrice = 123.50;
                return HotelPrice;
            }

            else
                return 0;
        }

        public override double AirPlanePrices()
        {
            if (Airlines == "EgyptAir")
            {
                AirPlanePrice = 2000 * 2;
                return AirPlanePrice;
            }

            else if (Airlines == "Air Arabia Egypt")
            {
                AirPlanePrice = 1200 * 2;
                return AirPlanePrice;
            }

            else if (Airlines == "Corendon Airlines Europe")
            {
                AirPlanePrice = 2000 * 2;
                return AirPlanePrice;
            }

            else if (Airlines == "Air Cairo")
            {
                AirPlanePrice = 1800 * 2;
                return AirPlanePrice;
            }

            else if (Airlines == "EasyJet")
            {
                AirPlanePrice = 1400 * 2;
                return AirPlanePrice;
            }

            else
                return 0;
        }
    }
}
