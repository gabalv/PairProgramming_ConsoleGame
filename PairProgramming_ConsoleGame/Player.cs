using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairProgramming_ConsoleGame
{
    // Remember to have multiple dexterity options
    public class Player
    {
        public Player(int positionX, int positionY)
        {
            PositionX = positionX;
            PositionY = positionY;
        }
        private double _hp = 100;
        private int _healAmount = 20;
        private int _hpLevel = 1;
        private int _hpCap = 100;
        private double _defense = 1;
        private int _defenseLevel = 1;
        private int _strength = 5;
        private int _strengthLevel = 1;
        private int _dexterity = 1;
        private int _dexterityLevel = 1;
        private int _expThreshold = 100;
        private int totalLevel = 1;
        private bool _runAway = false;
        private bool _gameOver = false;

        public string Name { get; set; }

        public double HP
        {
            get { return _hp; }
            set { _hp = value; }
        }

        public int HealAmount
        {
            get { return _healAmount; }
            set { _healAmount = value; }
        }

        public int HPLevel
        {
            get { return _hpLevel; }
            set { _hpLevel = value; }
        }

        public int HPCap
        {
            get { return _hpCap; }
            set { _hpCap = value; }
        }

        public double Defense
        {
            get { return _defense; }
            set { _defense = value; }
        }

        public int DefenseLevel
        {
            get { return _defenseLevel; }
            set { _defenseLevel = value; }
        }

        public int Strength
        {
            get { return _strength; }
            set { _strength = value; }
        }

        public int StrengthLevel
        {
            get { return _strengthLevel; }
            set { _strengthLevel = value; }
        }

        public int Dexterity
        {
            get { return _dexterity; }
            set { _dexterity = value; }
        }

        public int DexterityLevel
        {
            get { return _dexterityLevel; }
            set { _dexterityLevel = value; }
        }

        public int XP { get; set; }

        public int ExpThreshold
        {
            get { return _expThreshold; }
            set { _expThreshold = value; }
        }

        public int TotalLevel
        {
            get { return totalLevel; }
            set { totalLevel = value; }
        }

        public int LvlUpPoints { get; set; }

        public bool RunAway
        {
            get { return _runAway; }
            set { _runAway = value; }
        }

        public int PositionX { get; set; }
        public int PositionY { get; set; }

        public bool GameOver
        {
            get { return _gameOver; }
            set { _gameOver = value; }
        }


        public void LevelUp()
        {
            while (true)
            {

                if (XP > ExpThreshold)
                {
                    LvlUpPoints++;
                    ExpThreshold *= 2;
                    Console.WriteLine("\nWhat would you like to level up?\n" +
                        "1. Health\n" +
                        "2. Defense\n" +
                        "3. Strength\n" +
                        "4. Dexterity\n");
                    ConsoleKeyInfo userInput = Console.ReadKey();
                    LevelUpSelection(userInput);
                    TotalLevel++;
                    LvlUpPoints = 0;
                }
                else
                {
                    return;
                }
            }
        }

        public bool LevelUpSelection(ConsoleKeyInfo userInput)
        {
            while (true)
            {
                Console.WriteLine("\n");
                switch (userInput.Key)
                {
                    case ConsoleKey.D1:
                        HPLevel++;
                        HPCap += 20;
                        HealAmount += 4;
                        HP = HPCap;
                        Console.WriteLine($"You leveled up Health. Your HP is now {HP}!");
                        return false;
                    case ConsoleKey.D2:
                        DefenseLevel++;
                        Defense -= .1;
                        HP = HPCap;
                        Console.WriteLine($"You leveled up Defense. Enemies now do x{Defense} damage!");
                        return false;
                    case ConsoleKey.D3:
                        StrengthLevel++;
                        Strength += 5;
                        HP = HPCap;
                        Console.WriteLine($"You leveled up Strength. You now do {Strength} damage!");
                        return false;
                    case ConsoleKey.D4:
                        DexterityLevel++;
                        Dexterity += 1;
                        HP = HPCap;
                        Console.WriteLine($"You leveled up Dexterity. You now move {Dexterity} tiles! (use step to move only one tile)");
                        return false;
                }
                Console.WriteLine("Invalid input. Try again.");
            }
        }

        public void Move(Room room)
        {
            ConsoleKeyInfo userInput = Console.ReadKey();
            Console.Clear();
            switch (userInput.Key)
            {
                case ConsoleKey.W:
                    PositionY -= Dexterity;
                    if (PositionY <= 0)
                    {
                        Console.WriteLine("You hit a wall.");
                        PositionY = 1;
                    }
                    else
                    {
                        Console.WriteLine("You move up.");
                    }
                    return;
                case ConsoleKey.D:
                    PositionX += Dexterity;
                    if (PositionX > room.Length)
                    {
                        Console.WriteLine("You hit a wall.");
                        PositionX = room.Length;
                    }
                    else
                    {
                        Console.WriteLine("You move right.");
                    }
                    return;
                case ConsoleKey.S:
                    PositionY += Dexterity;
                    if (PositionY > room.Width)
                    {
                        Console.WriteLine("You hit a wall.");
                        PositionY = room.Width;
                    }
                    else
                    {
                        Console.WriteLine("You move down.");
                    }
                    return;
                case ConsoleKey.A:
                    PositionX -= Dexterity;
                    if (PositionX <= 0)
                    {
                        Console.WriteLine("You hit a wall.");
                        PositionX = 1;
                    }
                    else
                    {
                        Console.WriteLine("You move left.");
                    }
                    return;
                case ConsoleKey.UpArrow:
                    PositionY--;
                    if (PositionY <= 0)
                    {
                        Console.WriteLine("You hit a wall.");
                        PositionY = 1;
                    }
                    else
                    {
                        Console.WriteLine("You step up.");
                    }
                    return;
                case ConsoleKey.RightArrow:
                    PositionX++;
                    if (PositionX > room.Length)
                    {
                        Console.WriteLine("You hit a wall.");
                        PositionX = room.Length;
                    }
                    else
                    {
                        Console.WriteLine("You step right.");
                    }
                    return;
                case ConsoleKey.DownArrow:
                    PositionY++;
                    if (PositionY > room.Width)
                    {
                        Console.WriteLine("You hit a wall.");
                        PositionY = room.Width;
                    }
                    else
                    {
                        Console.WriteLine("You step down.");
                    }
                    return;
                case ConsoleKey.LeftArrow:
                    PositionX--;
                    if (PositionX <= 0)
                    {
                        Console.WriteLine("You hit a wall.");
                        PositionX = 1;
                    }
                    else
                    {
                        Console.WriteLine("You step left.");
                    }
                    return;
                case ConsoleKey.M:
                    Console.WriteLine("STATS:\n\n" +
                        $"Level: {TotalLevel}\n" +
                        $"HP: {HP}\n" +
                        $"Max Health: {HPCap}\n" +
                        $"Defense: {Defense}\n" +
                        $"Strength: {Strength}\n" +
                        $"Dexterity: {Dexterity}\n" +
                        $"XP: {XP}\n");
                    return;
                case ConsoleKey.Q:
                    Console.WriteLine("Are you sure you want to quit? Y/N");
                    ConsoleKeyInfo response = Console.ReadKey();
                    switch (response.Key)
                    {
                        case ConsoleKey.Y:
                            GameOver = true;
                            Console.WriteLine("\n");
                            return;
                        case ConsoleKey.N:
                            Console.WriteLine("\n");
                            return;
                    }
                    return;
            }
        }

    }
}
