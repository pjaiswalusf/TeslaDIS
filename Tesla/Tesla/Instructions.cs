using System;
namespace Tesla
{
	public class Instructions : SafetyInstructions
	{
		public Instructions()
		{
		}

		public string seatBelt()
		{
            return "Please wear your seatbelt";
        }
        public string speedLimit()
		{
            return "Please drive under the speed limit";
        }

    }
}

