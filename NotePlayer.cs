using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuesGame
{
    class NotePlayer : Player
    {
        public int[] numbersArray = new int[100];


        public new int GuessNumber()
        {

            Random random = new Random();
            int number = 0;
            for (int i = 0; i < numbersArray.Length; i++)
            {
                number = random.Next(40, 140);
                if (isDup(number, numbersArray))
                {

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



