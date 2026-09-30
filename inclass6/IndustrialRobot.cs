using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inclass6
{
    public class IndustrialRobot : RobotPrototype
    {
        public string modelName;
        public int batteryCapacity;
        public string softwareVersion;
        public string industrialTask;

        public IndustrialRobot(string modelName, int batteryCapacity,
                               string softwareVersion, string industrialTask)
        {
            this.modelName = modelName;
            this.batteryCapacity = batteryCapacity;
            this.softwareVersion = softwareVersion;
            this.industrialTask = industrialTask;
        }

        public RobotPrototype Clone()
        {
            return new IndustrialRobot(
                modelName,
                batteryCapacity,
                softwareVersion,
                industrialTask
            );
        }
    }
}
