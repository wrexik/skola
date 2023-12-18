int max = Convert.ToInt32((Console.ReadLine()));

float pi = 3.14f;
int vysledek = 0;
int opak = 0;

///2pi r == 50

while (vysledek < max)
{
    opak = opak + 1;
    vysledek = 2 * Convert.ToInt32(pi) * opak;
    Console.WriteLine(" ");
    Console.Write("Polomer : "); Console.Write(opak); Console.WriteLine("cm");
    Console.Write("Vysledek : "); Console.Write(vysledek); Console.WriteLine("cm");
}
