using System;
using System.Collections.Generic;
using System.Text;

namespace MyInheritanceExample
{
    class Truck : Vehicle
    {
        //we are required to add a constructor now that the parent constructor takes arg or param
        public Truck() :base(4)
        {

        }

        public int GrossVehicleWeight { get; set; }
        public int NumberOfAxles { get; set; }
    }
}
