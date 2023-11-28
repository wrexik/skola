Console.WriteLine("Ahoj, vita te tva mega scitacka ♥");
Console.WriteLine("Napis znak operace: [+, -, *, /]");
string operace = Console.ReadLine();

if (operace == "+")
{
    Console.WriteLine("Napis cislo pro secteni");
    int cislo = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Napis druhe cislo pro secteni");
    int cislo2 = Convert.ToInt32(Console.ReadLine());

    int vysledek = cislo + cislo2;

    Console.Write("Vysledek: ");
    Console.WriteLine(vysledek);
}

if (operace == "-")
{
    Console.WriteLine("Napis cislo pro odecteni");
    int cislo = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Napis druhe cislo pro odecteni");
    int cislo2 = Convert.ToInt32(Console.ReadLine());

    int vysledek = cislo - cislo2;

    Console.Write("Vysledek: ");
    Console.WriteLine(vysledek);
}

if (operace == "*")
{
    Console.WriteLine("Napis cislo pro nasobeni");
    int cislo = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Napis druhe cislo pro nasobeni");
    int cislo2 = Convert.ToInt32(Console.ReadLine());

    int vysledek = cislo * cislo2;

    Console.Write("Vysledek: ");
    Console.WriteLine(vysledek);
}

if (operace == "/")
{
    Console.WriteLine("Napis cislo pro deleni");
    int cislo = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Napis druhe cislo pro deleni");
    int cislo2 = Convert.ToInt32(Console.ReadLine());

    int vysledek = cislo / cislo2;

    Console.Write("Vysledek: ");
    Console.WriteLine(vysledek);
}
