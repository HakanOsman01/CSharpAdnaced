using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace ClothesMagazine
{
    public class Magazine
    {
        //The class constructor should receive color, size and type. 
        // Type - string
        // Capacity – int
        // Clothes – List<Cloth>
        public Magazine(string type,int capacity)
        {
            Type = type;
            Capacity = capacity;
            Clothes = new List<Cloth>();
        }
        public string Type { get;set; }
        public int Capacity { get; set; }
        public List<Cloth> Clothes { get; set; }
        //Method AddCloth(Cloth cloth) – adds an entity
        //to the collection if there is room for it
        public void AddCloth(Cloth cloth)
        {
            this.Clothes.Add(cloth);
        }
        //Method RemoveCloth(string color)
        public bool RemoveCloth(string color)
        {
            for (int i = 0; i < this.Clothes.Count; i++) 
            {
                if (Clothes[i].Color== color)
                {
                    this.Clothes.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }
        // Method GetSmallestCloth() –
        public Cloth GetSmallestCloth()
        {
            int smallestCloth = int.MaxValue;
            Cloth cloth = null;
            for (int i = 0; i < Clothes.Count; i++)
            {
                int currentSize = Clothes[i].Size;
                if (smallestCloth > currentSize)
                {

                    smallestCloth = currentSize;
                    cloth = Clothes[i];
                }
            }
            return cloth;
        }
        //Method GetCloth(string color)
        public Cloth GetCloth(string color)
        {
            return this.Clothes.FirstOrDefault(c=>c.Color== color);
        }
        //Method GetClothCount()
        public int GetClothCount()
        {
            return this.Clothes.Count;
        }
        public string Report()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append($"{Type} magazine contains:");
            foreach (Cloth cloth in this.Clothes.OrderBy(c=>c.Size))
            {
                builder.Append(Environment.NewLine);
                builder.Append(cloth);
            }
           
            return builder.ToString();
        }
    }
}
