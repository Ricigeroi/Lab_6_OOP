namespace Taxi_depot.Meniu
{
    public abstract class MenuItem
    {
        public string Name { get; }

        public MenuItem(string name)
        {
            Name = name;
        }
    }
}
