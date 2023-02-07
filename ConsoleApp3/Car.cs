using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    internal class Car:Vehicle
    {
        

         public int FuelCapacity;
         public override void ShowInfo()
        {
         
            Console.WriteLine($"Brand: {Brand} - Model: {Model} - Milage: {Mileage} - FuelCapacity: {FuelCapacity}");
        
        }

    }
        
}
