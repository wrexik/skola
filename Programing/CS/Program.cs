using System.Security.Principal;

Start:



Console.WriteLine("Zadejte pocet mist v poli: ");
int feild_count = Convert.ToInt32(Console.ReadLine()); 

int[] list1 = new int[feild_count];

int i = -1;

foreach (int val1 in list1)
{
    ++i;

    Console.Write("Zadejte hodnotu {0} pro list 1: ", i);


    int cislo1 = Convert.ToInt32(Console.ReadLine());
    list1[Convert.ToUInt32(i)] = cislo1; 

    Console.WriteLine(" ");
}

Console.WriteLine("Zadane hodnoty:");

i = 0;
Array.Sort(list1);
foreach (int values in list1) 
{
    i = i + 1;
    Console.Write("Řádek(");
    Console.Write(i);
    Console.Write("): ");
    Console.WriteLine(values);
}

i = -1;
Console.WriteLine(" ");
Console.WriteLine("Nyni hodnoty listu 2");
Console.WriteLine(" ");

//druhy array

Console.WriteLine("Zadejte pocet mist v poli: ");
feild_count = Convert.ToInt32(Console.ReadLine());  

int[] list2 = new int[feild_count];

foreach (int val2 in list2)
{
    ++i;

    Console.Write("Zadejte hodnotu {0} pro list 2: ", i);

    int cislo2 = Convert.ToInt32(Console.ReadLine());
    list2[Convert.ToUInt32(i)] = cislo2; 

    Console.WriteLine(" ");
}

Console.WriteLine("Zadane hodnoty:");
Console.WriteLine(" ");

i = 0;

foreach (int values in list2) 
{
    i = i + 1;
    Console.Write("Řádek(");
    Console.Write(i);
    Console.Write("): ");
    Console.WriteLine(values);
}



int[] output = new int[list1.Length + list2.Length]; 

i = -1;
int cislo_pole = -1;

foreach (int values in list1)
{
    Console.WriteLine(i);
    ++i; ++cislo_pole;
    output[cislo_pole] = list1[i];
}

i = -1;
cislo_pole = i + list2.Length;


foreach (int values in list2)
{
    Console.WriteLine(i);
    ++i; ++cislo_pole;
    output[cislo_pole] = list2[i];
}

i = -1;
Array.Sort(list2);
foreach (int values in output) 
{
    i = i + 1;
    Console.Write("Řádek(");
    Console.Write(i);
    Console.Write("): ");
    Console.WriteLine(values);
}