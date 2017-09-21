using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sport_store.SportStore
{
    class Cyclotourism
    {
        protected string Name;
        protected string Manufacturer;
        protected string Type;
        protected int Cost;
       

        public Cyclotourism(string name, string manufacturer, string type, int cost)
        {
            Type = type;
            Name = name;
            Manufacturer = manufacturer;
            Cost = cost;
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine("Name: {0}\nManufacturer: {1}\nType: {2}\nCost: {3}", Name, Manufacturer, Type, Cost);
        }

        
    }
}
