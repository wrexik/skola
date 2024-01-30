Start:
    try
    {
        Console.WriteLine("Zadejte pocet mist v poli: ");
        int feild_count = Convert.ToInt32(Console.ReadLine());

        int[] list1 = new int[feild_count];
        int[] list2 = new int[feild_count];
        int[] output = new int[feild_count];

        int i = -1;

        foreach (int val1 in list1)
        {
            ++i;

            Console.Write("Zadejte hodnotu {0} pro list 1: ", i);


            int cislo1 = Convert.ToInt32(Console.ReadLine());
            list1[Convert.ToUInt32(i)] = cislo1; // prida moznosti na dane pole do listu

            // cislo_pole = i + 1;
            //cislo_pole = Convert.ToInt32(cislo_pole);

            //Console.WriteLine("Uspesne zmeneno pole1: {0} na {1}", cislo_pole, list1[Convert.ToUInt32(i)]);

            Console.WriteLine(" ");
        }

        Console.WriteLine("Zadane hodnoty:");

        i = 0;

        foreach (int values in list1) // vypis vsech radku v poli + cislo
        {
            i = i + 1;
            Console.Write("Line(");
            Console.Write(i);
            Console.Write("): ");
            Console.WriteLine(values);
        }

        i = -1;
        Console.WriteLine(" ");
        Console.WriteLine("Nyni hodnoty listu 2");
        Console.WriteLine(" ");

        foreach (int val2 in list2)
        {
            ++i;

            Console.Write("Zadejte hodnotu {0} pro list 2: ", i);

            int cislo2 = Convert.ToInt32(Console.ReadLine());
            list2[Convert.ToUInt32(i)] = cislo2; // prida moznosti na dane pole do listu

            //int cislo_pole = i + 1;
            //cislo_pole = Convert.ToInt32(cislo_pole);

            //Console.WriteLine("Uspesne zmeneno pole2: {0} na {1}", cislo_pole, list2[Convert.ToUInt32(i)]);

            Console.WriteLine(" ");
        }

        Console.WriteLine("Zadane hodnoty:");
        Console.WriteLine(" ");

        i = 0;

        foreach (int values in list2) // vypis vsech radku v poli + cislo
        {
            i = i + 1;
            Console.Write("Line(");
            Console.Write(i);
            Console.Write("): ");
            Console.WriteLine(values);
        }

        i = -1;

        Console.WriteLine(" ");
        Console.WriteLine(" Vysledne sectene hodnoty: ");
        Console.WriteLine(" ");

        foreach (int values in output) // vypis vsech radku v poli + cislo
        {
            i = i + 1;
            output[i] = list1[i] + list2[i];
        }

        i = -1;

        foreach (int values in output) // vypis vsech radku v poli + cislo
        {
            i = i + 1;
            Console.Write("Line(");
            Console.Write(i);
            Console.Write("): ");
            Console.WriteLine(values);
        }
    }

catch (Exception)

    {
    Console.WriteLine(" ");
    Console.WriteLine("Špatný vstup");
    Console.WriteLine("");
    goto Start;
    }
