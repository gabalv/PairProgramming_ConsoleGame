using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairProgramming_ConsoleGame
{
    class Program
    {
        static void Main(string[] args)
        {
            LevelOne levelOne = new LevelOne();
            levelOne.Run();

            Console.WriteLine("Press anything to exit game.");
            Console.ReadKey();
        }
    }
}
