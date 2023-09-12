using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Scale
{
    public class EqualityScale<T> where T : IComparable<T>
    {
        private T left;
        private T right;
        public EqualityScale(T left,T right)
        {
            this.left = left;
            this.right = right;
        }
        public bool AreEqual()
        {
            int num=this.left.CompareTo(this.right);
            if (num == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
