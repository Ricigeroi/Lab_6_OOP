using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taxi_depot.Controller;
using Taxi_depot.Meniu;
using Taxi_depot.Model.Cars;
using Taxi_depot.Model.Orders;
using Taxi_depot.Model.People.Clients;
using Taxi_depot.Model.People.Drivers;

namespace Taxi_depot.Model.TaxiCompany
{
    public class Next_Day
    {
        public static void NextDay()
        {
            int salary = 0;
            Console.WriteLine("NEW DAY STARTED");
            if (Points.Actions[0].amount > 0)
            {
                for (int i = 0; i < Points.Actions[0].amount; i++)
                {
                    foreach (Driver driver in Driver.Drivers)
                    {
                        Company.CompanyList[0].spendMoney(driver.salary);
                        salary += driver.salary;
                    }
                }
            }
            Points.Fines.Clear();
            foreach (Driver driver1 in Driver.Drivers)
            {
                driver1.id_order = 0;
                if (driver1.sick > 0)
                {
                    driver1.sick--;
                }
            }
            foreach (Taxi taxi in Taxi.Taxis)
            {
                taxi.status = 0;
                if (taxi.damage > 0)
                {
                    taxi.damage--;
                }
            }

            foreach (Client client in Client.Clients)
            {
                client.order_status = 0;
                client.AddMoney(new Random().Next(500, 3000));
            }
            Points.Actions[0].amount = 25;
            Order.Orders.Clear();
        }
        public static void NextDay(MenuItem menuItem)
        {
            int salary = 0;
            Console.WriteLine("NEW DAY STARTED");
            if (Points.Actions[0].amount > 0)
            {
                for (int i = 0; i < Points.Actions[0].amount; i++)
                {
                    foreach (Driver driver in Driver.Drivers)
                    {
                        Company.CompanyList[0].spendMoney(driver.salary);
                        salary += driver.salary;
                    }
                }
            }
            Points.Fines.Clear();
            foreach (Driver driver1 in Driver.Drivers)
            {
                driver1.id_order = 0;
                if (driver1.sick > 0)
                {
                    driver1.sick--;
                }
            }
            foreach (Taxi taxi in Taxi.Taxis)
            {
                taxi.status = 0;
                if (taxi.damage > 0)
                {
                    taxi.damage--;
                }
            }
            foreach (Client client in Client.Clients)
            {
                client.order_status = 0;
                client.AddMoney(new Random().Next(500, 3000));
            }
            Points.Actions[0].amount = 50;
            Order.Orders.Clear();
            new Statics(0, salary, 0, 0);
        }
    }
}
