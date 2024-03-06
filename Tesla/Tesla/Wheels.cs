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
        public string WheelSize;
        public Wheels()
        {
            WheelManufacturer = "Bridgestone";
        }

        public string getWheelSize()
        {
            return WheelSize;
        }

        public void setWheelSize(string value)
        {
            WheelSize = value;
        }
    }
}
