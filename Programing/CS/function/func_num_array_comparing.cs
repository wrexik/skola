int p;
Console.WriteLine("Zadej počet míst v poli");
string p1 = Console.ReadLine();
p = int.Parse(p1);
int[] numbersne = new int[p];


for (int i = 0; i < p; i++)
{
    Console.WriteLine("Zadej číslo pro pozici {0}", i + 1);
    string vstup = Console.ReadLine();
    numbersne[i] = int.Parse(vstup);
}

int[] result = ComparingNumbers(numbersne, p);

Console.WriteLine("Maximální hodnoty: " + string.Join(", ", result));

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

