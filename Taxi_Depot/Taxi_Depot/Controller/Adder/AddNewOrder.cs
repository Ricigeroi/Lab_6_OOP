﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taxi_depot.Meniu;
using Taxi_depot.Model.Orders;
using Taxi_depot.Viewer;

namespace Taxi_depot.Adder
{
    public class AddNewOrder
    {
        public static void AddOrder(MenuItem menuItem)
        {
            Console.Clear();
            Console.Write("Enter type, distance: ");
            string[] input = Console.ReadLine().Split();
            Order order = new Order(input[0], Convert.ToInt16(input[1]));
            Console.Clear();
        }
    }
}
