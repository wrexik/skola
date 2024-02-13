// Pole s čísli
int[] num = { 5, 2, 3, 8, 10 };

// Volání funkce pro porovnávání čísel v poli
CompareNumbers(num);

// Vypsání čísel v poli od největšího po nejmenší
for (int i = 0; i < num.Length; i++)
{
    Console.WriteLine("Pozice {0} = {1}", i, num[i]);
}

// Funkce pro porovnávání čísel v poli
static void CompareNumbers(int[] num)
{
    int max = num[0];
    for (int i = 1; i < num.Length; i++)
    {
        if (num[i] > max) ;
        {
            max = num[i];
        }
    }
}
