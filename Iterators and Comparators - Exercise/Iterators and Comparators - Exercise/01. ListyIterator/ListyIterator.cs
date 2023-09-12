using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _01._ListyIterator
{
    public class ListyIterator<T> : IEnumerable<T>
    {
        private List<T> list=new List<T>();
        private int index=0;
        public ListyIterator(T[]elements)
        {
            this.list=elements.ToList();
        }
        
        public bool Move()
        {
            if (index + 1 >= list.Count)
            {
                return false;
            }
            index++;
            return true;
        } 
        public bool HasNext()
        {
            if(index == list.Count-1) 
            {
                return false;
            }
            return true;
        }
        public void Print() 
        {
           if(!list.Any())
           {
                throw new InvalidOperationException("Invalid Operation!");
           }
           Console.WriteLine(list[index]);
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i <this.list.Count; i++)
            {
                yield return list[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()=>GetEnumerator();
        
    }

}
