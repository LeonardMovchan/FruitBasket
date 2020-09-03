using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuesGame
{
    class PlayerKeeper
    {
        public static List<Player> _player = new List<Player>();

        public static void Add(Player player)
        {
            _player.Add(player);
        }

        public static void RemovePlayer(int index)
        {
            _player.RemoveAt(index);
        }

    }
}
