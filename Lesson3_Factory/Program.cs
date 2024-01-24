using Lesson3_Factory;
using System.Threading.Channels;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        // Class Factory
        Vehicle v = FactoryVehicle.GetVehicle("Car");
        Vehicle v1 = FactoryVehicle.GetVehicle("Truck");


        RaceGameClient raceGame=null;
        Console.WriteLine( "Press 1 to sea toolkit or 2 to road toolkit");
        int choise= int.Parse(Console.ReadLine());

        switch (choise)
        {
            case 1: raceGame = new RaceGameClient(new SeaFactory()); break;
            case 2: raceGame = new RaceGameClient(new RoadFactory()); break;
            default:
                Console.WriteLine("Error");
                break;
        }

        raceGame?.StartGame();


    }
}