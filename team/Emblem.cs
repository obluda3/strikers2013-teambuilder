using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrikersPlayerGenerator
{
    class Emblem
    {
        public string emblemName;
        public byte emblemID;

        public void updateEmblem(int emblemIndex)
        {
            emblemName = Database.emblemNames[emblemIndex];
            emblemID = Convert.ToByte(emblemIndex + 1);
        }
    }
}
