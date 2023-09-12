using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Froogy
{
    public class Lake:IEnumerable<int>
    {
        private int[] lakeNumbers;
        public Lake(int[]lake) 
        {
            lakeNumbers = lake;
        }

        public IEnumerator<int> GetEnumerator()
        {
           Predicate<int> isEvenPosition = (int num) => num == 0 || num % 2 == 0;
           Predicate<int> isOddPosition = (int num) => num % 2 != 0;
           for (int i = 0; i < lakeNumbers.Length; i++)
           {
                if (isEvenPosition(i))
                {
                    yield return lakeNumbers[i];
                }
            
           }
            for (int i = lakeNumbers.Length - 1; i >= 0; i--)
            {
                if (isOddPosition(i))
                {
                    yield return lakeNumbers[i];
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()=>GetEnumerator();
       
    }
}
