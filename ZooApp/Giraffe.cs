using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApp
{
    public class Giraffe:Animal
    {
        public Giraffe(string n,int w):base(n,w){}
        public override string AddMsg()
        {
            return "Giraffe " + name + " added with weight " + weight;
        }
    }
}
