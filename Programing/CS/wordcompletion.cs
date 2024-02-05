List<string> wordlist = new List<string> { "mokry", "maso", "mlynar", "maso", "makarom", "masozravy" };
string[] wordsarray = wordlist.ToArray();

Console.WriteLine("Zadejte klicova pismena pro zahajeni vyhledavani naseptavace mezi slovy");
string input = Console.ReadLine();

while (true)
{
    foreach (string word in wordsarray)
    {
        if (word.StartsWith(input))
        {
            Console.WriteLine("Nalezené slovo: " + word);
        }
    }

    Console.WriteLine("Chcete pokracovat ve vyhledavani (ano/ne)?");
    string response = Console.ReadLine();

    if (response == "ne")
    {
        Console.WriteLine("Vyhledavani naseptavace bylo ukonceno");
        break;
    }
    else if (response == "ano")
    {
        Console.WriteLine("Zadejte klicova pismena pro zahajeni vyhledavani naseptavace mezi slovy");
        input = Console.ReadLine();
    }
    else
    {
        Console.WriteLine("Neplatná odpověď. Zadejte 'ano' nebo 'ne'.");
    }
}
