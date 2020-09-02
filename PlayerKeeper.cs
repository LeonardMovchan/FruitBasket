using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuesGame
{
    class PlayerKeeper
    {
        public List<Player> _player = new List<Player>();

        public static void Add(Player player)
        {
            _player.Add(player);
        }
    }
}
