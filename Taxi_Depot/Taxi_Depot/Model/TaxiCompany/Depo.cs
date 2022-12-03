namespace Taxi_depot.Model.TaxiCompany
{
    public class Depo
    {
        public void depo()
        {
            MenuCategory main = new MenuCategory("Menu: ", new MenuItem[]
            {
                new MenuAction("Points", ViewPoints),
                new MenuAction("View balance", ViewBalance),
                new MenuCategory("Taxi cars", new MenuItem[]
                {
                    new MenuAction("View taxi cars", ViewTaxis.viewTaxi),
                    new MenuCategory("Buy car", new MenuItem[]
                    {
                        new MenuAction("Toyota Prius30 2012        10.000$", AutoDealear.buyPrius),
                        new MenuAction("Toyota Corolla 2007         5.000$", AutoDealear.buyCorolla),
                        new MenuAction("Mercedes E190 1989          3.000$", AutoDealear.buyE190),
                        new MenuAction("Mercedes GLE-Coupe 2021    35.000$", AutoDealear.buyGLE),
                        new MenuBack()
                    }),
                    new MenuBack()
                }),

                new MenuCategory("Drivers", new MenuItem[]
                {
                    new MenuAction("View drivers", ViewDrivers.viewDrivers),
                    new MenuCategory("Hire drivers", new MenuItem[]
                    {
                        new MenuAction("Dominic Toretto        300$ + 40$/action point", RecruitmentAgency.HireToretto),
                        new MenuAction("Brian O'Conner         300$ + 20$/action point", RecruitmentAgency.HireBrian),
                        new MenuAction("Jasom Statham          300$ + 30$/ation point", RecruitmentAgency.HireStatham),
                        new MenuAction("Katea Racicovscaia     300$ + 8$/ation point", RecruitmentAgency.HireKatea),
                        new MenuBack()
                    }),
                    new MenuBack()
                }),

                new MenuAction("View clients", ViewClients.viewClients),
                new MenuCategory("Simulation", new MenuItem[]
                {
                    new MenuAction("Start simulate day", SkipPoints.SkipPoint),
                    new MenuAction("Next day", Next_Day.NextDay),
                    new MenuBack()
                }),
                new MenuCategory("Statitics", new MenuItem[]
                {
                    new MenuAction("Show one day date statistics", Statics.show),
                    new MenuAction("Show all time statics", Statics.showTotal),
                    new MenuBack()
                }),
                new MenuCategory("Options", new MenuItem[]
                {
                    new MenuCategory("Taxi cars", new MenuItem[]
                    {
                        new MenuAction("Add taxi car", AddTaxiCar.AddTaxi),
                        new MenuAction("Remove taxi car", RemoveTaxis.RemoveTaxi),
                        new MenuBack()
                    }),
                    new MenuCategory("Drivers", new MenuItem[]
                    {
                        new MenuAction("Add driver", AddNewDriver.AddDriver),
                        new MenuAction("Remove driver", RemoveDrivers.RemoveDriver),
                        new MenuBack()
                    }),
                    new MenuCategory("Clients", new MenuItem[]
                    {
                        new MenuAction("Add client", AddNewCLient.AddClient),
                        new MenuAction("Remove client", RemoveClients.RemoveClient),
                        new MenuBack()
                    }),
                    new MenuCategory("Orders", new MenuItem[]
                    {
                        new MenuAction("Add order", AddNewOrder.AddOrder),
                        new MenuAction("Remove order", RemoveOrders.RemoveOrder),
                        new MenuBack()
                    }),
                    new MenuAction("Clear all data", RemoveAll.Remove),
                    new MenuBack()
                }),
                new MenuBack("Exit")
            });
            new Company();
            Points points = new Points(25);
            Company.CompanyList[0].AddMoney(50000);
            AddClients(10);
            Menu menu = new Menu(main);
            menu.Run();
            Console.WriteLine("Выход из приложения, нажмите любую клавишу...");
            Console.ReadKey();
        }
        private static void AddClients(int number)
        {
            List<string> names = new List<string>() { "Andrei", "Ecaterina", "Egor", "Alina", "Danila", "Alisa", "Pavel", "Anna" };
            List<string> surnames = new List<string>() { "Bardier", "Racicovscii", "Mocrenco", "Zacatov", "Cojuhari", "Nedelcev", "Gordeev" };

            for (int i = 0; i < number; i++)
            {
                new Client(names[new Random().Next(names.Count())], surnames[new Random().Next(surnames.Count())], new Random().Next(16, 70), new Random().Next(1000, 25000));
            }
        }
        private static void ViewPoints(MenuItem menuItem)
        {
            Console.Clear();
            Console.WriteLine(Points.Actions[0].amount + " available points!");
            Console.ReadKey();
            Console.Clear();
        }
        private static void ViewBalance(MenuItem menuItem)
        {
            Console.WriteLine("Your balance is " + Company.CompanyList[0].GetBalance() + "$");
        }
    }
}
