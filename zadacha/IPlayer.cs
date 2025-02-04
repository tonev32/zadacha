using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha
{
    public interface IPlayer
    {
        string Name { get; set; }
        string Position { get; set; }

        public void SetPosition(string position);
    }
}
