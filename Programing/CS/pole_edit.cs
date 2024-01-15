All:
try
{
    Console.WriteLine("Zadejte počet políček v poli");
    int p = Convert.ToInt32(Console.ReadLine());
    p = p + 1;
    string[] words = new string[p];

    while (true)
    {
        try
        {
            Console.WriteLine("Na jaké pozici chcete změnit písmeno?");
            int num_list = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Co to bude za písmeno?");
            string num_change = Console.ReadLine();

            words[Convert.ToUInt32(num_list)] = num_change;

            Console.WriteLine("Uspesne zmeneno: {0} na {1}", num_list, words[Convert.ToUInt32(num_list)]);

            Console.WriteLine("Chcete pokracovat?");
            string pokracovat = Console.ReadLine();

            if (pokracovat == "ne")
            {


                Console.Write(" ");
                int i = -1;

                foreach (string word in words)
                {
                    i = i + 1;
                    Console.Write(i);
                    Console.Write(" ");
                    Console.WriteLine(word);
                }
                break;
            }
        }


        catch
        {

            Console.WriteLine("Špatný vstup");

        }

    }
}
catch (Exception)
{

    Console.WriteLine("Špatný vstup");
    Console.WriteLine("");
    goto All;
}
