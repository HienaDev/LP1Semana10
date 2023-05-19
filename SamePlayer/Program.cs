using System;
using System.Collections;
using System.Collections.Generic;

namespace SamePlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            ICollection<Player> setOfPlayers = new HashSet<Player>();

            setOfPlayers.Add(new Player(PlayerType.Tank, "Ana"));
            setOfPlayers.Add(new Player(PlayerType.Slayer, "Paulo"));
            setOfPlayers.Add(new Player(PlayerType.Slayer, "Paulo"));
            setOfPlayers.Add(new Player(PlayerType.Slayer, "Ana"));
            setOfPlayers.Add(new Player(PlayerType.Tank, "Paulo"));
            setOfPlayers.Add(new Player(PlayerType.Tank, "Paulo"));
            setOfPlayers.Add(new Player(PlayerType.Tank, "Ana"));

            foreach (Player p in setOfPlayers)
            {
                Console.WriteLine($"{p.Name} is a {p.Type}");
            }
        }
    }
}
