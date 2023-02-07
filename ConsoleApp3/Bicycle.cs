using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    internal class Bicycle:Vehicle
    {

        public override void ShowInfo()
        {
            Console.WriteLine($"Brand: {Brand} - Model: {Model} - Milage: {Mileage}");
        }

    }
}
