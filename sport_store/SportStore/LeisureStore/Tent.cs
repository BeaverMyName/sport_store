using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sport_store.SportStore
{
    class Tent : Leisure
    {
        protected byte CountOfPlaces;

        public Tent(string name, string manufacturer, string type, string material, int cost, byte countOfPlaces) : base (name, manufacturer, type, material, cost)
        {
            CountOfPlaces = countOfPlaces;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Count of places: {0}\n", CountOfPlaces);
        }
    }
}
