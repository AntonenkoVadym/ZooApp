using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApp
{
    public abstract class Animal:Component
    {
        public Animal(string name, int weight): base(name,weight)
        {
        }
        public abstract string AddMsg();
        public override string[] Print()
        {
            throw new NotImplementedException();
        }

        public override string SingleVoice(int num)
        {
            throw new NotImplementedException();
        }

        public override string[] Voice()
        {
            throw new NotImplementedException();
        }

        public override string[] WeightStat()
        {
            throw new NotImplementedException();
        }
        public override string AddingStaff(int i)
        {
            throw new NotImplementedException();
        }
        public override string VoiceStaff(int i)
        {
            throw new NotImplementedException();
        }
    }
}
