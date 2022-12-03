using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taxi_depot.Meniu;
using Taxi_depot.Model.People.Drivers;
using Taxi_depot.Viewer;

namespace Taxi_depot.Viewer
{
    internal static class ViewDrivers
    {
        public static void viewDrivers(MenuItem menuItem)
        {
            if (Driver.Drivers.Count() != 0)
                foreach (Driver item in Driver.Drivers)
                    Console.WriteLine(item.Describe());
            else
                Console.WriteLine("There are no drivers yet!");
        }
    }
}
