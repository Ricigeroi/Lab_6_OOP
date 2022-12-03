﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using Taxi_depot.Model.Cars;
using Taxi_depot.Model.People.Drivers;
using Taxi_depot.Model.TaxiCompany;

namespace Taxi_depot.Model.Orders
{
    public class Order : Depo
    {
        public Trip trip { get; set; }
        public int id_order;
        private string type;
        private int distance;
        private int fare;
        public int id_car { get; set; }
        public int id_driver { get; set; }
        public int id_client { get; set; }
        public int progress { get; set; }
        public static List<Order> Orders = new List<Order>();

        public Order(string type, int distance, int fare = 0, int id_order = 0, int id_car = 0, int id_driver = 0, int id_client = 0, int progress = 0, Trip trip = null)
        {
            this.id_order = Orders.Count() + 1;
            this.type = type;
            this.distance = distance;
            if (type.ToUpper() == "ECONOM")
            {
                this.fare = distance * Fare.GetFareEconom();
            }
            Orders.Add(this);
            this.id_car = id_car;
            this.id_driver = id_driver;
            this.id_client = id_client;
            this.progress = progress;
            this.trip = new Trip(id_order, distance);
        }
        public int GetDistance()
        {
            return distance;
        }
        public string GetClass()
        {
            return type.ToUpper();
        }
        public int GetId()
        {
            return id_order;
        }
        public int GetFare()
        {
            return fare;
        }
        public string inform()
        {
            return id_order + " " + GetClass().ToUpper() + " class. Distance = " + GetDistance() + ". Cost = " + GetFare() + ". Progress: " + progress + "%";
        }
        public int move()
        {
            return trip.move();
        }
        public int Progress()
        {
            progress = move();
            return progress;
        }
        public void assign()
        {
            Taxi car = Taxi.Taxis.Find(car => 2022 - car.year_of_issue >= 10 && car.GetStatus() == 0 && car.damage == 0);
            Driver driver = Driver.Drivers.Find(item => item.id_order == 0 && item.sick == 0);
            if (car != null && car.GetStatus() == 0 && driver != null)
            {
                driver.id_order = GetId();
                car.status = GetId();
                id_car = car.GetId();
                id_driver = driver.GetId();
            }
        }
    }
}
