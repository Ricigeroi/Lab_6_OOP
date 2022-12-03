using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taxi_depot.Adder;
using Taxi_depot.Controller;
using Taxi_depot.Meniu;
using Taxi_depot.Model.TaxiCompany;

namespace Taxi_depot.Model.People.Drivers
{
    public class RecruitmentAgency : Company
    {
        public static void HireToretto(MenuItem menuItem)
        {
            Console.Clear();
            IHireDriver.HireDriver("Dominic", "Toretto", 55, 55 - 21, salary: 40);
            //AddNewDriver.HireDriver("Dominic", "Toretto", 55, 55 - 21, salary: 40);
            Console.Clear();
            CompanyList[0].spendMoney(300);
        }
        public static void HireBrian(MenuItem menuItem)
        {
            Console.Clear();
            IHireDriver.HireDriver("Brian", "O'Conner", 40, 15, salary: 20);
            //AddNewDriver.HireDriver("Brian", "O'Conner", 40, 15, salary: 20);
            Console.Clear();
            CompanyList[0].spendMoney(300);
        }
        public static void HireStatham(MenuItem menuItem)
        {
            Console.Clear();
            IHireDriver.HireDriver("Jason", "Statham", 55, 20, salary: 30);
            //AddNewDriver.HireDriver("Jason", "Statham", 55, 20, salary: 30);
            Console.Clear();
            CompanyList[0].spendMoney(300);
        }
    }
}

