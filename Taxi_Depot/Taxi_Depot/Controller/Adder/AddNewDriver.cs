namespace Taxi_depot.Controller.Adder
{
    internal class AddNewDriver
    {
        public static void AddDriver(MenuItem menuItem)
        {
            Console.Clear();
            Console.Write("Enter name, surname, age, years driving: ");
            string[] input = Console.ReadLine().Split();
            new Driver(input[0], input[1], Convert.ToInt16(input[2]), Convert.ToInt16(input[3]));
            Console.Clear();
        }
    }
}
