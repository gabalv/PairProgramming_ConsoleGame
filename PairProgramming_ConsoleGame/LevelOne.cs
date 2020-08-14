using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace PairProgramming_ConsoleGame
{
    public class LevelOne
    {
        public void Run()
        {
            EncounterEvents encounter = new EncounterEvents();
            Player playerOne = new Player(1, 6);
            Room levelOne = new Room(10, 10, 8, 3);
            LevelTwo levelTwo = new LevelTwo();
            // 10 enemies: 1 boss, 2 hard, 3 medium, 4 easy
            Enemy cockroachOne = new Enemy("Cockroach", 1, 5, 1, 3, 2, 50, 1, 2, 3);
            Enemy cockroachTwo = new Enemy("Cockroach", 1, 5, 1, 3, 2, 50, 1, 4, 8);
            Enemy rat = new Enemy("Blood Rat", 1, 7, 1, 5, 2, 75, 1, 4, 4);
            Enemy slime = new Enemy("Crimson Slime", 1, 7, 1, 5, 1, 75, 1, 2, 9);
            Enemy skeleton = new Enemy("Marrow Skeleton", 2, 12, 0.9, 8, 1, 125, 2, 7, 8);
            Enemy ghost = new Enemy("Hungry Ghost", 2, 13, 0.8, 7, 1, 125, 4, 6, 2);
            Enemy witch = new Enemy("Wilting Witch", 2, 12, 0.9, 8, 1, 125, 2, 5, 10);
            Enemy vampireOne = new Enemy("Vampire", 3, 17, 0.8, 13, 2, 175, 3, 8, 6);
            Enemy vampireTwo = new Enemy("Vampire", 3, 17, 0.8, 13, 2, 175, 3, 10, 2);
            Enemy levelOneBoss = new Enemy("GRIGORE STRIGOI", 5, 25, 0.7, 20, 1, 250, 4, 9, 4);

            List<Enemy> enemyList = new List<Enemy>() { cockroachOne, cockroachTwo, rat, slime, skeleton, ghost, witch, vampireOne, vampireTwo, levelOneBoss };


            void GamePlay()
            {
                Console.WriteLine("Welcome\n\n" +
                    "-Use WASD to move around.\n" +
                    "-Use arrow keys to step by one tile only.\n" +
                    "-Press \"M\" at any time to view your stats.\n" +
                    "-Press \"Q\" at any time to quit.\n\n\n" +
                    "Enter a name:");
                playerOne.Name = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Level One\n" +
                    "The smell of iron fills the air...");

                var myPlayer = new SoundPlayer();
                myPlayer.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "\\LevelOne.wav";
                myPlayer.PlayLooping();

                while (true)
                {
                    if (playerOne.GameOver)
                    {
                        myPlayer.Stop();
                        Console.WriteLine("\nGAME OVER");
                        return;
                    }
                    else
                    {

                        playerOne.Move(levelOne);
                        foreach (Enemy enemy in enemyList)
                        {
                            enemy.Move(levelOne);
                        }
                        if (playerOne.PositionX == levelOne.StairX && playerOne.PositionY == levelOne.StairY)
                        {
                            myPlayer.Stop();
                            levelTwo.Run(playerOne);
                            return;
                        }
                        foreach (Enemy enemy in enemyList)
                        {
                            if (playerOne.PositionX == enemy.PositionX && playerOne.PositionY == enemy.PositionY)
                            {
                                encounter.Encounter(playerOne, enemy);
                            }
                        }
                        Console.WriteLine(levelOne.ExitProximity(playerOne));
                    }
                }
            }

            GamePlay();
        }
    }
}
