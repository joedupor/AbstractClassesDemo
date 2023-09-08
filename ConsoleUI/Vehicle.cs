using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal abstract class Vehicle
    {

        public string Year { get; set; } = "any year";

        public string Make { get; set; } = "any make";

        public string Model { get; set; } = "any model";

        public void MakeEngineNoise(string engineNoise)
        {
            Console.WriteLine(engineNoise);
        }






    }
}
