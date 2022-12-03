using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taxi_depot.Meniu;

namespace Taxi_depot.Controller
{
    public interface INextDay
    {
        public static void NextDay() { }
        public static void NextDay(MenuItem menuItem) { }
    }
}
