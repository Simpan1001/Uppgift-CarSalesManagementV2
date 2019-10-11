using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarNamespace
{
    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
