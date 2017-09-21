using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sport_store.SportStore
{
    class DefenceW : WinterSport
    {
        protected byte PercentageOfProtection;

        public DefenceW(string name, string manufacturer, string type, string material, int cost, byte petsentageOfProtection) : base (name, manufacturer, type, material, cost)
        {
            PercentageOfProtection = petsentageOfProtection;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Percentage of protaction: {0}\n", PercentageOfProtection);
        }
    }
}
