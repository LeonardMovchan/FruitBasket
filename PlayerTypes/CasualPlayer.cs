using System;
using System.Collections.Generic;


namespace GuesGame
{
  
      public class CasualPlayer
    {        

  
        internal static List<int> totalNumberSheet = new List<int>();
    
        public static void ClearTotalNumberSheet()
        {
            totalNumberSheet.Clear();
        }
        public static int GuessNumber()
        {
            int number;
            Random rnd = new Random();
            number = rnd.Next(40, 140);
            totalNumberSheet.Add(number);
            return number;
        }
    }
}
