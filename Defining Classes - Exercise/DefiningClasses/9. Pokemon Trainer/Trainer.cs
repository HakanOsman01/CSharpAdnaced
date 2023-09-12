using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._Pokemon_Trainer
{
    public class Trainer
    {
        private string name;
        private int badges;

        public List<Pokemon> Pokemons { set; get; }
        public Trainer(string trainerName,Pokemon pokemon)
        
        {
            this.Pokemons=new List<Pokemon>();
           //this.Pokemons.Add(pokemon);
            this.Name = trainerName;
            this.Badges = 0;
        }
       
        public string Name
        {
            get { return this.name; }
            set{this.name = value;}
        }
        public int Badges
        {
            get { return this.badges; }
            set { this.badges = value;}
        }

       

    }
}
