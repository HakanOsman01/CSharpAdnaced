namespace _01._Apocalypse_Preparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<string, int> select=(output)=>int.Parse(output);
            Queue<int>textTile= new Queue<int>(Console.ReadLine()
             .Split().Select(select));
            Stack<int>medicaments = new Stack<int>(Console.ReadLine()
                .Split()
                .Select(select));
            Dictionary<string, int> healingItemsByResoureces = new Dictionary<string, int>()
            {
                {"Patch",0 },
                {"Bandage",0 },
                {"MedKit",0 }
            };
             
            Preparation(textTile,medicaments,healingItemsByResoureces);
            healingItemsByResoureces=healingItemsByResoureces
             .Where(item=>item.Value>0)
             .OrderByDescending(item=>item.Value)
             .ThenBy(item=>item.Key)
             .ToDictionary(x=>x.Key,x=>x.Value);
            
            if(textTile.Count==0 && medicaments.Count == 0)
            {
                Console.WriteLine("Textiles and medicaments are both empty.");
                PrintResorces(healingItemsByResoureces);

            }
           else if (textTile.Count == 0)
           {
                Console.WriteLine("Textiles are empty.");
                PrintResorces(healingItemsByResoureces);
                Console.Write("Medicaments left: ");
                Console.Write($"{string.Join(", ", medicaments)}");
               
           }
            else
            {
                Console.WriteLine("Medicaments are empty.");
                PrintResorces(healingItemsByResoureces);
                Console.Write("Textiles left: ");
                Console.Write($"{string.Join(", ", textTile)}");

            }
            
        }
        static void Preparation(Queue<int> textTile, Stack<int> medicaments, 
            Dictionary<string, int> healingItemsByResoureces)
        {
            while (textTile.Any() && medicaments.Any())
            {
                int currentTextTile = textTile.Peek();
                int currentMedicament = medicaments.Peek();
                int sum = currentTextTile + currentMedicament;
                
                if (sum ==30)
                {
                    textTile.Dequeue();
                    medicaments.Pop();
                    healingItemsByResoureces["Patch"]++;
                }
                else if (sum==40)
                {
                    textTile.Dequeue();
                    medicaments.Pop();
                    healingItemsByResoureces["Bandage"]++;
                }
                else if (sum == 100)
                {
                    textTile.Dequeue();
                    medicaments.Pop();
                    healingItemsByResoureces["MedKit"]++;
                }
                
                else if(sum>100)
                {
                    textTile.Dequeue();
                    //int value=medicaments.Peek()+10;
                    //int diffrence=sum-100;
                    int firstElement = medicaments.Pop()+10;
                    medicaments.Push(firstElement);
                    
                    
                }
                else
                {
                    textTile.Dequeue();
                    currentMedicament += 10;
                    medicaments.Pop();
                    medicaments.Pop();
                    medicaments.Push(currentMedicament);
                }

            }
        }
        static void PrintResorces(Dictionary<string, int> healingItemsByResoureces)
        {
            foreach (var kvp in healingItemsByResoureces)
            {
                Console.WriteLine($"{kvp.Key} - {kvp.Value}");
            }
        }
    }
}