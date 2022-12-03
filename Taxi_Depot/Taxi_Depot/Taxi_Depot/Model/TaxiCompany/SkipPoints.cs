using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taxi_depot.Controller.Adder;
using Taxi_depot.Meniu;
using Taxi_depot.Model.Orders;
using Taxi_depot.Viewer;

namespace Taxi_depot.Model.TaxiCompany
{
    public class SkipPoints : ISkipPoints
    {
        public static void SkipPoint(MenuItem menuItem)
        {
            int k = 0;
            while ((Order.Orders.Count == 0 || !Order.Orders.Exists(item => item.progress < 100)) && Points.Actions[0].amount > 0)
            {
                Points.Actions[0].spend();
                k++;
            }
            while (Points.Actions[0].amount > 0)
            {
                Thread.Sleep(500);
                ViewOrders.viewOrders(menuItem);
            }
            if (Points.Actions[0].amount == 0)
            {
                ViewOrders.viewOrders(menuItem);
            }
        }
    }
}
