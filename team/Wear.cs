using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrikersPlayerGenerator
{
    class Wear
    {
        public string wearName;
        public byte wearID;

        public void updateWear(int wearIndex)
        {
            wearName = Database.emblemNames[wearIndex];
            wearID = Convert.ToByte(wearIndex + 1);
        }
    }
}
