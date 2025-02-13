namespace CarApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CarAPP
            Console.Write("indtast bilmærke: ");
            string brand = Console.ReadLine();
            Console.Write("indtast bilmodel: ");
            string model = Console.ReadLine();
            Console.Write("indast årgang: ");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.Write("indtast geartypen (automatisk 'A' eller manuel 'M'): ");
            char gearType = Console.ReadLine()[0];
            Console.Write("indtast brandstofstype (diesel 'D' eller benzin 'B': ");
            char fuelType = Console.ReadLine()[0];

            double fuelprice;

            if (fuelType.Equals('D'))
            {
                fuelprice = 12.29;
            }
            else
            {
                fuelprice = 13.49;
            }

            Console.Write("indtast km/L: ");
            double kmL = Convert.ToDouble(Console.ReadLine());
            Console.Write("indtast kilomerstand: ");
            int kilometerstand = Convert.ToInt32(Console.ReadLine());
            Console.Write("hvor lang er din tur i km: ");
            double kmDriven = Convert.ToDouble(Console.ReadLine());

            double fuelneded = kmDriven / kmL;
            double tripCost = fuelneded * fuelprice;
            kilometerstand += Convert.ToInt32(kmDriven);

            Console.WriteLine(brand + " " + model + " fra " + year + " har gear: " + gearType + "\nhar brandstofstypen: " + fuelType +
                " nye kilometerstand: " + kilometerstand + " pris for brandstof brugt på turen: " + tripCost);
            //Console.Write($"\n{brand} {model} fra {year} har gear: {gearType}");
            string udskrift = string.Format("Brændstofudgifterne for {0} km er {1:.##} DKK", kmDriven, tripCost);
            Console.WriteLine(udskrift);
            char pad = '-';
            String udskrift2 = string.Format("{0}{1}{2}\n\n{3}\n{4}{5}{6}", "Bilmærke".PadRight(10), "|Model".PadRight(10), "|Kilometertal".PadLeft(1), "".PadLeft(35, pad),
                brand.PadRight(10), ("|" + model).PadRight(10), ("|" + kilometerstand).PadLeft(1));
            Console.WriteLine(udskrift2);
            Console.ReadLine();
        }
    }
}
