using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _01._Generic_Box_of_String
{
    public class Box<T>
    {
       
        public Box() 
        {
            Items = new List<T>();
        }
        public List<T> Items { get; set; }
        public override string ToString()
        {
            StringBuilder builder= new StringBuilder();
            foreach (var item in Items)
            {
                builder.AppendLine($"{item.GetType()}: {item}");
            }
           return builder.ToString().TrimEnd();
        }

    }
}
