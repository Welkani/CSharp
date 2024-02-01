System.Console.WriteLine("------------Equation du premier degré---------");
System.Console.WriteLine("Entrez a :");
double a = Convert.ToDouble(System.Console.ReadLine());

System.Console.WriteLine("Entrez b :");
double b = Convert.ToDouble(System.Console.ReadLine());


if (a == 0)
{
    if (b == 0)
    {
        System.Console.WriteLine("L'équation a une infinité de solutions.");
    }
    else
    {
        System.Console.WriteLine("L'équation n'a pas de solution.");
    }
}
else
{

    double solution = -b / a;
    System.Console.WriteLine("La solution de l'équation est : x = " + solution);
}

System.Console.WriteLine("------------Equation du second degré---------");
System.Console.WriteLine("Entrez a :");
double c = Convert.ToDouble(System.Console.ReadLine());

System.Console.WriteLine("Entrez b :");
double d = Convert.ToDouble(System.Console.ReadLine());

System.Console.WriteLine("Entrez c :");
double e = Convert.ToDouble(System.Console.ReadLine());

double delta = d * d - 4 * c * e;

if (delta > 0)
{
    double x1 = (-d + Math.Sqrt(delta)) / (2 * c);
    double x2 = (-d - Math.Sqrt(delta)) / (2 * c);
    Console.WriteLine("Delta est superieur a 0, il y a donc deux solutions distinctes : ");
    Console.WriteLine("x1 = " + x1);
    Console.WriteLine("x2 = " + x2);
}
else if (delta == 0)
{
    double x = -d / (2 * c);
    Console.WriteLine("Delta est nul, il y a donc une seule solution x : ");
    Console.WriteLine("x = " + x);
}
else{
    Console.WriteLine("Il n'y a pas de solution");
}
