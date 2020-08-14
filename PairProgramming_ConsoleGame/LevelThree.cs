using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace PairProgramming_ConsoleGame
{
    public class LevelThree
    {
        public void Run(Player playerOne)
        {
            Room levelThree = new Room(20, 20, 20, 20);
            playerOne.PositionX = 1;
            playerOne.PositionY = 11;
            EncounterEvents encounter = new EncounterEvents();

            // 80 enemies: 3 bosses, 20 hard, 27 medium, 30 easy

            // Easy:
            // Level 2 Cockroach: ("Cockroach", 2, 10, 0.9, 6, 2, 200, 2, 3, 2);
            Enemy cockroachOne = new Enemy("Cockroach", 5, 25, 0.7, 15, 2, 800, 5, 1, 1);
            Enemy cockroachTwo = new Enemy("Cockroach", 5, 25, 0.7, 15, 2, 800, 5, 15, 1);
            Enemy cockroachThree = new Enemy("Cockroach", 5, 25, 0.7, 15, 2, 800, 5, 20, 1);
            Enemy cockroachFour = new Enemy("Cockroach", 5, 25, 0.7, 15, 2, 800, 5, 4, 3);
            Enemy cockroachFive = new Enemy("Cockroach", 5, 25, 0.7, 15, 2, 800, 5, 12, 3);
            Enemy cockroachSix = new Enemy("Cockroach", 5, 25, 0.7, 15, 2, 800, 5, 17, 3);
            Enemy cockroachSeven = new Enemy("Cockroach", 5, 25, 0.7, 15, 2, 800, 5, 2, 6);
            Enemy cockroachEight = new Enemy("Cockroach", 5, 25, 0.7, 15, 2, 800, 5, 9, 6);
            Enemy cockroachNine = new Enemy("Cockroach", 5, 25, 0.7, 15, 2, 800, 5, 14, 6);
            Enemy cockroachTen = new Enemy("Cockroach", 5, 25, 0.7, 15, 2, 800, 5, 5, 9);
            // Level 2 Rat: ("Rat", 2, 14, 0.9, 10, 2, 300, 2, 3, 12);
            Enemy ratOne = new Enemy("Infernal Rat", 5, 35, 0.7, 25, 2, 1200, 5, 8, 8);
            Enemy ratTwo = new Enemy("Infernal Rat", 5, 35, 0.7, 25, 2, 1200, 5, 11, 8);
            Enemy ratThree = new Enemy("Infernal Rat", 5, 35, 0.7, 25, 2, 1200, 5, 2, 10);
            Enemy ratFour = new Enemy("Infernal Rat", 5, 35, 0.7, 25, 2, 1200, 5, 17, 10);
            Enemy ratFive = new Enemy("Infernal Rat", 5, 35, 0.7, 25, 2, 1200, 5, 19, 10);
            Enemy ratSix = new Enemy("Infernal Rat", 5, 35, 0.7, 25, 2, 1200, 5, 2, 12);
            Enemy ratSeven = new Enemy("Infernal Rat", 5, 35, 0.7, 25, 2, 1200, 5, 6, 12);
            Enemy ratEight = new Enemy("Infernal Rat", 5, 35, 0.7, 25, 2, 1200, 5, 10, 12);
            Enemy ratNine = new Enemy("Infernal Rat", 5, 35, 0.7, 25, 2, 1200, 5, 14, 12);
            Enemy ratTen = new Enemy("Infernal Rat", 5, 35, 0.7, 25, 2, 1200, 5, 19, 12);
            // Level 2 Slime: ("Slime", 2, 14, 0.9, 10, 1, 300, 2, 15, 15);
            Enemy slimeOne = new Enemy("Glowing Slime", 5, 35, 0.7, 25, 1, 1200, 5, 1, 14);
            Enemy slimeTwo = new Enemy("Glowing Slime", 5, 35, 0.7, 25, 1, 1200, 5, 4, 14);
            Enemy slimeThree = new Enemy("Glowing Slime", 5, 35, 0.7, 25, 1, 1200, 5, 8, 14);
            Enemy slimeFour = new Enemy("Glowing Slime", 5, 35, 0.7, 25, 1, 1200, 5, 16, 14);
            Enemy slimeFive = new Enemy("Glowing Slime", 5, 35, 0.7, 25, 1, 1200, 5, 20, 14);
            Enemy slimeSix = new Enemy("Glowing Slime", 5, 35, 0.7, 25, 1, 1200, 5, 1, 16);
            Enemy slimeSeven = new Enemy("Glowing Slime", 5, 35, 0.7, 25, 1, 1200, 5, 4, 16);
            Enemy slimeEight = new Enemy("Glowing Slime", 5, 35, 0.7, 25, 1, 1200, 5, 12, 16);
            Enemy slimeNine = new Enemy("Glowing Slime", 5, 35, 0.7, 25, 1, 1200, 5, 4, 19);
            Enemy slimeTen = new Enemy("Glowing Slime", 5, 35, 0.7, 25, 1, 1200, 5, 7, 19);
            // Medium:
            // Level 2 Skeleton: ("Skeleton", 4, 24, 0.8, 16, 1, 500, 4, 2, 3);
            Enemy skeletonOne = new Enemy("Smoldering Skeleton", 10, 60, 0.6, 40, 1, 2000, 10, 14, 19);
            Enemy skeletonTwo = new Enemy("Smoldering Skeleton", 10, 60, 0.6, 40, 1, 2000, 10, 18, 19);
            Enemy skeletonThree = new Enemy("Smoldering Skeleton", 10, 60, 0.6, 40, 1, 2000, 10, 1, 2);
            Enemy skeletonFour = new Enemy("Smoldering Skeleton", 10, 60, 0.6, 40, 1, 2000, 10, 13, 2);
            Enemy skeletonFive = new Enemy("Smoldering Skeleton", 10, 60, 0.6, 40, 1, 2000, 10, 2, 3);
            Enemy skeletonSix = new Enemy("Smoldering Skeleton", 10, 60, 0.6, 40, 1, 2000, 10, 6, 3);
            Enemy skeletonSeven = new Enemy("Smoldering Skeleton", 10, 60, 0.6, 40, 1, 2000, 10, 11, 3);
            Enemy skeletonEight = new Enemy("Smoldering Skeleton", 10, 60, 0.6, 40, 1, 2000, 10, 1, 5);
            Enemy skeletonNine = new Enemy("Smoldering Skeleton", 10, 60, 0.6, 40, 1, 2000, 10, 4, 5);
            // Level 2 Ghost: ("Ghost", 4, 26, 0.7, 14, 1, 500, 8, 3, 7);
            Enemy ghostOne = new Enemy("Gleaming Ghost", 10, 65, 0.5, 35, 1, 2000, 20, 13, 5);
            Enemy ghostTwo = new Enemy("Gleaming Ghost", 10, 65, 0.5, 35, 1, 2000, 20, 17, 5);
            Enemy ghostThree = new Enemy("Gleaming Ghost", 10, 65, 0.5, 35, 1, 2000, 20, 2, 8);
            Enemy ghostFour = new Enemy("Gleaming Ghost", 10, 65, 0.5, 35, 1, 2000, 20, 8, 10);
            Enemy ghostFive = new Enemy("Gleaming Ghost", 10, 65, 0.5, 35, 1, 2000, 20, 11, 8);
            Enemy ghostSix = new Enemy("Gleaming Ghost", 10, 65, 0.5, 35, 1, 2000, 20, 17, 8);
            Enemy ghostSeven = new Enemy("Gleaming Ghost", 10, 65, 0.5, 35, 1, 2000, 20, 2, 13);
            Enemy ghostEight = new Enemy("Gleaming Ghost", 10, 65, 0.5, 35, 1, 2000, 20, 7, 13);
            Enemy ghostNine = new Enemy("Gleaming Ghost", 10, 65, 0.5, 35, 1, 2000, 20, 13, 13);
            // Level 2 Witch: ("Witch", 4, 24, 0.8, 16, 1, 500, 4, 10, 14);
            Enemy witchOne = new Enemy("Blazing Witch", 10, 60, 0.6, 40, 1, 2000, 10, 2, 15);
            Enemy witchTwo = new Enemy("Blazing Witch", 10, 60, 0.6, 40, 1, 2000, 10, 8, 15);
            Enemy witchThree = new Enemy("Blazing Witch", 10, 60, 0.6, 40, 1, 2000, 10, 15, 15);
            Enemy witchFour = new Enemy("Blazing Witch", 10, 60, 0.6, 40, 1, 2000, 10, 2, 17);
            Enemy witchFive = new Enemy("Blazing Witch", 10, 60, 0.6, 40, 1, 2000, 10, 14, 17);
            Enemy witchSix = new Enemy("Blazing Witch", 10, 60, 0.6, 40, 1, 2000, 10, 19, 17);
            Enemy witchSeven = new Enemy("Blazing Witch", 10, 60, 0.6, 40, 1, 2000, 10, 20, 17);
            Enemy witchEight = new Enemy("Blazing Witch", 10, 60, 0.6, 40, 1, 2000, 10, 17, 19);
            Enemy witchNine = new Enemy("Blazing Witch", 10, 60, 0.6, 40, 1, 2000, 10, 17, 20);
            // Hard:
            // Level 2 Hard: ("Demon", 6, 34, 0.7, 26, 2, 700, 6, 9, 13);
            Enemy dragonOne = new Enemy("Dragon", 15, 85, 0.5, 65, 3, 2800, 25, 10, 6);
            Enemy dragonTwo = new Enemy("Dragon", 15, 85, 0.5, 65, 3, 2800, 25, 15, 6);
            Enemy dragonThree = new Enemy("Dragon", 15, 85, 0.5, 65, 3, 2800, 25, 9, 8);
            Enemy dragonFour = new Enemy("Dragon", 15, 85, 0.5, 65, 3, 2800, 25, 16, 8);
            Enemy dragonFive = new Enemy("Dragon", 15, 85, 0.5, 65, 3, 2800, 25, 7, 9);
            Enemy dragonSix = new Enemy("Dragon", 15, 85, 0.5, 65, 3, 2800, 25, 9, 10);
            Enemy dragonSeven = new Enemy("Dragon", 15, 85, 0.5, 65, 3, 2800, 25, 13, 10);
            Enemy dragonEight = new Enemy("Dragon", 15, 85, 0.5, 65, 3, 2800, 25, 7, 11);
            Enemy dragonNine = new Enemy("Dragon", 15, 85, 0.5, 65, 3, 2800, 25, 10, 11);
            Enemy dragonTen = new Enemy("Dragon", 15, 85, 0.5, 65, 3, 2800, 25, 15, 11);
            Enemy dragonEleven = new Enemy("Dragon", 15, 85, 0.5, 65, 3, 2800, 25, 7, 14);
            Enemy dragonTwelve = new Enemy("Dragon", 15, 85, 0.5, 65, 3, 2800, 25, 12, 14);
            Enemy dragonThirteen = new Enemy("Dragon", 15, 85, 0.5, 65, 3, 2800, 25, 15, 14);
            Enemy dragonFourteen = new Enemy("Dragon", 15, 85, 0.5, 65, 3, 2800, 25, 10, 16);
            Enemy dragonFifteen = new Enemy("Dragon", 15, 85, 0.5, 65, 3, 2800, 25, 13, 16);
            Enemy dragonSixteen = new Enemy("Dragon", 15, 85, 0.5, 65, 3, 2800, 25, 13, 18);
            Enemy dragonSeventeen = new Enemy("Dragon", 15, 85, 0.5, 65, 3, 2800, 25, 13, 19);
            Enemy dragonEighteen = new Enemy("Dragon", 15, 85, 0.5, 65, 3, 2800, 25, 16, 17);
            Enemy dragonNineteen = new Enemy("Dragon", 15, 85, 0.5, 65, 3, 2800, 25, 17, 18);
            Enemy dragonTwenty = new Enemy("Dragon", 15, 85, 0.5, 65, 3, 2800, 25, 16, 17);
            // Boss:
            // Level 2 Boss: ("", 10, 50, 0.6, 40, 2, 1000, 8, 7, 13);
            Enemy levelThreeBossOne = new Enemy("DRAGON OF DAMNATION", 30, 150, 0.5, 100, 3, 10000, 25, 19, 19);
            Enemy levelThreeBossTwo = new Enemy("DRAGON OF DAMNATION", 30, 150, 0.5, 100, 3, 10000, 25, 20, 19);
            Enemy levelThreeBossThree = new Enemy("DRAGON OF DAMNATION", 30, 150, 0.5, 100, 3, 10000, 25, 18, 20);

            List<Enemy> enemyList = new List<Enemy> { cockroachOne, cockroachTwo, cockroachThree, cockroachFour, cockroachFive, cockroachSix, cockroachSeven, cockroachEight, cockroachNine, cockroachTen, ratOne, ratTwo, ratThree, ratFour, ratFive, ratSix, ratSeven, ratEight, ratNine, ratTen, slimeOne, slimeTwo, slimeThree, slimeFour, slimeFive, slimeSix, slimeSeven, slimeEight, slimeNine, slimeTen, skeletonOne, skeletonTwo, skeletonThree, skeletonFour, skeletonFive, skeletonSix, skeletonSeven, skeletonEight, skeletonNine, ghostOne, ghostTwo, ghostThree, ghostFour, ghostFive, ghostSix, ghostSeven, ghostEight, ghostNine, witchOne, witchTwo, witchThree, witchFour, witchFive, witchSix, witchSeven, witchEight, witchNine, dragonOne, dragonTwo, dragonThree, dragonFour, dragonFive, dragonSix, dragonSeven, dragonEight, dragonNine, dragonTen, dragonEleven, dragonTwelve, dragonThirteen, dragonFourteen, dragonFifteen, dragonSixteen, dragonSeventeen, dragonEighteen, dragonNineteen, dragonTwenty, levelThreeBossOne, levelThreeBossTwo, levelThreeBossThree };


            void GamePlay()
            {
                var myPlayer = new SoundPlayer();
                myPlayer.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "\\LevelThree.wav";
                myPlayer.PlayLooping();

                Console.Clear();
                Console.WriteLine("Level Three\n" +
                    "The air shimmers past recognition...");
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
                        playerOne.Move(levelThree);
                        foreach (Enemy enemy in enemyList)
                        {
                            enemy.Move(levelThree);
                        }
                        if (playerOne.PositionX == levelThree.StairX && playerOne.PositionY == levelThree.StairY)
                        {
                            myPlayer.Stop();
                            Console.WriteLine("CONGRATULATIONS!!! YOU BEAT THE GAME!!!");
                            return;
                        }
                        foreach (Enemy enemy in enemyList)
                        {
                            if (playerOne.PositionX == enemy.PositionX && playerOne.PositionY == enemy.PositionY)
                            {
                                encounter.Encounter(playerOne, enemy);
                            }
                        }
                        Console.WriteLine(levelThree.ExitProximity(playerOne));
                    }
                }
            }

            GamePlay();
        }
    }
}
