using System;
using System.Collections.Generic;


namespace GuesGame
{
  
      public class CasualPlayer
    {        
  
        public static List<int> totalNumberSheet = new List<int>();
    
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
