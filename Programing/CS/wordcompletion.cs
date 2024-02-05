// © Diktátor a spol. s.r.o.

List<string> wordlist = new List<string> { "mokry", "maso", "mlynar", "maso", "makaron", "masozravy" }; //Seznam slov našeptávače ve stringu
string[] wordsarray = wordlist.ToArray(); // Převod slov z seznamu slov ve stringu do pole

// Zadání klíčových slov do našeptávače
Console.WriteLine("Zadejte klicova pismena pro zahajeni vyhledavani naseptavace mezi slovy"); 
string input = Console.ReadLine();

// While loop pro opakované hledání slov
while (true)
{
    if (!string.IsNullOrEmpty(input))
    {
        foreach (string word in wordsarray)  // Vypsání nalezených slov
        {
            if (word.StartsWith(input))
            {
                Console.WriteLine("Nalezené slovo: " + word);  
            }
        }
    }

    Console.WriteLine("Chcete pokracovat ve vyhledavani (ano/ne)?"); // Otázka pro pokračování ve vyhledávání slov
    string response = Console.ReadLine();

    if (response == "ne")  // Odpověď ne ukončí loop
    {
        Console.WriteLine("Vyhledavani naseptavace bylo ukonceno");
        break;
    }
    else if (response == "ano") // Odpověď ano -> program se zeptá na jiná klíčová slova
    {
        Console.WriteLine("Zadejte klicova pismena pro zahajeni vyhledavani naseptavace mezi slovy"); // Zadání klíčových slov do našeptávače
        input = Console.ReadLine();
    }
    else
    {
        Console.WriteLine("Neplatná odpověď. Zadejte 'ano' nebo 'ne'."); 
        input = ""; // Změna stringu input na prázdný string aby platilo "!string.IsNull0rEmpty" v řádku 11
    }
}
