using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._Pokemon_Trainer
{
    public class Pokemon
    {
        private string name;
        private string element;
        private int health;
        public int Badges;
       // public Trainer Trainer;
        public Pokemon(string name,string element,int health)
        {
            this.Name = name;
            this.Health = health;
            this.Element = element;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Element
        {
            get { return element; }
            set { element = value; }
        }
        public int Health
        {
            get { return health; }
            set { health = value; }
        }
        public void ProcessPokemons(string element, string name,
           Dictionary<string, List<Pokemon>> trainers)
        {
            if (trainers[name].Any(p => p.Element == element))
            {
                this.Badges++;
            }
            else
            {

                trainers[name].ForEach(p => p.Health -= 10);
                trainers[name] = trainers[name].Where(p => p.Health > 0).ToList();
            }
        }
    }
}
