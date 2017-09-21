using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sport_store.SportStore
{ 
    class SleepingBag : Leisure
    {
        protected double MinTemperature;
        protected double ComfTemperature;

        public SleepingBag(string name, string manufacturer, string type, string material, int cost, double minTemperature, double comfTemperature) : base (name, manufacturer, type, material, cost)
        {
            MinTemperature = minTemperature;
            ComfTemperature = comfTemperature;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Minimal temperature: {0}\nComfortable temperature: {1}\n", MinTemperature, ComfTemperature);
        }
    }
}
