using System.ComponentModel.DataAnnotations;
Start:


try
{
    int p;
    Console.WriteLine("Zadej kolik čísel bude mít pole :)");
    string p1 = Console.ReadLine();
    p = int.Parse(p1);
    int[] NoSort = new int[p];
    int[] Sort = new int[p];

    for (int i = 0; i < p; i++)
    {
        Console.WriteLine("Číslo na pozici {0}", i + 1);
        string input = Console.ReadLine();
        NoSort[i] = int.Parse(input);
    }
    int Max = 0;
    int poz = 0;
    for (int l = 0; l > p; l++)
    {
        if (NoSort[l] > Max)
        {

            Max = NoSort[l];
            poz = l;
        }
    }
    Console.WriteLine("Tato konzole vám vypíše vámi zadaná čísla, seřazená vzestupně");



    for (int l = 0; l < p; l++)
    {
        Console.WriteLine("Pozice {0} = {1}", l, Sort[l]);

    }
}
catch 
{
    Console.WriteLine("Zadali jste špatný vstup, zkuste znovu");
    goto Start;
}
