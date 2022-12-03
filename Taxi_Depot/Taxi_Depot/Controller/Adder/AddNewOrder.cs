namespace Taxi_depot.Controller.Adder
{
    public class AddNewOrder
    {
        public static void AddOrder(MenuItem menuItem)
        {
            Console.Clear();
            Console.Write("Enter type, distance: ");
            string[] input = Console.ReadLine().Split();
            Order order = new Order(input[0], Convert.ToInt16(input[1]));
            Console.Clear();
        }
    }
}
