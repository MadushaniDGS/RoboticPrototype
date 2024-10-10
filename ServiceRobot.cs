using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboticFactory
{
    public class ServiceRobot:RobotPrototype
    {
        public string serviceTask;
        public ServiceRobot(string modelName, int batteryCapacity, string softwareVersion, string serviceTask)
            : base(modelName, batteryCapacity, softwareVersion)
        {
            this.serviceTask = serviceTask;
        }
        public override RobotPrototype Clone()
        {
            return new ServiceRobot(this.modelName, this.batteryCapacity, this.softwareVersion, this.serviceTask);
        }

        public override void DisplayDetails()
        {
            Console.WriteLine($"Details: {modelName} {batteryCapacity} {softwareVersion} {serviceTask}");
        }
    }
}
