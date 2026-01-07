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

        public string ReturnBatteryInformation()
        {
            return $"Battery Information \nCapacity {PowerCapacityKWH} {BatteryPercentage():F2}%\nCurrent Power {CurrentPower} ";
        }

        public override string ToString()
        {
            return $"I am a {RobotName}\n {RobotName} {DescribeRobot} \n{ReturnBatteryInformation()}";
        }

        public string DescribeRobot(Enum Skill)
        {
            return $"I am a {RobotName}\n {RobotName} {Skill}  \n{ReturnBatteryInformation()}";
        }


    }

    public class HouseholdRobot : Robot
    {
        public HouseholdSkill Skill { get; set; }
        public string Description { get; set; }

        private List<HouseholdSkill> skills = new List<HouseholdSkill>
        {
            HouseholdSkill.Cleaning,
            HouseholdSkill.Cooking,
            HouseholdSkill.Laundry,
            HouseholdSkill.Gardening,
            HouseholdSkill.ChildCare
        };
        public HouseholdRobot(string robotName, string description ,double powerCapacityKWH, double currentPower, HouseholdSkill skill)
            : base(robotName, powerCapacityKWH, currentPower)
        {
            Skill = skill;
            Description = description;
        }

        public void DownloadSkill(Enum Skill)
        {

        }
        //public override string ToString()
        //{
           // return base.ToString() + $", \nSkill: {Skill}";
        //}

        //public override string DescribeRobot()
        //{
        //    return $"I am a {RobotName},\n {Description},\n Power Capacity (kWh): {PowerCapacityKWH},\n Current Power: {CurrentPower},\n Battery Percentage: {BatteryPercentage():F2}%";
       // }
    }

    public class DeliveryRobot : Robot
    {
        public DeliveryMode Mode { get; set; }
        public string Description { get; set; }

        private List<HouseholdSkill> skills = new List<HouseholdSkill>
        {
            HouseholdSkill.Cleaning,
            HouseholdSkill.Cooking,
            HouseholdSkill.Laundry,
            HouseholdSkill.Gardening,
            HouseholdSkill.ChildCare
        };
        public DeliveryRobot(string robotName, string description, double powerCapacityKWH, double currentPower, DeliveryMode mode)
            : base(robotName, powerCapacityKWH, currentPower)
        {
            Mode = mode;
            Description = description;
        }
        //public override string ToString()
        //{
        // return base.ToString() + $", \nSkill: {Skill}";
        //}

        //public override string DescribeRobot()
        //{
        //    return $"I am a {RobotName},\n {Description},\n Power Capacity (kWh): {PowerCapacityKWH},\n Current Power: {CurrentPower},\n Battery Percentage: {BatteryPercentage():F2}%";
        // }
    }





}
