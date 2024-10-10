using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RoboticFactory
{
    public class EntertainmentRobot:RobotPrototype
    {
        public string entertainmentTask;
        public EntertainmentRobot(string modelName, int batteryCapacity, string softwareVersion, string entertainmentTask)
            : base(modelName,batteryCapacity,softwareVersion)
        {
            this.entertainmentTask = entertainmentTask;
        }
        public override RobotPrototype Clone()
        {
            return new EntertainmentRobot(this.modelName, this.batteryCapacity, this.softwareVersion, this.entertainmentTask);
        }

        public override void DisplayDetails()
        {
            Console.WriteLine($"Details : {modelName} {batteryCapacity} {softwareVersion} {entertainmentTask}");
        }
    }
}
