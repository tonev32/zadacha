using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha
{
    public class Player : IPlayer
    {
        public string Name { get; private set; }
        public string Position { get; private set; }

        public Player(string name, string position)
        {
            Name = name;
            Position = position;
        }

        public void SetPosition(string position)
        {
            Position = position;
        }
    }
}
