﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairProgramming_ConsoleGame
{
    public class Enemy
    {
        public Enemy(string name, int level, double hp, double defense, double strength, int dexterity, int xpGiven, int fleeThreshold, int positionX, int positionY)
        {
            Name = name;
            Level = level;
            HP = hp;
            Defense = defense;
            Strength = strength;
            Dexterity = dexterity;
            XPGiven = xpGiven;
            FleeThreshold = fleeThreshold;
            PositionX = positionX;
            PositionY = positionY;
        }
        private bool _dead = false;
        public string Name { get; set; }
        public int Level { get; set; }
        public double HP { get; set; }
        public double Defense { get; set; }
        public double Strength { get; set; }
        public int Dexterity { get; set; }
        public int XPGiven { get; set; }
        public int FleeThreshold { get; set; }
        public int PositionX { get; set; }
        public int PositionY { get; set; }
        public bool Dead
        {
            get { return _dead; }
            set { _dead = value; }
        }


        Random rand = new Random();
        public void Move(Room room)
        {
            if (!Dead)
            {
                int enemyMove = rand.Next(1, 5);
                switch (enemyMove)
                {
                    case 1:
                        PositionY -= Dexterity;
                        if (PositionY <= 0)
                        {
                            PositionY = 1;
                        }
                        return;
                    case 2:
                        PositionX += Dexterity;
                        if (PositionX > room.Length)
                        {
                            PositionX = room.Length;
                        }
                        return;
                    case 3:
                        PositionY += Dexterity;
                        if (PositionY > room.Width)
                        {
                            PositionY = room.Width;
                        }
                        return;
                    case 4:
                        PositionX -= Dexterity;
                        if (PositionX <= 0)
                        {
                            PositionX = 1;
                        }
                        return;
                }
            }
        }
    }
}
