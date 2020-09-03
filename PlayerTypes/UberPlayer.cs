using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuesGame
{
    class UberPlayer : CasualPlayer
    {
        private static int number = 39;
        
        public static int Number { get { return number; } set { number = value; } }
        public static new int GuessNumber()
        {
            number++;
            totalNumberSheet.Add(number);
            return number;
          
        }
    }
}
