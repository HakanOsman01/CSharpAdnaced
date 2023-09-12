using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06._Generic_Count_Method_Doubles
{
    public class Box<T> where T:IComparable<T>
    {
        public List<T> List { get; set; }
        public Box()
        {
            this.List = new List<T>();
        }
        public int CompareTo(T element)
        {
            int count = 0;
            foreach (var item in this.List)
            {
                int result = item.CompareTo(element);
                if (result == 1)
                {
                    ++count;

                }
            }
            return count;
        }
    }
}
