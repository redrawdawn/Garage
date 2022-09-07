
using System;

namespace Garage
{
    public class Ram : Vehicle  // Gas powered truck
    {
        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {
            // method definition omitted
        }
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Ram drives past. RRrrrrrummbbble!");
        }

        public override void Turn()
        {
            Console.WriteLine($"the {MainColor} Ram turns left yo!");
        }

        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Ram rolls to a stop after rolling a mile down the runway");
        }

    }
}