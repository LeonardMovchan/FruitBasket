using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuesGame
{
    class NotePlayer : CasualPlayer
    {
        public int[] payerNotes = new int[100];


        public new int GuessNumber()
        {

            Random random = new Random();
            int number = 0;
            int i;
            for (i = 0; i < payerNotes.Length; i++)
            {
                number = random.Next(40, 140);
                while(!(payerNotes.Contains(number)))
                {

                    payerNotes[i] = number;
                    i++;
                }               
            }

            totalNumberSheet.Add(number);
            return number;
        }
    }




}



