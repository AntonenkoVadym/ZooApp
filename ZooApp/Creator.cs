using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApp
{
    public abstract class Creator
    {
        public string Name;
        public int Weight;
        public Creator(string n,int w)
        {
            Name = n;
            Weight = w;
        }
        abstract public Animal Add(string n,int w);
    }
}
