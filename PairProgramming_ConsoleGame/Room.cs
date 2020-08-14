using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairProgramming_ConsoleGame
{
    public class Room
    {
        public Room(int length, int width, int stairX, int stairY)
        {
            Length = length;
            Width = width;
            StairX = stairX;
            StairY = stairY;
        }
        public int Length { get; set; }
        public int Width { get; set; }
        public int StairX { get; set; }
        public int StairY { get; set; }

        public string ExitProximity(Player player)
        {
            //c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            double playerDistance = Math.Sqrt(Math.Pow(Math.Abs(StairX - player.PositionX), 2) + Math.Pow(Math.Abs(StairY - player.PositionY), 2));

            if (playerDistance <= Math.Sqrt(2))
            {
                return("You're very close!");
            }
            else if (playerDistance <= Math.Sqrt(2) * 2)
            {
                return("You're close.");
            }
            else if (playerDistance <= Math.Sqrt(2) * 4)
            {
                return("You're somewhat close.");
            }
            else
            {
                return("You're still far.");
            }
        }
    }
}
