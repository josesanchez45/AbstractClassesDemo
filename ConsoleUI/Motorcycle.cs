using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class Motorcycle :Vehicle
    {
        public bool HasSideCar { get; set; }
        public override void DriveAbstract()
        {
            Console.WriteLine("This bike is in drive.");
        }
        public override void DriveVirtual()
        {
            Console.WriteLine($"Does this bike have a side car: {HasSideCar}.");
        }
    }
}
