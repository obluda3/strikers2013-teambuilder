using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrikersPlayerGenerator
{
    class InazumaTeam
    {
        public string teamName, teamAuthor, teamDescription;
        public Emblem teamEmblem = new Emblem();
        public Wear teamWear = new Wear();
        public List<Player> playerList = new List<Player>();

    }
}
