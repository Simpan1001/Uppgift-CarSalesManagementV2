using CarNamespace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryNamespace
{
    public class Repository
    {
        public List<Car> myCarList = new List<Car>();

        public void Save(Car c) {
            myCarList.Add(c);
        }

    }
}
