using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tesla
{
    internal class Wheels : Model
    {
        public static string WheelManufacturer;
        public static string WheelVersion;
        public string WheelDiameter;

        public Wheels()
        {
            WheelManufacturer = "Bridgestone";
            WheelVersion = "1.0";
            WheelDiameter = "26''";
        }

        public Wheels(string wheelManufacturer, string wheelVersion, string wheelDiameter)
        {
            WheelManufacturer = wheelManufacturer;
            WheelVersion = wheelVersion;
            this.WheelDiameter = wheelDiameter;
        }
    }
}
