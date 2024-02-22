static int addition(int a,int b){
    return a+b;
};
Console.WriteLine(addition(1,2));

static long factorielle( int a ){
    if a == 0{return 1};
    long calcul = a;
    for(int i = a-1; i>0 ; i--){
        calcul = calcul * i;
        
    };
    return calcul;
}

Console.WriteLine(factorielle(15));

static int getSurface(int Base, int Hauteur){
    return (Base*Hauteur/2);
    
}
Console.WriteLine(getSurface(8,2));

static int resteDiv(int a,int b){
    return a%b;
}
Console.WriteLine(resteDiv(1,3));

static int increment(int n){
    return n+1;
}
Console.WriteLine(increment(3));