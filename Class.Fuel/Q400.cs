using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class.Fuel
{
    public static class Q400
    {
        //1LBS = 0,453592 KG
        //FUEL BURN IS ON LBS/HR

        private static int FuelCruiseTables_lbs (int altitude)
        {
            int fuelBurn = 0;

            if (altitude >= 15000 && altitude < 17000)
            {
                fuelBurn = 3070;
            }

            if (altitude >= 17000 && altitude < 19000)
            {
                fuelBurn = 2950;
            }

            if (altitude >= 19000 && altitude < 21000)
            {
                fuelBurn = 2800;
            }

            if (altitude >= 21000 && altitude < 23000)
            {
                fuelBurn = 2650;
            }

            if (altitude >= 23000 && altitude < 25000)
            {
                fuelBurn = 2450;
            }

            if (altitude == 25000)
            {
                fuelBurn = 2310;
            }

            return fuelBurn;
        }
        private static int FuelCruise_lbs (int altSelected, int timeCruise)
        {
            return (timeCruise / 60) * FuelCruiseTables_lbs(altSelected);
        }
        private static int FuelTaxi_lbs (int taxiTime)
        {
            //200Lbs/15min of taxi (engine start included)
            int fuelBurn = taxiTime*15;
            return fuelBurn;
        }
        private static int FuelExtra_lbs (int extraTime)
        {
            //BASED ON HOLDING AT 10000 Ft 1700LBS/HR
            return (extraTime / 60) * 1700;
        }
        public static int TotalFuel_lbs(int altSelected, int timeCruise, int taxiTime, int extraTime)
        {
            int totalFuel = FuelCruise_lbs(altSelected, timeCruise) + FuelTaxi_lbs(taxiTime) + FuelExtra_lbs(extraTime);
            return totalFuel;
        }
    }
}
