using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool IsDay;
            Console.Write("1-Day or 2-Night:");
            try
            {
                int don = Convert.ToInt32(Console.ReadLine());
                if (don == 1) { IsDay = true; }
                else { IsDay = false; }
                Console.WriteLine();
                Component Aviary = new Zoo("Aviary", 0);
                LoadAnimals(Aviary);
                while (true)
                {
                    Console.Write("\n1-All animals, 2-Voice, 3-Weight Statistics, 4-Add animal, 5-Change time of Day. Your choice: ");
                    int index = Convert.ToInt32(Console.ReadLine());
                    switch (index)
                    {
                        case 1:
                            Show(Aviary.Print());
                            break;
                        case 2:
                            if (IsDay) { Show(Aviary.Voice()); }
                            else { ChoiseAnimal(Aviary); }
                            break;
                        case 3:
                            Show(Aviary.WeightStat());
                            break;
                        case 4:
                            AddAnimal(Aviary);
                            break;
                        case 5:
                            if (IsDay) { IsDay = false; Console.WriteLine("\nNow is night"); }
                            else { IsDay = true; Console.WriteLine("\nNow is day"); }
                            break;
                    }
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("\nIncorect input");
                Console.ReadKey();
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("\nEmpty aviary");
                Console.ReadKey();
            }
        }
        public static void LoadAnimals(Component Aviary)
        {
            Creator cr = new BearCreator("Ben", 300);
            Animal animal1 = cr.Add(cr.Name, cr.Weight);
            Console.WriteLine(animal1.AddMsg().ToString());
            Aviary.Add(animal1);
            Creator cr2 = new GiraffeCreator("Buch", 300);
            Animal animal2 = cr2.Add(cr2.Name, cr2.Weight);
            Console.WriteLine(animal2.AddMsg().ToString());
            Aviary.Add(animal2);
        }
        public static void Show(string[] arr)
        {
            Console.WriteLine();
            foreach(string item in arr)
            {
                Console.WriteLine(item);
            }
        } 
        public static void ChoiseAnimal(Component Aviary)
        {
            Console.WriteLine("\nAll asleep. If you want to wack up someone choise number:");
            Show(Aviary.Print());
            Console.Write("\nEnter number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n"+Aviary.SingleVoice(num));
        }
        public static void AddAnimal(Component Aviary)
        {
            Creator cr5;
            Random rnd = new Random();
            int animalnum = rnd.Next(1, 100);
            ShowType(animalnum);
            Console.Write("Enter name: ");
            string name = Console.ReadLine();
            Console.Write("Enter weight: ");
            int weight = Convert.ToInt32(Console.ReadLine());
            if (animalnum < 40)
            {
                cr5 = new WolfCreator(name, weight);
            }
            else if(animalnum>=40 && animalnum < 80)
            {
                cr5 = new BearCreator(name, weight);
            }
            else
            {
                cr5 = new GiraffeCreator(name, weight);
            }
            Animal animal5 = cr5.Add(cr5.Name, cr5.Weight);
            Console.WriteLine(animal5.AddMsg().ToString());
            Aviary.Add(animal5);
        }
        public static void ShowType(int animalnum)
        {
            Console.Write("\nChoise name for ");
            if (animalnum < 40) {Console.WriteLine("Wolf");}
            else if (animalnum >= 40 && animalnum < 80){Console.WriteLine("Bear");}
            else{Console.WriteLine("Giraffe");}
        }
    }
    
}
