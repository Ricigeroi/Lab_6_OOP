using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taxi_depot.Meniu;
using Taxi_depot.Model;
using Taxi_depot.Viewer;
using Taxi_depot.Model.People.Drivers;
namespace Taxi_depot.Adder
{
    internal class AddNewDriver
    {
        public static void AddDriver(MenuItem menuItem)
        {
            Console.Clear();
            Console.Write("Enter name, surname, age, years driving: ");
            string[] input = Console.ReadLine().Split();
            new Driver(input[0], input[1], Convert.ToInt16(input[2]), Convert.ToInt16(input[3]));
            Console.Clear();
        }
    }
}
