﻿namespace Taxi_depot.Meniu
{
    public class MenuCategory : MenuItem
    {
        public MenuItem[] Items { get; }

        public MenuCategory(string name, MenuItem[] items) : base(name)
        {
            Items = items;
        }
    }
}
