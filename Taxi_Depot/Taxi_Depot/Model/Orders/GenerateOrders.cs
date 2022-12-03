using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taxi_depot.Model.Cars;
using Taxi_depot.Model.People.Clients;
using Taxi_depot.Model.People.Drivers;

namespace Taxi_depot.Model.Orders
{
    public static class GenerateOrders
    {
        public static void generateOrders()
        {
            foreach (Client client in Client.Clients)
            {
                if (client.order_status == 0)
                {
                    client.CallTaxi();
                    Order order = Order.Orders.Find(order => order.id_client == client.GetId());
                    if (order != null)
                    {
                        client.order_status = order.GetId();
                        order.assign();
                        Taxi taxi = Taxi.Taxis.Find(taxi => taxi.GetStatus() == order.GetId());
                        Driver driver = Driver.Drivers.Find(driver => driver.id_order == order.GetId());
                        if (taxi != null && driver != null)
                        {
                            order.id_driver = driver.GetId();
                            order.id_car = taxi.GetId();
                        }
                    }
                }
            }
        }
    }
}
