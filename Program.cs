using Motorcar_project;

namespace Automobile
{
    internal class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Client! Here are the car details");
            CarDetails carDetails = new CarDetails();
            carDetails.car("Benz", "C Class", "2015", "Blue", 20000, "Petrol");

        }
    }
}
