using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3_Factory
{
    internal class RaceGameClient
    {
        Navigator  navigator;
        Vehicle vehicle;
        AbstractFactoryVehicle AbstractFactoryVehicle;
        public RaceGameClient(AbstractFactoryVehicle factory) 
        {
            navigator=factory.CreateNavigator();
            vehicle=factory.CreateVehicle();
        }

        public void StartGame()
        {
            Console.WriteLine(vehicle.GetType().Name);
            navigator.Drive();
            navigator.Stop();
        }
    }
}
