using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DndCharacterSheet.Services
{
    public static class dice
    {
        private static Random Dice { get; set; } = new Random();

        public static int d20(int amountRolls = 1)
        {
            var sum = 0;
            for (int i = 0; i < amountRolls; i++)
            {
                sum += Dice.Next(1, 20);
            }
            return sum;
        }

        public static int d12(int amountRolls = 1)
        {
            var sum = 0;
            for (int i = 0; i < amountRolls; i++)
            {
                sum += Dice.Next(1, 12);
            }
            return sum; ;
        }

        public static int d10(int amountRolls = 1)
        {
            var sum = 0;
            for (int i = 0; i < amountRolls; i++)
            {
                sum += Dice.Next(1, 10);
            }
            return sum;
        }
        public static int d8(int amountRolls = 1)
        {
            var sum = 0;
            for (int i = 0; i < amountRolls; i++)
            {
                sum += Dice.Next(1, 8);
            }
            return sum;
        }
        public static int d6(int amountRolls = 1)
        {
            var sum = 0;
            for (int i = 0; i < amountRolls; i++)
            {
                sum += Dice.Next(1, 6);
            }
            return sum;
        }
        public static int d4(int amountRolls = 1)
        {
            var sum = 0;
            for (int i = 0; i < amountRolls; i++)
            {
                sum += Dice.Next(1, 4);
            }
            return sum;
        }

        public static int rollDice(int die,int amountRolls = 1)
        {
            var sum = 0;
            for(int i =0;i<amountRolls;i++)
            {
                sum += Dice.Next(1, die);
            }
            return sum;
        }
    }
}
