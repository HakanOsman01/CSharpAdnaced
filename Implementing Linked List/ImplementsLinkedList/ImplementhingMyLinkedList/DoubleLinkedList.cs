using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementhingMyLinkedList
{
    public class DoubleLinkedList
    {
        public int Count { get; set; }
        public LinkedListNode Head { get; set; }
        public LinkedListNode Tail { get; set; }
        public bool IsEmpty=>Count== 0;
        public void AddFirst(int element)
        {
            if (IsEmpty)
            {
                var newNode=new LinkedListNode(element);
                this.Head = newNode;
                this.Tail = newNode;
            }
            else
            {
                var oldHead = this.Head;
                var newNode = new LinkedListNode(element);
                newNode.Previos= oldHead;
                oldHead.Next= newNode;
                this.Head = newNode;
            }
            this.Count++;

        }
        public void AddLast(int element)
        {
            if (IsEmpty)
            {
                var newNode = new LinkedListNode(element);
                this.Head = newNode;
                this.Tail = newNode;
            }
            else
            {
                var oldTail = this.Tail;
                var newNode = new LinkedListNode(element);
                newNode.Next = oldTail; 
                oldTail.Previos = newNode;
                this.Tail = newNode;
            }
            this.Count++;

        }
        public void ForEach(Action<int> action)
        {
            var currentNode = this.Head;
            while (currentNode != null)
            {
                action(currentNode.Value);
                currentNode = currentNode.Previos;
            }
        }
        public class LinkedListNode
        {
            public LinkedListNode(int value)
            {
                Value = value;
            }
            public int Value { get; set; }
            public LinkedListNode Previos { get; set; }
            public LinkedListNode Next { get; set; }

        }
    }
}
