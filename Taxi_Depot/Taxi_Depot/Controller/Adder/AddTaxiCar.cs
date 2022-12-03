namespace Taxi_depot.Controller.Adder
{
    public class AddTaxiCar
    {
        public static void AddTaxi(MenuItem menuItem)
        {
            Console.Clear();
            Console.Write("Enter make, model, year: ");
            string[] input = Console.ReadLine().Split();
            Taxi car = new Taxi(input[0], input[1], Convert.ToInt16(input[3]));
            Console.Clear();
        }
    }
}
