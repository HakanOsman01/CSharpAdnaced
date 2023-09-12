using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._Generic_Box_of_Integer
{
    public class Box<T>
    {
        public List<T> Items { get; set; }
        public Box()
        {
            Items = new List<T>();
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
