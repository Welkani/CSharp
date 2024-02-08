Console.WriteLine("Entrer votre opération : ");

int nombre1 = Convert.ToInt32(Console.ReadLine());
string operateur = Console.ReadLine();
int nombre2 = Convert.ToInt32(Console.ReadLine());   

int operation;

if (string.Equals(operateur,"+")){
    operation = (nombre1 + nombre2);    
}
else if(string.Equals(operateur,"-")){
    operation = (nombre1 - nombre2);

}
else if(string.Equals(operateur,"*")){
    operation = (nombre1 * nombre2);

}
else if(string.Equals(operateur,"/")) {
    operation = (nombre1 / nombre2) ;

}
Console.WriteLine($"Résultat : {operation}");

