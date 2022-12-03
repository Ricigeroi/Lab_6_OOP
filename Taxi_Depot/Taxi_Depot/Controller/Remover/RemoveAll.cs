namespace Taxi_depot.Remover
{
    internal static class RemoveAll
    {
        public static void Remove(MenuItem menuItem)
        {
            Taxi.Taxis.Clear();
            Driver.Drivers.Clear();
            Client.Clients.Clear();
            Order.Orders.Clear();
        }
    }
}
