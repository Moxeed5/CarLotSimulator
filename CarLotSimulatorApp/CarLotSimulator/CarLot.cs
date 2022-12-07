using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    //Create a CarLot class
    //It should have at least one property: a List of cars
    //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
    //At the end iterate through the list printing each of car's Year, Make, and Model to the console
    internal class CarLot
    {
        public CarLot()
        {
            carList = new List<Car>();
        }

        public static List<Car> carList { get; set; }

        internal void Add(Car car1)
        {
            throw new NotImplementedException();
        }
    }
}
