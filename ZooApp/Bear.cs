using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApp
{
    public class Bear:Animal
    {
        public Bear(string n,int w ):base(n,w){}
        public override string AddMsg()
        {
            return "Bear " + name + " added with weight " + weight;
        }
    }
}
