using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taxi_depot.Meniu;
using Taxi_depot.Model.Cars;
using Taxi_depot.Model.Orders;
using Taxi_depot.Model.People.Clients;
using Taxi_depot.Model.People.Drivers;

namespace Taxi_depot.Remover
{
    internal static class RemoveAll
    {
        public static void Remove(MenuItem menuItem)
        {
            Taxi.Taxis.Clear();
            Driver.Drivers.Clear();
            Client.Clients.Clear();
            Order.Orders.Clear();
        }
    }
}
