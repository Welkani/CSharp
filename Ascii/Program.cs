
Console.WriteLine("Entrez votre paragraphe (terminer en appuyant sur Entrée deux fois):");

List<string> lines = new List<string>();
string line;
while (!string.IsNullOrWhiteSpace(line = Console.ReadLine()))
{
    lines.Add(line);
}

int maxLength = 0;
foreach (string l in lines)
{
    if (l.Length > maxLength)
    {
        maxLength = l.Length;
    }
}

Console.WriteLine($"Nombre de colonnes : {maxLength}");
Console.WriteLine($"Nombre de lignes : {lines.Count}");
Console.WriteLine("╔" + new string('═', maxLength+4) + "╗");

foreach (string l in lines)
{
    Console.WriteLine("║  " +l.PadRight(maxLength+2) + "║");
}

Console.WriteLine("╚" + new string('═', maxLength+4) + "╝");
    



