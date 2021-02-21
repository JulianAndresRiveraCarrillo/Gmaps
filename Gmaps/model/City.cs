using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gmaps.model
{
    class City
    {
        private string name;
        private long population;

        public City(string n, long p)
        {
            name = n;
            population = p;
        }

        public string Name
        {
            get => name;
        }

        public long Population
        {
            get => population;
            set => population = value;
        }
    }
}

