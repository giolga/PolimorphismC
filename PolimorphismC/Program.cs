using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorphismC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cars = new List<Car>()
            {
                new Audi(200, "Black", "A7"),
                new BMW(190, "Red", "M3")
            };

            foreach (var car in cars)
            {
                car.Repair();
            }

            Car bmwZ3 = new BMW(200, "Brown", "Z3");
            Car audiA3 = new Audi(220, "White", "A3");

            bmwZ3.ShowDetails();
            audiA3.ShowDetails();

            BMW bmwM5 = new BMW(330, "Red", "M5");
            bmwM5.ShowDetails();

            Car carB = (Car)bmwM5;//carB will have Car class ShowDetail
            carB.ShowDetails();

            Console.ReadKey();
        }
    }
}
