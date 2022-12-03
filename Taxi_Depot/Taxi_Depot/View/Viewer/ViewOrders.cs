using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Taxi_depot.Meniu;
using Taxi_depot.Model;
using Taxi_depot.Model.Cars;
using Taxi_depot.Model.Orders;
using Taxi_depot.Model.People.Clients;
using Taxi_depot.Model.People.Drivers;
using Taxi_depot.Model.TaxiCompany;

namespace Taxi_depot.Viewer
{
    internal class ViewOrders
    {
        public static void viewOrders(MenuItem menuItem)
        {
            if (Points.Actions[0].amount == 0)
                EndDay.FinishDay();
            else
            {
                if (Order.Orders.Count() != 0)
                {
                    Console.Clear();
                    Console.SetCursorPosition(0, 5);
                    Points.Actions[0].spend();
                    if (!(Driver.Drivers.Exists(driver => driver.sick == 0) && Taxi.Taxis.Exists(taxi => taxi.damage == 0)))
                    {
                        Points.Actions[0].amount = 0;
                    }
                    foreach (Order order in Order.Orders)
                    {
                        Taxi taxi = Taxi.Taxis.Find(taxi => taxi.GetStatus() == order.GetId());
                        Driver driver = Driver.Drivers.Find(driver => driver.id_order == order.GetId());
                        Client client = Client.Clients.Find(client => client.GetId() == order.id_client);
                        if (order.progress < 100)
                        {
                            Console.WriteLine("___________________________________________________________________");
                            Console.WriteLine(order.inform());
                            if (client != null)
                                Console.WriteLine(client.Describe());
                            else
                                Console.WriteLine("Undefined client");
                            if (driver != null)
                                Console.WriteLine(driver.inform());
                            else 
                                Console.WriteLine("Undefined driver");
                            if (taxi != null)
                                Console.WriteLine(taxi.Describe());
                            else
                                Console.WriteLine("Undefined car");
                            Console.WriteLine("___________________________________________________________________");
                        }
                    }
                }
            }
        }
    }
}
