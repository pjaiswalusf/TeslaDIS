using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tesla
{
    internal class ModelType
    {
        public string Name;
        public string Year;
        public ModelType()
        {
            Name = "Model S";
            Year = "2024";


        }
        public string getModel()
        {
            return Name + ' ' + Year;
        }

    }
}
