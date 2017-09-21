using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sport_store.SportStore
{
    class Skiing : WinterSport
    {
        protected double Length;

        public Skiing(string name, string manufacturer, string type, string material, int cost, double length) : base (name, manufacturer, type, material, cost)
        {
            Length = length;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Length: {0}\n", Length);
        }
    }
}
