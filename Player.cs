using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUT7_Question5
{
    internal class Player
    {
        private char[] name;
        private int gamesPlayed;
        private int goals;

        public Player()
        {
            name = null;
            gamesPlayed = 0;
            goals = 0;
        }
        public void SetPlayer(char[] name)
        {
            Random random = new Random();
            this.name = name;
            gamesPlayed = random.Next(2, 21);
            goals = random.Next(1, 11);
        }
        public double rateplayer()
        {
            if (gamesPlayed > 0)
            {
                return Math.Round(((double)goals / gamesPlayed)*100, 1);
            }
            else
            {
                return 0.0;
            }

        }
        public string getName()
        {
            return new string(name);
        }
        public int getGames()
        {
            return gamesPlayed;
        }
        public int getGoals()
        {
            return goals;
        }
    }
}
