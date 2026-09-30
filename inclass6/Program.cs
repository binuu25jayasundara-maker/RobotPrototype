using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inclass6
{
    public class Program
    {
        static void Main(string[] args)
        {
            ServiceRobot robot1 = new ServiceRobot(
                "SR-01",
                10,
                "V1.0",
                "Help Patients"
            );

            ServiceRobot robot2 = (ServiceRobot)robot1.Clone();

            robot2.batteryCapacity = 15;
            robot2.softwareVersion = "V1.1";

            Console.WriteLine("Original Robot");
            Console.WriteLine(robot1.modelName);
            Console.WriteLine(robot1.batteryCapacity);
            Console.WriteLine(robot1.softwareVersion);

            Console.WriteLine();

            Console.WriteLine("Cloned Robot");
            Console.WriteLine(robot2.modelName);
            Console.WriteLine(robot2.batteryCapacity);
            Console.WriteLine(robot2.softwareVersion);
        }
    }
}
