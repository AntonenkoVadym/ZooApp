using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApp
{
    public abstract class Component
    {
        public string name { get; private set; }
        public int weight{ get; private set; }
        public Component(string name, int weight)
        {
            this.name = name;
            this.weight = weight;
        }
        public virtual void Add(Component component) { }
        public abstract string[] Print();
        public abstract string[] Voice();
        public abstract string SingleVoice(int num);
        public abstract string[] WeightStat();
        public abstract string AddingStaff(int i);
        public abstract string VoiceStaff(int i);

    }
}
