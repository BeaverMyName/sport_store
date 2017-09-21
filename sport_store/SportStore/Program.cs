using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sport_store.SportStore
{
    class Program 
    {
        static void Main(string[] args)
        {
            Cyclotourism[] cycloT = new Cyclotourism[0];
            Leisure[] leisure = new Leisure[0];
            WinterSport[] winterS = new WinterSport[0];

            Menu(ref cycloT, ref leisure, ref winterS);
        }

        static public void Menu(ref Cyclotourism[] cycloT, ref Leisure[] leisure, ref WinterSport[] winterS)
        {
            while (true)
            {
                Console.Clear();

                Console.WriteLine("1. Cyclotourism\n2. Leisure\n3. Winter sport\n4. Show all inventory\n");
                int menu = Convert.ToInt32(Console.ReadLine());

                Console.Clear();

                switch (menu)
                {
                    case 1:
                        Console.WriteLine("1. Cycle\n2. Defence\n");
                        menu = Convert.ToInt32(Console.ReadLine());

                        Console.Clear();

                        if (menu == 1)
                        {
                            cycloT = Cycle(cycloT);
                        }
                        else if (menu == 2)
                        {
                            cycloT = DefenceC(cycloT);
                        }
                        break;
                    case 2:

                        Console.WriteLine("1. Sleeping bag\n2. Tant\n");
                        menu = Convert.ToInt32(Console.ReadLine());

                        Console.Clear();

                        if (menu == 1)
                        {
                            leisure = SleepingBag(leisure);
                        }
                        else if (menu == 2)
                        {
                            leisure = Tent(leisure);
                        }
                        break;
                    case 3:

                        Console.WriteLine("1. Skiing\n2. Defence\n");
                        menu = Convert.ToInt32(Console.ReadLine());

                        Console.Clear();

                        if (menu == 1)
                        {
                            winterS = Skiing(winterS);
                        }
                        else if (menu == 2)
                        {
                            winterS = DefenceW(winterS);
                        }
                        break;
                    case 4:

                        Console.WriteLine("All inventory:\n");

                        Console.WriteLine("Cyclotourism:\n");
                        for (int i = 0; i < cycloT.Length; i++)
                            cycloT[i].ShowInfo();
                         

                        Console.WriteLine("Leisure:\n");
                        for (int i = 0; i < leisure.Length; i++)
                            leisure[i].ShowInfo();

                        Console.WriteLine("Winter sports:\n");
                        for (int i = 0; i < winterS.Length; i++)
                            winterS[i].ShowInfo();

                        Console.WriteLine("Enter any key to return to the menu...");
                        Console.ReadKey();
                        break;
                }
            }
        }

        static public Cyclotourism[] Cycle(Cyclotourism[] cycloT)
        {
            Cyclotourism[] newCycloT = new Cyclotourism[cycloT.Length + 1];

            for (int i = 0; i < cycloT.Length; i++)
                newCycloT[i] = cycloT[i];

            Console.WriteLine("Enter name: ");
            string newName = Console.ReadLine();

            Console.WriteLine("Enter manefacturer: ");
            string newManufacturer = Console.ReadLine();

            Console.WriteLine("Enter cost: ");
            Int32.TryParse(Console.ReadLine(), out int newCost);

            Console.WriteLine("Enter type: ");
            string newType = Console.ReadLine();

            Console.WriteLine("Enter diameter of wheels: ");
            Double.TryParse(Console.ReadLine(), out double newDiameterOfWheels);

            Cycle newCycle = new Cycle(newName, newManufacturer, newCost, newType, newDiameterOfWheels);

            newCycloT[cycloT.Length] = newCycle;

            return newCycloT;
        }

        static public Cyclotourism[] DefenceC(Cyclotourism[] cycloT)
        {
            Cyclotourism[] newCycloT = new Cyclotourism[cycloT.Length + 1];

            for (int i = 0; i < cycloT.Length; i++)
                newCycloT[i] = cycloT[i];

            Console.WriteLine("Enter name: ");
            string newName = Console.ReadLine();

            Console.WriteLine("Enter manefacturer: ");
            string newManufacturer = Console.ReadLine();

            Console.WriteLine("Enter cost: ");
            Int32.TryParse(Console.ReadLine(), out int newCost);
            
            Console.WriteLine("Enter type: ");
            string newType = Console.ReadLine();

            Console.WriteLine("Enter material: ");
            string newMaterial = Console.ReadLine();

            DefenceC newCycle = new DefenceC(newName, newManufacturer, newCost, newType, newMaterial);

            newCycloT[cycloT.Length] = newCycle;

            return newCycloT;
        }

        static public Leisure[] SleepingBag(Leisure[] leisure)
        {
            Leisure[] newLeisure = new Leisure[leisure.Length + 1];

            for (int i = 0; i < leisure.Length; i++)
                newLeisure[i] = leisure[i];

            Console.WriteLine("Enter name: ");
            string newName = Console.ReadLine();

            Console.WriteLine("Enter manefacturer: ");
            string newManufacturer = Console.ReadLine();

            Console.WriteLine("Enter cost: ");
            Int32.TryParse(Console.ReadLine(), out int newCost);

            Console.WriteLine("Enter type: ");
            string newType = Console.ReadLine();

            Console.WriteLine("Enter material: ");
            string newMaterial = Console.ReadLine();

            Console.WriteLine("Enter minimal temperature: ");
            Double.TryParse(Console.ReadLine(), out double newMinTemperature);

            Console.WriteLine("Enter comfortable temperature: ");
            Double.TryParse(Console.ReadLine(), out double newComfTemperature);

            SleepingBag newSleepingBag = new SleepingBag(newName, newManufacturer, newType, newMaterial, newCost, newMinTemperature, newComfTemperature);

            newLeisure[leisure.Length] = newSleepingBag;

            return newLeisure;
        }

        static public Leisure[] Tent(Leisure[] leisure)
        {
            Leisure[] newLeisure = new Leisure[leisure.Length + 1];

            for (int i = 0; i < leisure.Length; i++)
                newLeisure[i] = leisure[i];

            Console.WriteLine("Enter name: ");
            string newName = Console.ReadLine();

            Console.WriteLine("Enter manefacturer: ");
            string newManufacturer = Console.ReadLine();

            Console.WriteLine("Enter cost: ");
            Int32.TryParse(Console.ReadLine(), out int newCost);

            Console.WriteLine("Enter type: ");
            string newType = Console.ReadLine();

            Console.WriteLine("Enter material: ");
            string newMaterial = Console.ReadLine();

            Console.WriteLine("Enter count of places: ");
            Byte.TryParse(Console.ReadLine(), out byte newCountOfPlaces);

            Tent newTent = new Tent(newName, newManufacturer, newType, newMaterial, newCost, newCountOfPlaces);

            newLeisure[leisure.Length] = newTent;

            return newLeisure;
        }

        static public WinterSport[] Skiing(WinterSport[] winterS)
        {
            WinterSport[] new_WinterS = new WinterSport[winterS.Length + 1];

            for (int i = 0; i < winterS.Length; i++)
                new_WinterS[i] = winterS[i];

            Console.WriteLine("Enter name: ");
            string newName = Console.ReadLine();

            Console.WriteLine("Enter manefacturer: ");
            string newManufacturer = Console.ReadLine();

            Console.WriteLine("Enter cost: ");
            Int32.TryParse(Console.ReadLine(), out int newCost);

            Console.WriteLine("Enter type: ");
            string newType = Console.ReadLine();

            Console.WriteLine("Enter material: ");
            string newMaterial = Console.ReadLine();

            Console.WriteLine("Enter length: ");
            Double.TryParse(Console.ReadLine(), out double newLength);

            Skiing newSkiing = new Skiing(newName, newManufacturer, newType, newMaterial, newCost, newLength);

            new_WinterS[winterS.Length] = newSkiing;

            return new_WinterS;
        }

        static public WinterSport[] DefenceW(WinterSport[] winterS)
        {
            WinterSport[] new_WinterS = new WinterSport[winterS.Length + 1];

            for (int i = 0; i < winterS.Length; i++)
                new_WinterS[i] = winterS[i];

            Console.WriteLine("Enter name: ");
            string newName = Console.ReadLine();

            Console.WriteLine("Enter manefacturer: ");
            string newManufacturer = Console.ReadLine();

            Console.WriteLine("Enter cost: ");
            Int32.TryParse(Console.ReadLine(), out int newCost);

            Console.WriteLine("Enter type: ");
            string newType = Console.ReadLine();

            Console.WriteLine("Enter material: ");
            string newMaterial = Console.ReadLine();

            Console.WriteLine("Enter percentage of protaction: ");
            byte newPercentageOfProtection = Convert.ToByte(Console.ReadLine());

            DefenceW newDefenceW = new DefenceW(newName, newManufacturer, newType, newMaterial, newCost, newPercentageOfProtection);

            new_WinterS[winterS.Length] = newDefenceW;

            return new_WinterS;
        }
    }
}
