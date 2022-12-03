namespace Taxi_depot.Model.People.Drivers
{
    public class HireDrivers
    {
        public static void HireDriver(string name, string surname, int age, int years_driving, int salary)
        {
            new Driver(name, surname, age, years_driving, salary: salary);
        }
    }
}
