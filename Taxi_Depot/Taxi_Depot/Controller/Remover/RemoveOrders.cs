namespace Taxi_depot.Remover
{
    internal static class RemoveOrders
    {
        public static void RemoveOrder(MenuItem menuItem)
        {
            Console.Clear();
            Console.Write("Enter ID to remove: ");
            int input = Convert.ToInt16(Console.ReadLine());
            Order.Orders.RemoveAt(input - 1);
            Console.Clear();
        }
    }
}
