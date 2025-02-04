using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha
{
    public interface ITeam
    {
        string Name { get; set;  }
        IReadOnlyList<IPlayer> Players { get; set; }
        List<string> History { get; set;  }

        public void AddPlayer(IPlayer player);
        public void RemovePlayer(string playerName);
        public void AddToHistory(string message);
    }
}
