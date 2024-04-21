Console.Title = "C# Chess";

string[,] pole = new string[8, 8];

InitBoard();

while (true)
{
    Console.Clear();
    DisplayBoard();
    Console.WriteLine();

    Console.Write("Chcete pohybovat s figurkami v poli? (A/N): ");
    string ans = Console.ReadLine().ToUpper();

    Console.WriteLine();

    if (ans == "A")
    {
        Console.Write("Zadejte pozici figurky, kterou chcete pohnout (napø. A2): ");
        string sourcePos = Console.ReadLine().ToUpper();

        Console.Write("Zadejte cílovou pozici (napø. A4): ");
        string targetPos = Console.ReadLine().ToUpper();

        MovePiece(sourcePos, targetPos);
    }
    else if (ans == "N")
    {
        Console.WriteLine("Konzole bude ukonèena!");
        Environment.Exit(0);
    }
    else
    {
        Console.WriteLine("Zadání bylo chybné!");
    }
}

void InitBoard()
{
    pole[0, 0] = "V";
    pole[0, 1] = "K";
    pole[0, 2] = "S";
    pole[0, 3] = "Q";
    pole[0, 4] = "R";
    pole[0, 5] = "S";
    pole[0, 6] = "K";
    pole[0, 7] = "V";

    for (int i = 0; i < 8; i++)
    {
        pole[1, i] = "P";
    }

    for (int i = 2; i < 6; i++)
    {
        for (int j = 0; j < 8; j++)
        {
            pole[i, j] = "-";
        }
    }

    for (int i = 0; i < 8; i++)
    {
        pole[6, i] = "P";
    }

    pole[7, 0] = "V";
    pole[7, 1] = "K";
    pole[7, 2] = "S";
    pole[7, 3] = "Q";
    pole[7, 4] = "R";
    pole[7, 5] = "S";
    pole[7, 6] = "K";
    pole[7, 7] = "V";
}

void DisplayBoard()
{
    Console.WriteLine("  Legenda:");
    Console.WriteLine("  V - Vìž");
    Console.WriteLine("  K - Jezdec");
    Console.WriteLine("  S - Støelec");
    Console.WriteLine("  Q - Dáma");
    Console.WriteLine("  R - Král");
    Console.WriteLine("  P - Pìšec");
    Console.WriteLine();
    Console.WriteLine("  ---------------------------------");

    for (int i = 7; i >= 0; i--)
    {
        Console.Write((i + 1) + " ");

        for (int j = 0; j < 8; j++)
        {
            Console.Write("| " + pole[i, j] + " ");
        }
        Console.Write("|");
        Console.WriteLine();
        Console.WriteLine("  ---------------------------------");
    }

    Console.WriteLine("    A   B   C   D   E   F   G   H");
}


void MovePiece(string sourcePos, string targetPos)
{
    int sourceRow = int.Parse(sourcePos[1].ToString()) - 1;
    int sourceCol = sourcePos[0] - 'A';
    int targetRow = int.Parse(targetPos[1].ToString()) - 1;
    int targetCol = targetPos[0] - 'A';

    if (sourceRow < 0 || sourceRow > 7 || sourceCol < 0 || sourceCol > 7 ||
        targetRow < 0 || targetRow > 7 || targetCol < 0 || targetCol > 7)
    {
        Console.WriteLine("Neplatná pozice!");
        return;
    }

    pole[targetRow, targetCol] = pole[sourceRow, sourceCol];
    pole[sourceRow, sourceCol] = "-";
}