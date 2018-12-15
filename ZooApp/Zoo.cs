using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApp
{
    public class Zoo:Component
    {
        private List<Component> components = new List<Component>();

        public Zoo(string name,int weight): base(name,weight)
        {
        }

        public override void Add(Component component)
        {
            components.Add(component);
        }
        public override string[] Print()
        {
            string[] str = new string[components.Count];
            if (components.Count != 0)
            {
                for (int i = 0; i < components.Count; i++)
                {
                    str[i] = (i + "-" + AddingStaff(i) + " " + components[i].name + " " + components[i].weight + "kg");
                }
                return str;
            }
            else { str=new string[] { "Empty Aviary" }; return str; }
        }
        public override string[] Voice()
        {
            string[] str = new string[components.Count];
            if (components.Count != 0)
            {   
            for (int i = 0; i < components.Count; i++)
            {
                str[i]=VoiceStaff(i);
            }
            return str;
            }
            else { str = new string[] { "Empty Aviary" }; return str; }
        }
        public override string[] WeightStat()
        {
            int totalweight = 0;
            for (int i = 0; i < components.Count; i++)
            {
                totalweight+=components[i].weight;
            }
            string[] str = new string[2] {
                "Total Weight " + totalweight.ToString(),
                "Average weight " + (totalweight / components.Count)
            };
            return str;

        }
        public override string SingleVoice(int num)
        {
            string str = "";
            if (components.Count != 0)
            {
            for (int i = 0; i < components.Count; i++)
            {
                if (i == num) { str = VoiceStaff(i); }
                else { continue; }
            }
            return str;
            }
            else { str = "Empty Aviary"; return str; }
        }
        public override string VoiceStaff(int i)
        {
            const string bt = "ZooApp.Bear";
            const string gt = "ZooApp.Giraffe";
            const string wt = "ZooApp.Wolf";
            string str;
                switch (components[i].GetType().ToString())
                {
                    case bt:
                        str = "arrrrrrh - It is bear, " + components[i].name;
                        break;
                    case gt:
                        str = "hhhhhh - It is giraffe, " + components[i].name;
                        break;
                    case wt:
                        str = "uphrrr - It is wolf, " + components[i].name;
                        break;
                    default:
                        str = "No matches";
                        break;
                }
                return str;
        }
        public override string AddingStaff(int i)
        {
            const string bt = "ZooApp.Bear";
            const string gt = "ZooApp.Giraffe";
            const string wt = "ZooApp.Wolf";
            string type;
            switch (components[i].GetType().ToString())
            {
                case bt:
                    type = "Bear";
                    break;
                case gt:
                    type = "Giraffe";
                    break;
                case wt:
                    type = "Wolf";
                    break;
                default:
                    type = "No matches";
                    break;
            }
            return type;
        } 

    }
}
