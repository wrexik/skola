// Zadání prvního čísla
Console.WriteLine("Zadej prvni cislo pro soucet:");
string input1 = Console.ReadLine();
int num1 = int.Parse(input1);

// Zadání druhého čísla
Console.WriteLine("Zadej druhe cislo pro soucet:");
string input2 = Console.ReadLine();
int num2 = int.Parse(input2);

// Vypsání součtu dvou čísel
int sum = Soucet(num1, num2);
Console.WriteLine("Soucet dvou zadanych cisel -> {0}", sum);

// Funkce pro součet dvou zadaných čísel
static int Soucet(int num1, int num2)
{
	int sum = num1 + num2;
	return sum;
}