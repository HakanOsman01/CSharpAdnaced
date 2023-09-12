using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08._Threeuple
{
    public class Threeuple<T1,T2,T3>
    {
        public Threeuple()
        {
            Item1 = new List<T1>();
            Item2 = new List<T2>();
            Item3 = new List<T3>();
        }
        public List<T1> Item1 { get; set; }
        public List<T2> Item2 { get; set; }
        public List<T3> Item3 { get; set; }

        public void AddItems(T1 item1, T2 item2,T3 item3)
        {
            this.Item1.Add(item1);
            this.Item2.Add(item2);
            this.Item3.Add(item3);
        }


    }
}
