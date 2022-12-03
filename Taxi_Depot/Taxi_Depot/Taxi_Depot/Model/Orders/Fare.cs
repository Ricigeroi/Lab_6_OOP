using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taxi_depot.Model.TaxiCompany;

namespace Taxi_depot.Model.Orders
{
    public class Fare : Depo
    {
        public static int GetFareEconom()
        {
            return 150;
        }
    }
}
