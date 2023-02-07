using System;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car cr = new Car
            {
                Brand = "Seat",
                Model = "Leon",
                Mileage = 180,
                FuelCapacity = 156


            };
            cr.ShowInfo();


            Bicycle by = new Bicycle
            {
                Brand = "Serraro",
                Model = "N203",
                Mileage = 60,

            };

             by.ShowInfo();


  
        }
    }
}
