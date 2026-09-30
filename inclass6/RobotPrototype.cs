using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inclass6
{
    public class ServiceRobot : RobotPrototype
    {
        public string modelName;
        public int batteryCapacity;
        public string softwareVersion;
        public string serviceTask;

        public ServiceRobot(string modelName, int batteryCapacity,
                            string softwareVersion, string serviceTask)
        {
            this.modelName = modelName;
            this.batteryCapacity = batteryCapacity;
            this.softwareVersion = softwareVersion;
            this.serviceTask = serviceTask;
        }

        public RobotPrototype Clone()
        {
            return new ServiceRobot(
                modelName,
                batteryCapacity,
                softwareVersion,
                serviceTask
            );
        }
    }
}