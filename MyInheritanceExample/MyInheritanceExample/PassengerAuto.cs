using System;
using System.Collections.Generic;
using System.Text;

namespace MyInheritanceExample
{
    public class PassengerAuto : Vehicle
    {
        public string VIN { get; set; }

        public PassengerAuto(string vin) : base(4)
            // : base (__) how we call the parent's constructor. (the base constructor)
            //so here we're calling the parent constructor that takes int WheelCount
        {
            VIN = vin;
        }
        //this constructor is only going to allow the creation of a passenger auto if it has a vin

    }
}
