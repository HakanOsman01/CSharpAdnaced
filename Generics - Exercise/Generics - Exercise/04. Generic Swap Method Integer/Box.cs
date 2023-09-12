using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._Generic_Swap_Method_Integer
{
    public class Box<T>
    {
        public List<T> Items { get; set; }
        public Box()
        {
            this.Items = new List<T>();
        }
        public void AddItem(T item)
        {
            this.Items.Add(item);
        }
        public int Count { get { return this.Items.Count; } }
        public void Swap(int index1, int index2)
        {
            if (index1 < 0 || index1 >= this.Count || index2 < 0 || index2 > +this.Count)
            {
                return;
            }

            //var firstElement = this.Items[index1];
            //var secondElement = this.Items[index2];
            var swap = this.Items[index1];
            this.Items[index1] = this.Items[index2];
            this.Items[index2] = swap;


        }
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var item in Items)
            {
                stringBuilder.AppendLine($"{item.GetType()}: {item}");
            }
            return stringBuilder.ToString().TrimEnd();
        }

    }
}
