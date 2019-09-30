using System;
using System.Collections.Generic;
using System.Text;

namespace MyInheritanceExample
{
    public class Vehicle
        // if this class was sealed, nothing could inherit from it
        //a class can be sealed and public, FYI
    {
        //let's say that vehicle requires an arg or param
        //the only constructor for vehicle takes in a wheel count 

        public Vehicle(int wheelCount)
        {
            WheelCount = wheelCount;
        }

        protected int sampleInt = 0;

       protected int WheelCount { get; set; }
        //protected makes it inaccessible to the outside world except to children of this class
        //so it's essentially private except for inheritance
        public int NumberOfDoors { get; set; }
        public string Manufacturer { get; set; }
        public int NumberOfSeats { get; set; }
     }
}
