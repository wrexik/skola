// Nastavení konzole
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.Title = "Numbers Comparator";

// Zadání počtu míst v poli.
int p;
Console.Write("Zadej počet míst v poli: "); 
string p1 = Console.ReadLine();
p = int.Parse(p1);
int[] numbersne = new int[p];

// Zadání čísel do jednotlivých pozic v poli.
for (int i = 0; i < p; i++)
{
    Console.Write("Zadej číslo pro pozici {0}: ", i + 1); 
    string vstup = Console.ReadLine();
    numbersne[i] = int.Parse(vstup);
}

// Vytvoření pole do kterého se budou dosazovat výsledná čísla + vyvolání funkce "Comparing Numbers"
int[] result = ComparingNumbers(numbersne, p);

// For pro vypsání čísel z pole "numbersne" od největšího po nejmenší.
Console.Write("Serazena cisla od nejvetsiho po nejmensi --> ");
for (int k = 0; k < result.Length; k++)
{
    Console.Write(result[k]);
    if (k < result.Length - 1)
        Console.Write(", ");
}
Console.WriteLine();

// Funkce pro porovnávání čísel a nalezení největších čísel v poli.
static int[] ComparingNumbers(int[] numbersne, int p)
{
    int[] result = new int[p];

    for (int j = 0; j < p; j++)
    {
        int max = 0;
        int poz = 0;
        for (int i = 0; i < p; i++)
        {
            if (numbersne[i] > max)
            {
                max = numbersne[i];
                poz = i;
            }
        }
        numbersne[poz] = 0;
        result[j] = max;
    }
    return result;
}

