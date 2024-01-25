using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    internal class Car
    {
        public Car()
        {
            CarLot.AddCar();
        }
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; }

         


        public void Engine()
        {

            Console.WriteLine($"{Make} goes {EngineNoise}");
        }

        public void Honk()
        {
            Console.WriteLine($"{Make} goes {HonkNoise} ");
        }

      
        

}
}
