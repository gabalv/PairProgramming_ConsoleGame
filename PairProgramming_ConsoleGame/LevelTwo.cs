using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace PairProgramming_ConsoleGame
{
    public class LevelTwo
    {
        public void Run(Player playerOne)
        {
            playerOne.PositionX = 1;
            playerOne.PositionY = 8;
            Room levelTwo = new Room(15, 15, 8, 13);
            LevelThree levelThree = new LevelThree();
            EncounterEvents encounter = new EncounterEvents();
            // 30 enemies: 2 bosses, 6 hard, 9 medium, 13 easy

            //Level 1 Cockroach: ("Cockroach", 1, 5, 1, 3, 2, 50, 1, 2, 3);
            Enemy cockroachOne = new Enemy("Cockroach", 2, 10, 0.9, 6, 2, 200, 2, 3, 2);
            Enemy cockroachTwo = new Enemy("Cockroach", 2, 10, 0.9, 6, 2, 200, 2, 8, 2);
            Enemy cockroachThree = new Enemy("Cockroach", 2, 10, 0.9, 6, 2, 200, 2, 13, 4);
            Enemy cockroachFour = new Enemy("Cockroach", 2, 10, 0.9, 6, 2, 200, 2, 10, 7);
            Enemy cockroachFive = new Enemy("Cockroach", 2, 10, 0.9, 6, 2, 200, 2, 6, 9);
            //Level 1 Rat: ("Blood Rat", 1, 7, 1, 5, 2, 75, 1, 4, 4);
            Enemy ratOne = new Enemy("Anxious Rat", 2, 14, 0.9, 10, 2, 300, 2, 3, 12);
            Enemy ratTwo = new Enemy("Anxious Rat", 2, 14, 0.9, 10, 2, 300, 2, 5, 15);
            Enemy ratThree = new Enemy("Anxious Rat", 2, 14, 0.9, 10, 2, 300, 2, 11, 15);
            Enemy ratFour = new Enemy("Anxious Rat", 2, 14, 0.9, 10, 2, 300, 2, 1, 15);
            //Level 1 Slime: ("Crimson Slime", 1, 7, 1, 5, 1, 75, 1, 2, 9);
            Enemy slimeOne = new Enemy("Stress Slime", 2, 14, 0.9, 10, 1, 300, 2, 15, 15);
            Enemy slimeTwo = new Enemy("Stress Slime", 2, 14, 0.9, 10, 1, 300, 2, 2, 5);
            Enemy slimeThree = new Enemy("Stress Slime", 2, 14, 0.9, 10, 1, 300, 2, 2, 10);
            Enemy slimeFour = new Enemy("Stress Slime", 2, 14, 0.9, 10, 1, 300, 2, 15, 7);
            //Level 1 Skeleton: ("Marrow Skeleton", 2, 12, 0.9, 8, 1, 125, 2, 7, 8);
            Enemy skeletonOne = new Enemy("Forgotten Skeleton", 4, 24, 0.8, 16, 1, 500, 4, 2, 3);
            Enemy skeletonTwo = new Enemy("Forgotten Skeleton", 4, 24, 0.8, 16, 1, 500, 4, 6, 11);
            Enemy skeletonThree = new Enemy("Forgotten Skeleton", 4, 24, 0.8, 16, 1, 500, 4, 6, 14);
            //Level 1 Ghost: ("Hungry Ghost", 2, 13, 0.8, 7, 1, 125, 4, 6, 2);
            Enemy ghostOne = new Enemy("Hypnotic Ghost", 4, 26, 0.7, 14, 1, 500, 8, 3, 7);
            Enemy ghostTwo = new Enemy("Hypnotic Ghost", 4, 26, 0.7, 14, 1, 500, 8, 10, 4);
            Enemy ghostThree = new Enemy("Hypnotic Ghost", 4, 26, 0.7, 14, 1, 500, 8, 11, 10);
            //Level 1 Witch: ("Wilting Witch", 2, 12, 0.9, 8, 1, 125, 2, 5, 10);
            Enemy witchOne = new Enemy("Void Witch", 4, 24, 0.8, 16, 1, 500, 4, 10, 14);
            Enemy witchTwo = new Enemy("Void Witch", 4, 24, 0.8, 16, 1, 500, 4, 7, 8);
            Enemy witchThree = new Enemy("Void Witch", 4, 24, 0.8, 16, 1, 500, 4, 4, 15);
            //Level 1 Hard: ("Vampire", 3, 17, 0.8, 13, 2, 175, 3, 8, 6);
            Enemy demonOne = new Enemy("Daemon", 6, 34, 0.7, 26, 2, 700, 6, 9, 13);
            Enemy demonTwo = new Enemy("Daemon", 6, 34, 0.7, 26, 2, 700, 6, 5, 13);
            Enemy demonThree = new Enemy("Daemon", 6, 34, 0.7, 26, 2, 700, 6, 8, 10);
            Enemy demonFour = new Enemy("Daemon", 6, 34, 0.7, 26, 2, 700, 6, 6, 6);
            Enemy demonFive = new Enemy("Daemon", 6, 34, 0.7, 26, 2, 700, 6, 14, 8);
            Enemy demonSix = new Enemy("Daemon", 6, 34, 0.7, 26, 2, 700, 6, 12, 12);
            //Level 1 Boss: ("GRIGORE STRIGOI", 5, 25, 0.7, 20, 1, 250, 4, 9, 4);
            Enemy levelTwoBoss = new Enemy("DRUDENKOPF", 10, 50, 0.6, 40, 2, 1000, 8, 7, 13);
            Enemy levelTwoBossTwo = new Enemy("DRUDENKOPF", 10, 50, 0.6, 40, 2, 1000, 8, 8, 12);

            List<Enemy> enemyList = new List<Enemy> { cockroachOne, cockroachTwo, cockroachThree, cockroachFour, cockroachFive, ratOne, ratTwo, ratThree, ratFour, slimeOne, slimeTwo, slimeThree, slimeFour, skeletonOne, skeletonTwo, skeletonThree, ghostOne, ghostTwo, ghostThree, witchOne, witchTwo, witchThree, demonOne, demonTwo, demonThree, demonFour, demonFive, demonSix, levelTwoBoss, levelTwoBossTwo };


            void GamePlay()
            {
                var myPlayer = new SoundPlayer();
                myPlayer.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "\\LevelTwo.wav";
                myPlayer.PlayLooping();

                Console.Clear();
                Console.WriteLine("Level Two\n" +
                    "Something feels familiar. And unsettling...");
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
                        playerOne.Move(levelTwo);
                        foreach (Enemy enemy in enemyList)
                        {
                            enemy.Move(levelTwo);
                        }
                        if (playerOne.PositionX == levelTwo.StairX && playerOne.PositionY == levelTwo.StairY)
                        {
                            myPlayer.Stop();
                            levelThree.Run(playerOne);
                            return;
                        }
                        foreach (Enemy enemy in enemyList)
                        {
                            if (playerOne.PositionX == enemy.PositionX && playerOne.PositionY == enemy.PositionY)
                            {
                                encounter.Encounter(playerOne, enemy);
                            }
                        }
                        Console.WriteLine(levelTwo.ExitProximity(playerOne));
                    }
                }
            }

            GamePlay();
        }
    }
}
