using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuesGame
{
    public class Player
    {    
        public Player(string name, string type)
        {
            this.Name = name;
            this.Type = type;
        }
        public string Name { get; set; }
        public string Type { get; set; }

        public override string ToString()
        {
            return $"Players name: {this.Name}\nPlayer type: {this.Type}";
        }
    }
}
