using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApp
{
    public class WolfCreator:Creator
    {
        public WolfCreator(string n,int w) : base(n,w)
        {
            this.Name = n;
            this.Weight = w;
        }

        public override Animal Add(string n,int w)
        {
            return new Wolf(n,w);
        }
    }
}
