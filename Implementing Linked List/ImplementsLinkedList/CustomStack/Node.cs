using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomStack
{
    public class Node<T>
    {
        public Node(T element)
        {
            this.Value = element;
        }
        public Node<T>Next { get; set; }
        public Node<T> Previos { get; set; }
        public T Value { get; set; }
    }
}
