using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha
{
    public class Player : IPlayer
    {
        public string name { get; set; }
        public string position { get;  set; }
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Position { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Player(string name, string position)
        {
            name = name;
            position = position;
        }

        public void SetPosition(string position)
        {
            position = position;
        }
    }
}
