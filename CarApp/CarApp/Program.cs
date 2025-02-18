            //CarAPP
            Console.Write("Indtast bilmærke: ");
            string brand = Console.ReadLine();
            Console.Write("Indtast bilmodel: ");
            string model = Console.ReadLine();
            Console.Write("Indtast årgang: ");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.Write("Indtast geartypen (automatisk 'A' eller manuel 'M'): ");
            char gearType = Console.ReadLine()[0];
            Console.Write("Indtast brændstofstype (diesel 'D' eller benzin 'B': ");
            char fuelType = Console.ReadLine()[0];
            
            // I den første sektion har vi en blok at Write og Read kode. Vi vælger Write og ikke WriteLine fordi vi vil
            // holde det på samme linje. 
            // Vi definerer variabler for alle input der kommer ind.

            double fuelprice;

            if (fuelType.Equals('D'))
            {
                fuelprice = 12.29;
            }
            else
            {
                fuelprice = 13.48;
            }
            Console.Write("");

            // Her har vi defineret brændstoftypernes forskellige priser, så det er afgørende for den samlede pris, hvilken type
            // brændstof som bilen kører på.
            // Det har vi gjort med en forgrening - en if/else statement. Det har vi gjort simpelt, så i stedet for at skrive
            // begge udfald, ved vi bare, at hvis det ikke er diesel, så er det automatisk benzin.

            Console.Write("Indtast km/L: ");
            double kmL = Convert.ToDouble(Console.ReadLine());
            Console.Write("Indtast kilometerstand: ");
            int kilometerstand = Convert.ToInt32(Console.ReadLine());
            Console.Write("Hvor lang er din tur i km?: ");
            double kmDriven = Convert.ToDouble(Console.ReadLine());

            // Her bliver der defineret vores variabler som vi kan bruge til vores udregning af turens pris.

            double fuelneeded = kmDriven / kmL;
            double tripCost = fuelneeded * fuelprice;
            kilometerstand += Convert.ToInt32(kmDriven);

            // Nu hvor vi har fået en masse værdier ind i vores variabler, regner vi her med de forskellige variabler,
            // med brug af operatorer, for at finde ud af brændstofsforbruget og prisen på turen.
            // Disse to nye værdier definerer vi med det samme, som nye variabler.

            Console.WriteLine(brand + " " + model + " fra " + year + " har gear: " + gearType + "\nhar brandstofstypen: " + fuelType +
                " nye kilometerstand: " + kilometerstand + " pris for brandstof brugt på turen: " + tripCost);
            //Console.Write($"\n{brand} {model} fra {year} har gear: {gearType}");
            string udskrift = string.Format("Brændstofudgifterne for {0} km er {1:.##} DKK", kmDriven, tripCost);
            Console.WriteLine(udskrift);
            char pad = '-';
            String udskrift2 = string.Format("{0}{1}{2}\n\n{3}\n{4}{5}{6}", "Bilmærke".PadRight(10), "|Model".PadRight(10), "|Kilometertal".PadLeft(1), "".PadLeft(35, pad),
                brand.PadRight(10), ("|" + model).PadRight(10), ("|" + kilometerstand).PadLeft(1));
            Console.WriteLine(udskrift2);

            // Til sidst skal vi bruge Console.WriteLine for at udskriver alle vores variabler som facit på vores beregninger.
            // Vi bruger en string for at udskrive vores variabler for afstand og pris på turen.
            // Til sidst laver vi tabellen med en oversigt over tre af vores variabler - bilmærke, model og kilometerstand.
            // Vi laver tabellen med PadLeft og PadRight for at kunne lave vores opsætning af tabellen.