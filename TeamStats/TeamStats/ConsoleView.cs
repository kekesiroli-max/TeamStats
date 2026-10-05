using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamStats
{
    public class ConsoleView
    {
        public void ShowPlayer(Player player)
        {
            Console.WriteLine(player.GetDescription());
        }

        public void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }

        public void ShowPlayers(List<Player> players)
        {
            Console.WriteLine(players.ForEach(x => );
        }
    }
}
