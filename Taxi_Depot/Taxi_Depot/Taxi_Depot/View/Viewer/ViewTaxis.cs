﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taxi_depot.Meniu;
using Taxi_depot.Model.Cars;
using Taxi_depot.Viewer;

namespace Taxi_depot.Viewer
{
    internal static class ViewTaxis
    {
        public static void viewTaxi(MenuItem menuItem)
        {
            if (Taxi.Taxis.Count() != 0)
                foreach (Taxi item in Taxi.Taxis)
                    Console.WriteLine(item.Describe());
            else
                Console.WriteLine("There are no taxi cars yet!");
        }
    }
}
