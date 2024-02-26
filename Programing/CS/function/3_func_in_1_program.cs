using System.Threading.Channels;

class Program
{ 
static void Main()
    {
        Start:
        // Ptání se na počet čísel v polï
        Console.Write("Zadejte počet čísel v poli: ");
        if (int.TryParse(Console.ReadLine(), out int pocetCisel) && pocetCisel > 0)
        {
            
            int[] pole = new int[pocetCisel];

            // Zadání čísel do pole
            for (int i = 0; i < pocetCisel; i++)
            {
                Console.Write($"Zadejte číslo na pozici {i + 1}: ");
                if (int.TryParse(Console.ReadLine(), out int cislo))
                {
                    pole[i] = cislo;
                }
                else
                {
                    Console.WriteLine("Zadali jste špatný vstup. Zkuste to znovu");
                    i--; // Znovu načte číslo, aby se nepřepsalo jiné
                }
            }

            // Výpis výsledků
            Console.WriteLine($"Největší číslo: {Nejvetsi_Cislo(pole)}");
            Console.WriteLine($"Součet čísel: {Soucet(pole)}");
            Console.WriteLine($"Aritmetický průměr: {Prumer(pole)}");

            Ptaní:
            Console.WriteLine("Chcete pokračovat?");
            
            string odpo = Console.ReadLine();
            if ( odpo == "Ano" )
            {
                goto Start;

            }
            if (odpo == "Ne")
            {
                goto End;
            }
            else
            {
                Console.WriteLine("Zadali jste špatný vstup");
                goto Ptaní;

            }
        
        }
        else
        {
            Console.WriteLine("S nulou to nefunguje, zadejte jiné číslo");
        }
    End:
        {
            Console.WriteLine("Nashledanou");
        }
       

    }

    static int Nejvetsi_Cislo(int[] pole)
    {
        int nejvetsi = pole[0];
        foreach (int cislo in pole)
        {
            if (cislo > nejvetsi)
            {
                nejvetsi = cislo;
            }
        }
        return nejvetsi;
    }

    static int Soucet(int[] pole)
    {
        int soucet = 0;
        foreach (int cislo in pole)
        {
            soucet += cislo;
        }
        return soucet;
    }


    static double Prumer(int[] pole)
    {
        return Soucet(pole) / (double)pole.Length;
    }
    
    
}
