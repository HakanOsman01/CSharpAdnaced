using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomStack
{
    public class CustomStack : IEnumerable<int>
    {
        private int[]stack;
        //private const int InianialSize = 2;
        //public int CountStack { get { return stack.Coun; } }
        private int Count = 0;
       
        public void Push(int[]elements)
        {
            int[]currentStack=new int[elements.Length];
            for (int i = elements.Length - 1; i >= 0; i--)
            {
                currentStack[i] = elements[i];

            }
            this.stack = currentStack;
            
        }
        public int Pop()
        {
            if (stack.Count == 0)
            {
                throw new InvalidOperationException("No elements");
            }
            int removedElement=stack.First();
            this.stack.RemoveAt(0);
            return removedElement;
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < stack.Count; i++)
            {
                yield return stack[i];
            }
            for (int i = stack.Count - 1; i >= 0; i--)
            {
                yield return stack[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        
    }
}
