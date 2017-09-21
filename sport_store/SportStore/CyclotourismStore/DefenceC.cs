using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sport_store.SportStore
{
    class DefenceC : Cyclotourism
    {
        protected string Material;

        public DefenceC(string name, string manufacturer, int cost, string type, string material) : base (name, manufacturer, type, cost)
        {
            Material = material;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Material: {0}\n", Material);
        }
    }
}
