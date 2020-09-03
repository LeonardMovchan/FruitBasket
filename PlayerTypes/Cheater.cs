using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuesGame
{
    class Cheater : CasualPlayer
    {
        public static new int GuessNumber()
        {
            Random rnd = new Random();
            int number = rnd.Next(40, 140);

            foreach (int item in totalNumberSheet.ToArray())
            {
                number = rnd.Next(40, 140);
                while (item == number)
                {
                    number = rnd.Next(40, 140);
                }


                
            }
            totalNumberSheet.Add(number);
            return number;
        }
    }
}
