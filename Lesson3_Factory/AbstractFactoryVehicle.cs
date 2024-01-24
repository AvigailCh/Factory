using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3_Factory
{
    internal interface AbstractFactoryVehicle
    {
        Vehicle CreateVehicle();
        Navigator CreateNavigator();

    }

    class RoadFactory : AbstractFactoryVehicle
    {
        public Navigator CreateNavigator()
        {
            return new TrafficLight();
        }

        public Vehicle CreateVehicle()
        {
            return new Car();
        }
    }
    class SeaFactory : AbstractFactoryVehicle
    {
        public Navigator CreateNavigator()
        {
            return new SeaTower();
        }

        public Vehicle CreateVehicle()
        {
            return new Ship();
        }
    }

}
