using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboticFactory
{
    public class IndustrialRobot:RobotPrototype
    {
        public string industrialTask;
        public IndustrialRobot(string modelName, int batteryCapacity, string softwareVersion, string industrialTask)
            : base(modelName, batteryCapacity, softwareVersion)
        {
            this.industrialTask = industrialTask;
        }
        public override RobotPrototype Clone()
        {
            return new IndustrialRobot(this.modelName, this.batteryCapacity, this.softwareVersion, this.industrialTask);
        }

        public override void DisplayDetails()
        {
            Console.WriteLine($"Details: {modelName} {batteryCapacity} {softwareVersion} {industrialTask}");
        }
    }
}
