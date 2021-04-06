using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrikersPlayerGenerator
{
    class CheatCode
    {
        


        public string[] TeamNameCode(string teamname)
        {
            string[] hexString = new String[3];
            hexString[0] = "06526312 00000010";
            // 00 array, in case the name isn't long enough
            byte[] hexTeamArray = new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };
            byte[] teamNameToHex = Encoding.GetEncoding("shift_jis").GetBytes(teamname);
            var nameLength = teamNameToHex.Length;
            var limit = 0;
            if (nameLength < 16) { limit = nameLength; }
            else { limit = 16; }
            for (int i = 0; i < limit; i++)
            {
                hexTeamArray[i] = teamNameToHex[i];
            }
            Console.WriteLine(BitConverter.ToString(teamNameToHex));
            // Separate into 4 chunks of 4 bytes (because of the spacing and stuff)
            var bytechunk1 = hexTeamArray.Take(4).ToArray();
            var bytechunk2 = hexTeamArray.Skip(4).Take(4).ToArray();
            var bytechunk3 = hexTeamArray.Skip(8).Take(4).ToArray();
            var bytechunk4 = hexTeamArray.Skip(12).Take(4).ToArray();
            hexString[1] = BitConverter.ToString(bytechunk1).Replace("-", string.Empty)+" "+BitConverter.ToString(bytechunk2).Replace("-", string.Empty);
            hexString[2] = BitConverter.ToString(bytechunk3).Replace("-", string.Empty) + " "+ BitConverter.ToString(bytechunk4).Replace("-", string.Empty);
            Console.WriteLine(string.Join("\n", hexString));

            return hexString;
        }

        public string emblemCheatCode(byte emblemid)
        {
            string emblemCode = "0258d868 000000" + emblemid.ToString("X2");
            return emblemCode;

        }

        public string wearCheatCode(byte wearid)
        {
            string wearCode = "0258a05e 000000" + wearid.ToString("X2");
            return wearCode;

        }

        public string playerCheatCode(short playerid, int playerIndex)
        {
            int hexAdress = 0x58A06E;
            hexAdress += (playerIndex - 1) * 0x14;
            string playerCode = "02"+ hexAdress.ToString("X6")+" 0000"+playerid.ToString("X4");
            return playerCode;

        }
    }

}
