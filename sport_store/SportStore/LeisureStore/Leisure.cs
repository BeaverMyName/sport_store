using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sport_store.SportStore
{
    class Leisure
    {
        protected string Name;
        protected string Manufacturer;
        protected string Type;
        protected string Material;
        protected int Cost;


        public Leisure(string name, string manufacturer, string type, string material, int cost)
        {
            Name = name;
            Manufacturer = manufacturer;
            Type = type;
            Material = material;
            Cost = cost;
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine("Name: {0}\nManufacturer: {1}\nType: {2}\nCost: {3}", Name, Manufacturer, Type, Cost);
        }
    }
}
