namespace Taxi_depot.Controller.Adder
{
    internal class AddNewCLient
    {
        public static void AddClient(MenuItem menuItem)
        {
            Console.Clear();
            Console.Write("Enter name, surname, age, balance: ");
            string[] input = Console.ReadLine().Split();
            Client client = new Client(input[0], input[1], Convert.ToInt16(input[2]), Convert.ToInt16(input[3]));
            Console.Clear();
        }
    }
}
