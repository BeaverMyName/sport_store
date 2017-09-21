using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sport_store.SportStore
{ 
    class Cycle : Cyclotourism
    {
        protected double DiameterOfWheels;

        public Cycle(string name, string manufacturer, int cost, string type, double diameterOfWheels) : base (name, manufacturer, type, cost)
        {
            DiameterOfWheels = diameterOfWheels;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Diameter of wheels: {0}\n", DiameterOfWheels);
        }
    }
}
