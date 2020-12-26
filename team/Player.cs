using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrikersPlayerGenerator
{
    class Player
    {
        public string playerName;
        public short playerID;
        public void updatePlayer(int playerIndex)
        {
            playerName = Database.playerNames[playerIndex];
            playerID = Convert.ToInt16(playerIndex + 1);
        }
    }
}
