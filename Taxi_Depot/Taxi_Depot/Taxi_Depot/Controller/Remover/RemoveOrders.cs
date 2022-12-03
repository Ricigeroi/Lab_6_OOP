﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taxi_depot.Meniu;
using Taxi_depot.Model.Orders;
using Taxi_depot.Viewer;

namespace Taxi_depot.Remover
{
    internal static class RemoveOrders
    {
        public static void RemoveOrder(MenuItem menuItem)
        {
            Console.Clear();
            Console.Write("Enter ID to remove: ");
            int input = Convert.ToInt16(Console.ReadLine());
            Order.Orders.RemoveAt(input - 1);
            Console.Clear();
        }
    }
}
