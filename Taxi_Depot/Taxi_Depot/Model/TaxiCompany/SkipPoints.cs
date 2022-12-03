namespace Taxi_depot.Model.TaxiCompany
{
    public class SkipPoints
    {
        public static void SkipPoint(MenuItem menuItem)
        {
            int k = 0;
            while ((Order.Orders.Count == 0 || !Order.Orders.Exists(item => item.progress < 100)) && Points.Actions[0].amount > 0)
            {
                Points.Actions[0].spend();
                k++;
            }
            while (Points.Actions[0].amount > 0)
            {
                Thread.Sleep(500);
                ViewOrders.viewOrders(menuItem);
            }
            if (Points.Actions[0].amount == 0)
            {
                ViewOrders.viewOrders(menuItem);
            }
        }
    }
}
