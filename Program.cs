using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUT7_Question5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PlayerRecord playerRecord = new PlayerRecord();

           
            for (int i = 0; i < 4; i++)
            {
                Console.Write("Enter player name: ");
                string playerName = Console.ReadLine();
                Player player = new Player();
                player.SetPlayer(playerName.ToCharArray());
                playerRecord.addPlayer(player);
            }

            Console.WriteLine();
            Console.WriteLine("Player Information Before Sorting:");
            Console.WriteLine("Name\tGames Played\tGoals\tRating");
            Console.WriteLine("=====\t============\t=====\t======");
            for (int i = 0; i < 4; i++)
            {
                Player player = playerRecord.getPlayerAt(i);
                Console.WriteLine( player.getName() + "\t" + player.getGames() + "\t" + "\t" + player.getGoals() + "\t" + $"{player.rateplayer()} % ");
            }

         
            playerRecord.sort();

            Console.WriteLine();
            Console.WriteLine("Player Information After Sorting:");
            Console.WriteLine("Name\tGames Played\tGoals\tRating");
            Console.WriteLine("=====\t============\t=====\t======");
            for (int i = 0; i < 4; i++)
            {
                Player player = playerRecord.getPlayerAt(i);
                Console.WriteLine(player.getName() + "\t" + player.getGames() + "\t" + "\t" + player.getGoals() + "\t" + $"{player.rateplayer()} % ");
            }
            Console.ReadKey();
        }
    }
}
