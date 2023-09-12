using System;

namespace _9._Pokemon_Trainer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Dictionary<string,List<Pokemon>>trainers=new Dictionary<string,List<Pokemon>>();
            List<Trainer>trainersAlone=new List<Trainer>();
            string command = Console.ReadLine();
            //"{trainerName} {pokemonName} {pokemonElement} {pokemonHealth}
            while (command!= "Tournament")
            {
                string[]tokens=command.Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
                string trainerName = tokens[0];
                string pokemonName = tokens[1];
                string pokemonElement= tokens[2];
                int pokemonHealth = int.Parse(tokens[3]);
                Pokemon newPokemon=new Pokemon(pokemonName, pokemonElement,pokemonHealth);
                Trainer newTrainer = new Trainer(trainerName, newPokemon);
                if(!trainers.ContainsKey(trainerName)) 
                {
                    trainers.Add(trainerName, new List<Pokemon>());
                    
                }
                trainers[trainerName].Add(newPokemon);
                trainersAlone.Add(newTrainer);
                command=Console.ReadLine();
            }
            //List<Trainer>trainersInCollection = new List<Trainer>();
            //foreach(var item in trainers)
            //{
            //    Trainer newTrainer = new Trainer(item.Key, item.Value);
            //    trainersInCollection.Add(newTrainer);
            //}
            string commandElement = Console.ReadLine();
            while(commandElement!= "End")
            {
                string elementProcess = string.Empty;
                if (commandElement == "Fire")
                {
                    elementProcess = "Fire";   
                }
                else if(commandElement == "Water")
                {
                    elementProcess = "Water";
                }
                else
                {
                    elementProcess = "Electricity";
                }
               
                foreach(var item in trainers)
                {
                    foreach (var item2 in item.Value)
                    {
                        item2.ProcessPokemons(elementProcess, item.Key, trainers);

                    }
                   
                    
                }
                
                commandElement=Console.ReadLine();
            }
           
           
            foreach(var item in trainers)

            {
                List<Pokemon> currentPokemon = item.Value;
                int badges = 0;
                foreach (var item2 in currentPokemon) 
                {
                    badges = item2.Badges;
                } 
                Console.WriteLine($"{item.Key} {badges} {currentPokemon.Count}");


            }

        }
    }
}