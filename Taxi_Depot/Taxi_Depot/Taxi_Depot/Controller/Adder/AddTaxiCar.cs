using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taxi_depot.Meniu;
using Taxi_depot.Model.Cars;
using Taxi_depot.Viewer;

namespace Taxi_depot.Adder
{
    public class AddTaxiCar
    {
        public static void AddTaxi(MenuItem menuItem)
        {
            Console.Clear();
            Console.Write("Enter make, model, year: ");
            string[] input = Console.ReadLine().Split();
            Taxi car = new Taxi(input[0], input[1], Convert.ToInt16(input[3]));
            Console.Clear();
        }
    }
}
