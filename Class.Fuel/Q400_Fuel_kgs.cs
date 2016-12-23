using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class.Fuel
{
    public class Q400_Fuel_kgs
    {
        #region Propierties
        private double _climbFB;
        private double _cruiseFB;
        private double _climbMin;
        private double _descentMin;
        private double _tripFuel;
        private double _toFuel;
        private double _totalFuel;
        private double _cruiseTime;

        public double CruiseTime
        {
            get { return _cruiseTime; }
            set { _cruiseTime = value; }
        }
        public double ClimbFB
        {
            get { return _climbFB; }
            set { _climbFB = value; }
        }

        public double CruiseFB
        {
            get { return _cruiseFB; }
            set { _cruiseFB = value; }
        }

        public double ClimbMin
        {
            get { return _climbMin; }
            set { _climbMin = value; }
        }

        public double DescentMin
        {
            get { return _descentMin; }
            set { _descentMin = value; }
        }

        public double TripFuel
        {
            get { return _tripFuel; }
            set { _tripFuel = value; }
        }

        public double TOFuel
        {
            get { return _toFuel; }
            set { _toFuel = value; }
        }

        public double TotalFuel
        {
            get { return _totalFuel; }
            set { _totalFuel = value; }
        }
        #endregion
        private void FuelTables_kgs(int altitude)
        {

            if (altitude >= 15000 && altitude < 17000)
            {
                CruiseFB = 3070 * 0.453592;
                ClimbFB = 633 * 0.453592;
                ClimbMin = 8;
                DescentMin = 12;
            }

            if (altitude >= 17000 && altitude < 19000)
            {
                CruiseFB = 2950 * 0.453592;
                ClimbFB = 680 * 0.453592;
                ClimbMin = 9;
                DescentMin = 13;
            }

            if (altitude >= 19000 && altitude < 21000)
            {
                CruiseFB = 2800 * 0.453592;
                ClimbFB = 815 * 0.453592;
                ClimbMin = 12;
                DescentMin = 14;
            }

            if (altitude >= 21000 && altitude < 23000)
            {
                CruiseFB = 2650 * 0.453592;
                ClimbFB = 896 * 0.453592;
                ClimbMin = 14;
                DescentMin = 16;
            }

            if (altitude >= 23000 && altitude < 25000)
            {
                CruiseFB = 2450 * 0.453592;
                ClimbFB = 971 * 0.453592;
                ClimbMin = 18;
                DescentMin = 18;
            }

            if (altitude == 25000)
            {
                CruiseFB = 2310 * 0.453592;
                ClimbFB = 1000 * 0.453592;
                ClimbMin = 20;
                DescentMin = 19;
            }
        }

        private double FuelCruise_kgs(double timeCruise)
        {
            return (timeCruise / 60) * CruiseFB;
        }

        private double DescentFuel_kgs()
        {
            return DescentMin * 1450 * 0.453592 / 60;
        }
        private double FuelTaxi_kgs(double taxiTime)
        {
            //200Lbs/15min of taxi (engine start included)
            double fuelBurn = taxiTime * 6.803;
            return fuelBurn;
        }
        private double FuelExtra_kgs(double extraTime)
        {
            //BASED ON HOLDING AT 10000 Ft 1700LBS/HR
            return (extraTime / 60) * 1900 * 0.453592;
        }
        private double FuelAlternate_kgs(double altDist)
        {
            //290TAS at FL10000 @ 2250lbs/hr
            return (altDist / 290) * 2250 * 0.453592 / 60;
        }
        public void CalculateAll_kgs(int altSelected, double flightTime, double taxiTime, double contingencyFuel, double altDist, double extraFuel)
        {
            FuelTables_kgs(altSelected); //Set initial values

            CruiseTime = flightTime - (ClimbMin + DescentMin);
            if (CruiseTime < 0) CruiseTime = 0;

            TripFuel = FuelCruise_kgs(CruiseTime) + ClimbFB + DescentFuel_kgs();

            TOFuel = TripFuel + FuelExtra_kgs(contingencyFuel) + FuelAlternate_kgs(altDist) + extraFuel;

            TotalFuel = TOFuel + FuelTaxi_kgs(taxiTime);
        }
    }
}
