using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomStack
{
    public class CustomStack
    {
        private int[] items  { get; set; }
        public int Count { get ; private set; }
        private const int InitialCapacity = 4;
        public CustomStack()
        {
            this.items = new int[InitialCapacity];
            this.Count = 0;
        }
        public void Push(int element)
        {
            
            if(this.Count == this.items.Length) 
            {
                Resize();
            }
            this.items[this.Count] = element;
            this.Count++;

        }
        public int Pop()
        {
            if (this.items.Length == 0)
            {
                throw new InvalidOperationException("Custom stack is empty");
            }
            var last = this.items[this.Count - 1];
            this.Count--;
            return last;

        }
        public int Peek()
        {
            if (this.items.Length == 0)
            {
                throw new InvalidOperationException("Custom stack is empty");
            }
            var lastElement = this.items[this.Count - 1];
            return lastElement;

        }
        public void ForEach(Action<int> action)
        {
            for (int i = this.Count-1; i >= 0; i--)
            {
                action(this.items[i]);
            }
        }
        private void Resize()
        {
            int[]copyArray=new int[this.items.Length*2];
            for (int i = 0; i < this.Count; i++)
            {
                copyArray[i] = this.items[i];
            }
            this.items = copyArray;
        }

    }
}
