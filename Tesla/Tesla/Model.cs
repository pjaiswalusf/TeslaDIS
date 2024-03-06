using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tesla
{
    internal class Model
    {
        public static string ModelName;
        public static string ModelVersion;
        public string ModelPrice;

        public string getModel()
        {
            return "Model Name is " + ModelName + " of version " + ModelVersion + " having price "+ ModelPrice;
        }

        public Model()
        {
            ModelName = "Model X";
            ModelVersion = "1.0";
            ModelPrice = "35000";
        }

        public Model(string modelName, string modelVersion,string modelPrice)
        {
            ModelName = modelName;
            ModelVersion = modelVersion;
            this.ModelPrice = modelPrice;
        }

        
    }
}
