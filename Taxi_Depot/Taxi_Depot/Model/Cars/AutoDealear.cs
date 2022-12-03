namespace Taxi_depot.Model.Cars
{
    public class AutoDealear : Company
    {
        public static void buyPrius(MenuItem menuItem)
        {
            Console.Clear();
            BuyCars.BuyCar("Toyota", "Prius", 2012);
            Console.Clear();
            CompanyList[0].spendMoney(10000);
        }
        public static void buyCorolla(MenuItem menuItem)
        {
            Console.Clear();
            BuyCars.BuyCar("Toyota", "Corolla", 2007);
            Console.Clear();
            CompanyList[0].spendMoney(5000);
        }
        public static void buyE190(MenuItem menuItem)
        {
            Console.Clear();
            BuyCars.BuyCar("Mercedes", "E190", 1989);
            Console.Clear();
            CompanyList[0].spendMoney(3000);
        }
        public static void buyGLE(MenuItem menuItem)
        {
            Console.Clear();
            BuyCars.BuyCar("Mercedes", "GLE-Coupe", 2021);
            Console.Clear();
            CompanyList[0].spendMoney(35000);
        }
    }
}
