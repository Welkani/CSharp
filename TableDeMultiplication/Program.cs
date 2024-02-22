Console.WriteLine("Entrer votre nombre : ");

int nombre1 = Convert.ToInt32(Console.ReadLine());
int n = nombre1;

Console.WriteLine("Entrer la taille de la table :");
int t = Convert.ToInt32(Console.ReadLine());

nombre1 -= n;
int nbEspacedeb = 15;
int nbEspacefin = 15;

Console.WriteLine(string.Concat(Enumerable.Repeat("-", 40)));
for(int i = 0; i<= t ; i++){
    if( i >= 10){nbEspacedeb=14;};
    if( i >= 100){nbEspacedeb=13;};
    if( i >= 1000){nbEspacedeb=12;};
    if( i >= 10000){nbEspacedeb=11;};
    Console.Write("|");
    Console.Write(string.Concat(Enumerable.Repeat(" ", nbEspacedeb)));
    Console.Write($"{i} x {n} = {nombre1}");
    Console.Write(string.Concat(Enumerable.Repeat(" ", nbEspacefin)));
    Console.WriteLine("|");
    nombre1 += n;
    if(nombre1 >=10 ){nbEspacefin=14;};
    if(nombre1 >=100 ){nbEspacefin=13;};
    if(nombre1 >=1000 ){nbEspacefin=12;};
    if(nombre1 >=10000 ){nbEspacefin=11;};
    
};
Console.WriteLine(string.Concat(Enumerable.Repeat("-", 40)));


