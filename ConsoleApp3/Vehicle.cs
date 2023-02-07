using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    internal class Vehicle
    {
      

        public string Brand;
        public string Model;
        public int Mileage;

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Brand: {Brand} - Model: {Model} - Milage: {Mileage}");
        }


    }
}
