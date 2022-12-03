
namespace Taxi_depot.Model.TaxiCompany
{
    public static class Event
    {
        public static void Accident(int multiplier, Taxi taxi, Order order)
        {
            double chance = new Random().Next(1, 1000) * (Convert.ToDouble(10) / Convert.ToDouble(multiplier));
            chance = Math.Floor(chance) + 1;
            if (chance < 5)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("*************************************");
                Console.WriteLine(taxi.info() + " got in an accident!");
                int fine = new Random().Next(order.GetFare(), 20000);
                Points.Fines.Add(fine);
                Console.WriteLine("Taxi-company has been fined by " + fine + " dollars.");
                Company.CompanyList[0].spendMoney(fine);
                int period = new Random().Next(1, 4);
                Console.WriteLine("Car will be unavailable for " + period + " day(s)!");
                taxi.damage = period;
                Console.WriteLine("*************************************");
                Console.ResetColor();
                order.progress = 100;
                Thread.Sleep(1000);
            }
        }

        public static void Break(int multiplier, Taxi taxi, Order order)
        {
            double chance = new Random().Next(1, 1000) * (Convert.ToDouble(15) / Convert.ToDouble(multiplier) );
            chance = Math.Floor(chance);
            if (chance < 10)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("*************************************");
                Console.WriteLine(taxi.info() + " just broke!");
                int period = new Random().Next(1, 3);
                Console.WriteLine("Car will be unavailable for " + period + " day(s)!");
                taxi.damage = period;
                Console.WriteLine("*************************************");
                Console.ResetColor();
                order.progress = 100;
                order.id_car = 0;
                order.id_driver = 0;
                order.id_client = 0;
                Thread.Sleep(1000);
            }
        }

        public static void GotSick(int multiplier, Driver driver)
        {
            double chance = new Random().Next(1, 1000) * (Convert.ToDouble(40) / Convert.ToDouble(multiplier));
            chance = Math.Floor(chance) + 1;
            if (chance < 10 && driver.sick == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("*************************************");
                Console.WriteLine(driver.inform() + " got sick!");
                int period = new Random().Next(3, 7);
                Console.WriteLine("Driver finishes his order and will be unavailable for " + period + " day(s)!");
                driver.sick = period;
                Console.WriteLine("*************************************");
                Console.ResetColor();
                Thread.Sleep(1000);
            }
        }
    }
}
