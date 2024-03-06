using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tesla
{
    internal class Engine
    {
        public string EngineType;
        public string Horsepower;
        public Engine()
        {
            EngineType = "3000AMP";
            Horsepower = "80HP";
        }

        public string EngineDetails()
        {
            return EngineType + ' ' + Horsepower;
        }
    }
}
