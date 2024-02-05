// Zvolení počtu míst v poli, zadání čísel do jednotlivých polí a nasledné vypsaní čísel od nejmenšího po největší

// Zadání počtu míst v poli

int p;
Console.WriteLine("Zadej počet míst v poli");
string p1 = Console.ReadLine(); // Zde dojde k zadání počtu míst v poli
p = int.Parse(p1);
int[] numbersne = new int[p]; // Pole s neseřazenými čísli 
int[] numbersse = new int[p]; // Pole s seřazenými čísli

// Zadání čísel do jednotlivých polí

for (int i = 0; i < p; i++)
{
    Console.WriteLine("Zadej číslo pro pozici {0}", i + 1);  // Zadání jednotlivých hodnot do každé pozice v poli.
    string vstup = Console.ReadLine();
    numbersne[i] = int.Parse(vstup);
}

// Porovnávání čísel v jednotlivých poli a hledání největších čísel

for (int j = 0; j < p; j++)
{
    int max = 0;
    int poz = 0;
    for (int i = 0; i < p; i++)  // Zde dochází k nalezení největší hodnoty v poli "numbersne"
    {
        if (numbersne[i] > max)
        {
            max = numbersne[i];
            poz = i;
        }
    }
    numbersne[poz] = 0; // Po nalezení největšího čísla v poli se daná pozice v poli změní na nulu.
    numbersse[j] = max; // Zde dojde k přepsání největšího nalezeného čísla z pole "numbersne" do pole "numbersse"
}

// Vypsání čísel v poli od nejmenšího po největší

Console.WriteLine("Čísla v poli seřazená od nejmenšího po největší");

for (int i = 0; i < p; i++)
{
    Console.WriteLine("Pozice {0} = {1}", i, numbersse[i]);
}