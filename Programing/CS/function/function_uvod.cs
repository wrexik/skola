// Volani metody s parametry s navratovou hodnotou
int v = 2;
Console.WriteLine("Hodnota V je: {0}", v);

//Volame funkci
int max = Maximum(v);
Console.WriteLine("Maximalni hodnota je: {0}", max);

//Metoda s parametry
static int Maximum(int v)
{
    //Ve funkci se neco pocita...
    int m = v + 2;
    // Kontrolni v
    Console.WriteLine("Zvetsena hodnota je: {0}", m);
    return m;
}

