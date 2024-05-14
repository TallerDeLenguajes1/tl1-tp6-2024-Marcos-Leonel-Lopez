using System.Runtime.InteropServices;

Console.WriteLine("Ingrese un numero: ");


string aux;
int num,resto;
int invert =0;
int c = 1;
aux = Console.ReadLine();
num = int.Parse(aux);

Console.WriteLine($"Valor ingresado ={num}");

while(num!= 0){
    resto = num % 10;
    num = (int)num / 10;
    if(c==1)
    {
        invert = resto;
    }
    else{
        invert = invert *10 + resto;
    }
    c++;

}

Console.WriteLine($"Valor invertido ={invert}");