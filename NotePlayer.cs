using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuesGame
{
    class NotePlayer : Player, IGuessNumber
    {
        

        public new int GuessNumber()
        {
            int[] numbersArray = new int[100];


            Random random = new Random();
            int number = 0;
            for (int i = 0; i < numbersArray.Length -1;)
            {
                number = random.Next(40, 140);
                if (isDup(number, numbersArray))
                {
                    i++;
                    number = random.Next(40, 140);

                }
                numbersArray[i] = number;
                
            }

            totalNumberSheet.Add(number);
            return number;

        }

        bool isDup(int number, int[] numbersArray)
        {
            foreach (var item in numbersArray)
            {
                if (item == number)
                {
                    return true;
                }
            }
            return false;
        }



    }



}



