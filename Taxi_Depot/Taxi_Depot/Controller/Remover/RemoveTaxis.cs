namespace Taxi_depot.Remover
{
    internal static class RemoveTaxis
    {
        public static void RemoveTaxi(MenuItem menuItem)
        {
            Console.Clear();
            Console.Write("Enter ID to remove: ");
            int input = Convert.ToInt16(Console.ReadLine());
            Taxi.Taxis.RemoveAt(input - 1);
            Car.Cars.RemoveAt(input - 1);
            Console.Clear();
        }
    }
}
