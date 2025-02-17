using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha
{
    public interface IPlayer
    {
        public string Name { get; set; }
       public  string Position { get; set; }

        public void SetPosition(string position);
    }
}
