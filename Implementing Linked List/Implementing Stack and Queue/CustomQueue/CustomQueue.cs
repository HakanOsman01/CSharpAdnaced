using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomQueue
{
    public class CustomQueue
    {
        private const int InitialCapacity = 4;
        private const int FirstElementIndex = 0;
        private int[] items;
        private int count;
        public CustomQueue()
        {
            items = new int[InitialCapacity];
            count = 0;
        }
        public int Count 
        {
            get { return count; }
           private set { count = value; }
        }
        public void Enqueue(int element)
        {
            Resize();
            items[this.count] = element;
            this.count++;

        }
       
        public int Dequeue()
        {
            if (this.items.Length==0)
            {
                throw new ArgumentOutOfRangeException("Empty queue");
            }
            int firstElement = this.items[FirstElementIndex];
            ShiftLeft();
            this.Count--;
            return firstElement;
        }

        private void ShiftLeft()
        {
            items[FirstElementIndex] = default;
            for (int i = 1; i < this.Count; i++)
            {
                this.items[i - 1] = this.items[i];
            }
            //items[this.items.Length-1] = default;
        }
        public int Peek()
        {
            if(this.items.Length==0)
            {
                throw new ArgumentOutOfRangeException("Empty queue");
            }
            int firstElement = this.items[FirstElementIndex];
            return firstElement;
        }
        public void Clear()
        {
            this.items= new int[InitialCapacity];
            this.Count=0;
        }
        public void ForEach(Action<int> action)
        {
            for (int i = 0; i < this.Count; i++)
            {
                action(this.items[i]);
            }
        }

        private void Resize()
        {
            if (this.items.Length == this.Count)
            {
                int[]arrayCopy= new int[this.items.Length*2];
                for (int i = 0; i < this.Count; i++)
                {
                    arrayCopy[i] = this.items[i];
                }
                this.items = arrayCopy;
            }
        }

    }
}
