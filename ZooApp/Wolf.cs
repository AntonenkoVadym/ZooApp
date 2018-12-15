using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApp
{
    public class Wolf:Animal
    {
        public Wolf(string n,int w):base(n,w)
        {}
        public override string AddMsg()
        {
            return "Wolf "+name+ " added with weight "+ weight;
        }
    }
}
