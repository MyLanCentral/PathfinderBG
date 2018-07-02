using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathfinderRPG
{
    public abstract class Item
    {
        public string ShortName { get; protected set; }
        public string LongName { get; protected set; }
        public string Description { get; protected set; }
    }
}
