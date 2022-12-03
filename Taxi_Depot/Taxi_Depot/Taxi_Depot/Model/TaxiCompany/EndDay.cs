using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taxi_depot.Model.Orders;
using Taxi_depot.Model.People.Drivers;

namespace Taxi_depot.Model.TaxiCompany
{
    public static class EndDay
    {
        public static void FinishDay()
        {
            int sum = 0;
            int sum_distance = 0;
            int salary = 0;
            int fines = 0;
            Console.Clear();
            Console.WriteLine("You have no actions points.");
            Console.WriteLine();
            foreach (Order item in Order.Orders)
            {
                Console.WriteLine(item.inform());
                sum_distance += item.GetDistance();
                sum += item.GetFare();
            }
            foreach (Driver driver in Driver.Drivers)
            {
                salary += driver.salary * 50;
            }
            foreach (int fine in Points.Fines)
            {
                fines += fine;
            }
            int total = sum - fines - salary;
            Statics statics = new Statics(sum, salary, fines, Convert.ToInt32(total * 0.13));
            Console.WriteLine("______________________________________________________________");
            Console.WriteLine("Earned today: " + sum + "$. Passed km: " + sum_distance);
            Console.WriteLine("Salary: " + salary + "$");
            Console.WriteLine("Fines: " + fines + "$");
            Console.WriteLine("Taxes + fees (13%): " + 0.13 * total + "$");
            Company.CompanyList[0].spendMoney(Convert.ToInt32(total * 0.13));
            Console.WriteLine("______________________________________________________________");
            Console.WriteLine("TOTAL: " + total + "$");
            Console.ReadKey();
            Next_Day.NextDay();
            Console.Clear();
        }
    }
}
