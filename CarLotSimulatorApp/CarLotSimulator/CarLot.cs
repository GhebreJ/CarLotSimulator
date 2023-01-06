using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    public class CarLot
    {
        public List<Car> Cars { get; set; }

        public CarLot()
        {
            Cars= new List<Car>();
        }
        public void PrintCars() 
        {
            foreach (Car car in Cars)
            {
                Console.WriteLine($"{car.Year}, {car.Make}, {car.Model}");
                car.MakeHonkNoise("Honk");
                car.MakeEngineNoise("Clunk");
            }
        }
    }
}
