using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList
    {
        private const int InitialCapacity = 2;
        private int[] items;

        public CustomList()
        {
            this.items = new int[InitialCapacity];
        }
        public int Count { get; private set; }
        public int this[int index]
        {
            get
            {
                this.CheckIndex(index);
                return this.items[index];
            }
            set
            {
                this.CheckIndex(index);
                this.items[index] = value;
            }
        }

        public void Add(int item)
        {
            if (this.items.Length == Count)
            {
                Resize();
            }

            this.items[Count] = item;
            Count++;

        }
        public void AddRanage(int[] array)
        {
            foreach (var item in array)
            {
                this.Add(item);
            }
        }
        public int RemoveAt(int index)
        {
            this.CheckIndex(index);
            int removeItem = this.items[index];
            this.items[index]=default(int);
            this.ShiftLeft(index);
            this.Count--;
            if (this.Count <= this.items.Length / 4)
            {
                this.Shrink();
            }
            return removeItem;

        }

        private void ShiftLeft(int index)
        {
            for (int i = index; i < this.items.Length-1; i++)
            {
                items[i] = items[i + 1];
            }
        }

        private void Resize()
        {
            int[] copy = new int[this.items.Length * 2];
            for (int i = 0; i < this.Count; i++)
            {
                copy[i] = this.items[i];
            }
            this.items = copy;
        }
        public void ForEach(Action<int> action)
        {
            for (int i = 0; i < this.Count; i++)
            {
                int currentItem = this.items[i];
                action(currentItem);
            }

        }
        private void Shrink()
        {
            int[] copy = new int[this.items.Length / 2];
            for (int i = 0; i < this.Count; i++)
            {
                copy[i] = this.items[i];
            }
            this.items = copy;
        }
        private void CheckIndex(int index)
        {
            if (index < 0 || index >= this.Count)
            {
                throw new ArgumentOutOfRangeException();
            }
        }
        public bool Contains(int element)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if (this.items[i]== element)
                {
                    return true;
                }

            }
            return false;
        }
       public void Swap(int firstIndex, int secondIndex)
       {
            this.CheckIndex(firstIndex);
            this.CheckIndex(secondIndex);
            int swap = this.items[firstIndex];
            this.items[firstIndex]= this.items[secondIndex];
            this.items[secondIndex] = swap;


       }
       public void Insert(int Index, int Item)
        {
            this.CheckIndex(Index);
            if (this.items.Length == Count)
            {
                this.Resize();
            }
            ShiftRight(Index);
            this.items[Index]=Item;
            this.Count++;
        }

        private void ShiftRight(int index)
        {
            for (int i = this.Count-1; i >= index; i++)
            {
                this.items[i + 1] = this.items[i];
            }
        }
    }
}
