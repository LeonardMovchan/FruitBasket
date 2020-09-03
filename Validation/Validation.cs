using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuesGame
{
    class Validation
    {
        public static int BasketWeightValidation()
        {
            int weight;
            while (!int.TryParse(Console.ReadLine(), out weight) || weight < 40 || weight > 140)
            {
                Console.WriteLine("Please enter the wight of the basket (from 40 to 140)");
            }
            return weight;

        }
        public static int InputNumberValidation()
        {
            int number;
            while (!int.TryParse(Console.ReadLine(), out number) || number < 0)
            {
                Console.WriteLine("Please enter the number");
            }
            return number;
        }

        public static int IndexInputValidation()
        {
            int number;
            while (!int.TryParse(Console.ReadLine(), out number) || number < 0)
            {
                Console.WriteLine("Please enter the correct index");
            }

            if (number < PlayerKeeper._player.ToArray().Length)
            {
                PlayerKeeper.RemovePlayer(number);
                Console.WriteLine($"Player and index {number} was sucesffully removed from the  game");
                Console.ReadKey();
            }
            else Console.WriteLine("There is no such player index");


            return number;
        }
    }
}
