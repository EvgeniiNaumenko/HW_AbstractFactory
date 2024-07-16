using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_AbstractFactory
{
    public class NorthAmerica : Continent
    {
        public override string Name { get; } = "NorthAmerica";

        public override Herbivore CreateHerbivore()
        {
            return new Bison();
        }

        public override Carnivore CreateCarnivore()
        {
            return new Wolf();
        }

    }
}
