using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class.Fuel
{
    public class Q400_Fuel_lbs
    {
        //1LBS = 0,453592 KG
        //FUEL BURN IS ON LBS/HR
        //Descent @ 1800Ft/m

        #region Propierties

        private double _climbFB;
        private double _cruiseFB;
        private double _climbMin;
        private double _cruiseTime;
        private double _descentMin;
        private double _tripFuel;
        private double _toFuel;
        private double _totalFuel;

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

        private void FuelTables_lbs (int altitude)
        {

            if (altitude >= 15000 && altitude < 17000)
            {
                CruiseFB = 3070;
                ClimbFB = 633;
                ClimbMin = 8;
                DescentMin = 12;
            }

            if (altitude >= 17000 && altitude < 19000)
            {
                CruiseFB = 2950;
                ClimbFB = 680;
                ClimbMin = 9;
                DescentMin = 13;
            }

            if (altitude >= 19000 && altitude < 21000)
            {
                CruiseFB = 2800;
                ClimbFB = 815;
                ClimbMin = 12;
                DescentMin = 14;
            }

            if (altitude >= 21000 && altitude < 23000)
            {
                CruiseFB = 2650;
                ClimbFB = 896;
                ClimbMin = 14;
                DescentMin = 16;
            }

            if (altitude >= 23000 && altitude < 25000)
            {
                CruiseFB = 2450;
                ClimbFB = 971;
                ClimbMin = 18;
                DescentMin = 18;
            }

            if (altitude == 25000)
            {
                CruiseFB = 2310;
                ClimbFB = 1000;
                ClimbMin = 20;
                DescentMin = 19;
            }
        }

        #region Fuel_Calculations
        private double FuelCruise_lbs (double timeCruise)
        {
            return (timeCruise / 60) * CruiseFB;
        }
        private double DescentFuel_lbs ()
        {
            return DescentMin * 1450/60;
        }
        private double FuelTaxi_lbs (double taxiTime)
        {
            //200Lbs/15min of taxi (engine start included)
            double fuelBurn = taxiTime*15;
            return fuelBurn;
        }
        private double FuelExtra_lbs (double extraTime)
        {
            //BASED ON HOLDING AT 10000 Ft 1900LBS/HR
            return (extraTime / 60) * 1900;
        }
        private double FuelAlternate_lbs (double altDist)
        {
            //290TAS at FL10000 @ 2250lbs/hr
            return (altDist / 290) * 2250/60 ;
        }
        public void CalculateAll_lbs(int altSelected, double flightTime, double taxiTime, double contingencyFuel, double altDist, double extraFuel)
        {
            FuelTables_lbs(altSelected); //Set initial values

            CruiseTime = flightTime - (ClimbMin + DescentMin);
            if (CruiseTime < 0) CruiseTime = 0;

            TripFuel = FuelCruise_lbs(CruiseTime) + ClimbFB + DescentFuel_lbs();

            TOFuel = TripFuel + FuelExtra_lbs(contingencyFuel) + FuelAlternate_lbs(altDist) + extraFuel;

            TotalFuel = TOFuel + FuelTaxi_lbs(taxiTime);
        }
        public double CalcTripTime(int fdist, int wd, int ws, int tc, int tas)
        {
            double windComp = ws * Math.Cos((wd + 180) * Math.PI / 180);
            double trueAS = tas + windComp;
            return ((fdist / trueAS) * 60) + tc;
        }
        #endregion
    }
}
