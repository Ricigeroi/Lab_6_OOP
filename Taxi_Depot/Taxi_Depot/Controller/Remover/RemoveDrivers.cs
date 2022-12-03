namespace Taxi_depot.Remover
{
    internal static class RemoveDrivers
    {
        public static void RemoveDriver(MenuItem menuItem)
        {
            Console.Clear();
            Console.Write("Enter ID to remove: ");
            int input = Convert.ToInt16(Console.ReadLine());
            Driver.Drivers.Remove(Driver.Drivers.Find(item => item.GetId() == input));
            Person.People.RemoveAt(input - 1);
            Console.Clear();
        }
    }
}
