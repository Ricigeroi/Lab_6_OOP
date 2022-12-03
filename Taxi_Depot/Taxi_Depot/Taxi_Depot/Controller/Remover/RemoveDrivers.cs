﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taxi_depot.Meniu;
using Taxi_depot.Model.People;
using Taxi_depot.Model.People.Drivers;
using Taxi_depot.Viewer;

namespace Taxi_depot.Remover
{
    internal static class RemoveDrivers
    {
        public static void RemoveDriver(MenuItem menuItem)
        {
            Console.Clear();
            Console.Write("Enter ID to remove: ");
            int input = Convert.ToInt16(Console.ReadLine());
            Driver.Drivers.Remove(Driver.Drivers.Find(item => item.GetId() == input));
            Person.People.RemoveAt(input - 1);
            Console.Clear();
        }
    }
}
