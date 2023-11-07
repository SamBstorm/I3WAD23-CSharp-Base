using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_19_GooseGame
{
    public struct GooseGame
    {
        public Dictionary<string, int> players;
        public int lastSquare;

        public bool AddPlayer(string playerName)
        {
            //if (players is null)
            //{
            //    players = new Dictionary<string, int>();
            //}

            //OU

            //players = players ?? new Dictionary<string, int>();

            //OU

            players ??= new Dictionary<string, int>();

            if(players.ContainsKey(playerName)) return false;
            players.Add(playerName, 0);
            return true;
        }


    }

    public struct Dice
    {
        public int min;
        public int max;

        public int Roll(int nbRoll = 1)
        {
            if (nbRoll < 1) nbRoll = 1;
            Random RNG = new Random();
            int result = 0;
            for (int i = 0; i < nbRoll; i++)
            {
                //result += RNG.Next(max+1-min)+min;
                result += RNG.Next(min, max + 1);
            }
            return result;
        }
    }
}
