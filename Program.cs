namespace RoboticFactory
{
    public class Program
    {
        public static void Main(String[] args)
        {
            ServiceRobot servicerobot = new ServiceRobot("ServiceRobo",100,"1.0","Serve Food");

            RobotPrototype customizedRobot = servicerobot.Clone();
            customizedRobot.batteryCapacity = 200;
            customizedRobot.softwareVersion = "1.1";

            customizedRobot.DisplayDetails();

            Console.ReadLine();

        }
    }


}


