using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tesla
{
    internal class Model
    {
        public static string ModelName;
        public static string ModelVersion;
        public int ModelPrice;
        public Model()
        {
            ModelName = "Model X";
            ModelVersion = "1.0";
            ModelPrice = 35000;
        }

        public Model(string modelName, string modelVersion,int modelPrice)
        {
            ModelName = modelName;
            ModelVersion = modelVersion;
            this.ModelPrice = modelPrice;
        }
    }
}
