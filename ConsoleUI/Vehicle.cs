using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public abstract class Vehicle
    {
        public string Make { get; set; } = "1";
        public int Year { get; set; } = 1;
        public string Model { get; set; } = "default";


        public abstract void DriveAbstract();

        public virtual void DriveVirtual()
        {
            Console.WriteLine($" This {Make} {Model} is in drive");
        }
        

        
    }
}
