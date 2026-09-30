using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inclass6
{
    public class EntertainmentRobot : RobotPrototype
    {
        public string modelName;
        public int batteryCapacity;
        public string softwareVersion;
        public string entertainmentFeature;

        public EntertainmentRobot(string modelName, int batteryCapacity,
                                  string softwareVersion,
                                  string entertainmentFeature)
        {
            this.modelName = modelName;
            this.batteryCapacity = batteryCapacity;
            this.softwareVersion = softwareVersion;
            this.entertainmentFeature = entertainmentFeature;
        }

        public RobotPrototype Clone()
        {
            return new EntertainmentRobot(
                modelName,
                batteryCapacity,
                softwareVersion,
                entertainmentFeature
            );
        }
    }
}