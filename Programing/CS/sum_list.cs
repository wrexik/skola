
int[] list1 = new int[4];
int[] list2 = new int[4];

int i = -1;

foreach (int val1 in list1) 
{
    ++i;

    int cislo1 = Convert.ToInt32(Console.ReadLine());
    list1[Convert.ToUInt32(i)] = cislo1; // prida moznosti na dane pole do listu

    int cislo_pole = i + 1;
    cislo_pole = Convert.ToInt32(cislo_pole);

    Console.Write("Debug: "); Console.WriteLine(i);
    Console.WriteLine("Uspesne zmeneno pole1: {0} na {1}", cislo_pole, list1[Convert.ToUInt32(i)]);
}

i = -1;

foreach (int val2 in list2)
{
    ++i;

    int cislo2 = Convert.ToInt32(Console.ReadLine());
    list2[Convert.ToUInt32(i)] = cislo2; // prida moznosti na dane pole do listu

    int cislo_pole = i + 1;
    cislo_pole = Convert.ToInt32(cislo_pole);

    Console.Write("Debug: "); Console.WriteLine(i);
    Console.WriteLine("Uspesne zmeneno pole2: {0} na {1}", cislo_pole, list2[Convert.ToUInt32(i)]);
}


