using System;
using System.Collections.Generic;


namespace GuesGame
{
  
      public class CasualPlayer
    {        
        //private static string name;
        //private static string type;


        public static List<int> totalNumberSheet = new List<int>();

        //public string Name { get { return name; } set { name = value; } }
        //public string Type { get { return type; } set { type = value; } }

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
