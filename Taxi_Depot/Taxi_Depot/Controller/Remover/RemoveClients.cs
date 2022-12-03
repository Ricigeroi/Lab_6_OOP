namespace Taxi_depot.Remover
{
    internal static class RemoveClients
    {
        public static void RemoveClient(MenuItem menuItem)
        {
            Console.Clear();
            Console.Write("Enter ID to remove: ");
            int input = Convert.ToInt16(Console.ReadLine());
            Client.Clients.Remove(Client.Clients.Find(item => item.GetId() == input));
            Person.People.RemoveAt(input - 1);
            Console.Clear();
        }
    }
}
