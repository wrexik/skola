using System.Security.Authentication.ExtendedProtection;

string[] words = new string[10];
Console.WriteLine("Chcete pokracovat?");
string pokracovat = Console.ReadLine();


while (pokracovat == "ano") {
    Console.WriteLine("ON");

    Console.WriteLine("Kde chcete změnit písmeno?");
    int num_list = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Co to bude za písmeno?");
    string num_change = Console.ReadLine();

    words[num_list] = num_change;

    Console.Write("Uspesne zmeneno: {0} na {1}", num_list, num_change);

    Console.WriteLine(words[num_list]);

    ///Console.WriteLine("Chcete pokracovat?");
    ///string pokracovat = Console.ReadLine();
}
