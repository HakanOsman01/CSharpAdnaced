using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    public class CatalogCars : IEnumerable<Car>
    {
        private List<Car> cars;
        public CatalogCars()
        {
            
        }
        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator<Car> IEnumerable<Car>.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
