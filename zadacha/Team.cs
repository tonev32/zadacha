using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha
{
    public class Team : ITeam
    {
        public string Name { get; set; }
        private List<IPlayer> players = new List<IPlayer>();
        public IReadOnlyList<IPlayer> Players => players.AsReadOnly();
        public List<string> History { get; private set; }
        string ITeam.Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        IReadOnlyList<IPlayer> ITeam.Players { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        List<string> ITeam.History { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Team(string name)
        {
            Name = name;
            History = new List<string> { $"Team {name} created at {DateTime.Now}" };
        }

        public void AddPlayer(IPlayer player)
        {
            players.Add(player);
            AddToHistory($"Player {player.Name} joined {Name} at {DateTime.Now}");
        }

        public void RemovePlayer(string playerName)
        {
            IPlayer player = Players.FirstOrDefault(p => p.Name == playerName);
            if (player != null)
            {
                players.Remove(player);
                AddToHistory($"Player {playerName} left {Name} at {DateTime.Now}");
            }
        }

        public void AddToHistory(string message)
        {
            History.Add(message);
        }
    }
}
