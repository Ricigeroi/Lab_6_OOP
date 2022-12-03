using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taxi_depot.Meniu;
using Taxi_depot.Model.Cars;
using Taxi_depot.Model.Orders;
using Taxi_depot.Model.People.Clients;
using Taxi_depot.Model.People.Drivers;
using Taxi_depot.Model.TaxiCompany;
using Taxi_depot.Viewer;

namespace Taxi_depot.Model
{
    public class Points : Depo
    {
        public int amount { get; set; }
        public static List<Points> Actions = new List<Points>();
        public static List<int> Fines = new List<int>();
        public Points(int amount)
        {
            this.amount = amount;
            Actions.Add(this);
        }
        public void spend()
        {
            amount -= 1;
            GenerateOrders.generateOrders();
            foreach (Order order in Order.Orders)
            {
                Taxi taxi = Taxi.Taxis.Find(taxi => taxi.GetStatus() == order.GetId());
                Driver driver = Driver.Drivers.Find(driver => driver.id_order == order.GetId());
                Client client = Client.Clients.Find(client => client.order_status == order.GetId());

                if (order.id_car != 0 && order.id_driver != 0)
                {
                    order.Progress();
                    if (taxi != null && driver != null && order.progress < 100 && order != null)
                    {
                        Event.Accident(driver.years_driving, taxi, order);
                        Event.GotSick(driver.age, driver);
                        Event.Break(2022 - taxi.year_of_issue, taxi, order);
                    }
                }
                else
                {
                    order.assign();
                }
                // завершение заказа
                if (order.progress == 100)
                {
                    if (taxi != null) { taxi.status = 0; }
                    if (driver != null) { driver.id_order = 0; }
                    if (client != null) { client.order_status = 0; }
                    order.id_car = 0;
                    order.id_driver = 0;
                    order.id_client = 0;
                }
            }
            // зарплата водителям
            foreach (Driver driver in Driver.Drivers)
            {
                Company.CompanyList[0].spendMoney(driver.salary);
            }
        }
    }
}
