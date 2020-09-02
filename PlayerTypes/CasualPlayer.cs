using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GuesGame
{
  
      public class CasualPlayer
    {        
        private static string name;
        private static string type;


        public static List<int> totalNumberSheet = new List<int>();

        public string Name { get { return name; } set { name = value; } }
        public string Type { get { return type; } set { type = value; } }

        public virtual int GuessNumber()
        {
            int number;
            Random rnd = new Random();
            number = rnd.Next(40, 140);
            totalNumberSheet.Add(number);
            return number;
        }
    }
}
