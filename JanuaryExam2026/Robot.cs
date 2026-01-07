using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JanuaryExam2026
{
    public abstract class Robot
    {
        public enum HouseholdSkill { Cooking, Cleaning, Laundry, Gardening, ChildCare }
        public enum DeliveryMode { Walking, Driving, Flying }
        // Properties
        public string RobotName { get; set; }
        public double PowerCapacityKWH { get; set; }
        public double CurrentPower { get; set; }

        //Constructors

        public Robot(string robotName, double powerCapacityKWH, double currentPower)
        {
            RobotName = robotName;
            PowerCapacityKWH = powerCapacityKWH;
            CurrentPower = currentPower; 
        }

        //Methods

        public double BatteryPercentage()
        {
            return (CurrentPower / PowerCapacityKWH) * 100;
        }

        public string ReturnBatteryInformation( Robot PowerCapacityKWH, double currentPower)
        {
            return $"Battery Information Capacity {PowerCapacityKWH} {BatteryPercentage():F2}% Current Power {CurrentPower} ";
        }

        public override string ToString()
        {
            return $"Robot Name: {RobotName}, Power Capacity (kWh): {PowerCapacityKWH}, Current Power: {CurrentPower}, Battery Percentage: {BatteryPercentage():F2}%";
        }

        public void DescribeRobot()
        {
            Console.WriteLine(ToString());
        }

    }
}
