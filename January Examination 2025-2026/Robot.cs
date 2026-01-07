using January_Examination_2025_2026;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace January_Examination_2025_2026
{

    public enum HouseholdSkill { Cooking, Cleaning, Laundry, Gardening, ChildCare }
    public enum DeliveryMode { Walking, Driving, Flying }


    internal class Robot : HouseHoldRobot
    {
        public string robotName { get; set; }

        public double powerCapacityKWH { get; set; }

        public double currentPowerKWH { get; set; }

        public HouseholdSkill Skills { get; set; }

        public double GetBatteryPercentage() => (currentPowerKWH / powerCapacityKWH) * 100;

        public string DisplayBatteryInformation()
        {
            return $"{currentPowerKWH}/{powerCapacityKWH}kWh ({GetBatteryPercentage()}%)";
        }
        public override string ToString()
        {
            return $"{robotName} - {this.GetType().Name}";
        }
    }
    public class HouseHoldRobot
    { 
        public HouseholdSkill Skills { get; set; }


    }
    public class DeliveryRobot
    {
        //public Downloadskill()
        //{

        //}
        public double maxLoadKG;

    }
}

