using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sport_store.SportStore
{
    class WinterSport
    {
        protected string Name;
        protected string Manufacturer;
        protected string Type;
        protected string Material;
        protected int Cost;


        public WinterSport(string name, string manufacturer, string type, string material, int cost)
        {
            Name = name;
            Manufacturer = manufacturer;
            Type = type;
            Material = material;
            Cost = cost;
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine("Name: {0}\nManufacturer: {1}\nType: {2}\nMaterial: {3}\nCost: {4}", Name, Manufacturer, Type, Material, Cost);
        }
    }
}
