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
        public static int number = 39;

        public override int GuessNumber()
        {
            number++;
            totalNumberSheet.Add(number);
            return number;
          
        }
    }
}
