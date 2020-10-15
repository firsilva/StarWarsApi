using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsApi.DataBase
{
    public class PlanetModel
    {
        public string name { get; set; }
        public int rotation_period { get; set; }
        public int orbital_period { get; set; }
        public int diameter { get; set; }
    }
}
