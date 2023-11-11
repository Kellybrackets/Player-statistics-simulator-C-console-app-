using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUT7_Question5
{
    internal class PlayerRecord : Player
    {
        private Player[] player;
        private int counter;
        public PlayerRecord()
        {
            this.player = new Player[10];
            this.counter = 0;
        }
        public void addPlayer(Player player)
        {
            if (counter < this.player.Length)
            {
                this.player[counter] = player;
                counter++;
            }
            else
            {
                Console.WriteLine("PlayerRecord is full. Cannot add more players.");
            }

        }
        public void sort()
        {
            for (int i = 0; i < counter; i++)
            {
                for (int j = i + 1; j < counter; j++)
                {
                    if (player[i].rateplayer() < player[j].rateplayer())
                    {
                        Player temp = player[i];
                        player[i] = player[j];
                        player[j] = temp;
                    }
                }
            }
        }
        public Player getPlayerAt(int index)
        {
            if (index >= 0 && index < counter)
            {
                return player[index];
            }
            else
            {
                Console.WriteLine("Invalid index. Player not found.");
                return null;
            }
        }
    }
}
