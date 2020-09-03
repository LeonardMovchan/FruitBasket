using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuesGame 
{
    class UberCheater : CasualPlayer
    {
        private static int number = 40;

        public static int Number { get { return number; } set { number = value; } }
        public static new int GuessNumber()
        {
                   
            int i;
            for (i = 0; i < totalNumberSheet.ToArray().Length; i++)
            {               
                while ((totalNumberSheet.Contains(number)))
                {

                    number++;
                                       
                }
                
            }
            totalNumberSheet.Add(number);
            return number;
        }
    }
}
