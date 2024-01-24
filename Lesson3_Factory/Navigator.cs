using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3_Factory
{
    internal interface Navigator
    {
        void Stop();
        void Drive();
    }
    class SeaTower : Navigator
    {
        public void Drive()
        {
            Console.WriteLine("SeaTower say to Drive");
        }

        public void Stop()
        {
            Console.WriteLine("SeaTower say to Stop");

        }
    }
    class TrafficLight : Navigator
    {
        public void Drive()
        {
            Console.WriteLine("TrafficLight say to Drive");
        }

        public void Stop()
        {
            Console.WriteLine("TrafficLight say to Stop");

        }
    }
}
