namespace Taxi_depot.Model.Cars
{
    public static class BuyCars
    {
        public static void BuyCar(string make, string model, int year_of_issue)
        {
            new Taxi(make, model, year_of_issue);
        }
    }
}
