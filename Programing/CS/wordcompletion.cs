List<string> wordlist = new List<string> { "mokry", "maso", "mlynar", "maso", "makarom", "masozravy" };
string[] wordsarray = wordlist.ToArray();

Console.WriteLine("Zadejte neco");
string input = Console.ReadLine();

foreach (string word in wordsarray)
{
	if (word.StartsWith(input))
	{
		Console.WriteLine("Nalezené slovo: " + word);
	}
}
//ok
