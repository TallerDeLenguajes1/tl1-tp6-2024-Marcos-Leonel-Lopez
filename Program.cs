
// Console.WriteLine("Ingrese un numero: ");
// string aux;
// int num,resto;
// int invert =0;
// int c = 1;
// aux = Console.ReadLine();
// num = int.Parse(aux);

// Console.WriteLine($"Valor ingresado ={num}");

// while(num!= 0){
//     resto = num % 10;
//     num = (int)num / 10;
//     if(c==1)
//     {
//         invert = resto;
//     }
//     else{
//         invert = invert *10 + resto;
//     }
//     c++;

// }

// Console.WriteLine($"Valor invertido ={invert}");

string aux;
int opc,repet = 0;
float num1,num2; 
float resultado;

while (repet == 0)
{
Console.WriteLine("================MENU================");
Console.WriteLine(" 1 - SUMA");
Console.WriteLine(" 2 - RESTA");
Console.WriteLine(" 3 - PRODUCTO");
Console.WriteLine(" 4 - DIVISION");
Console.WriteLine("===================================");
Console.WriteLine("Ingrese una Opcion : ");
aux = Console.ReadLine();
opc = int.Parse(aux);

Console.WriteLine("1er numero: ");
aux = Console.ReadLine();
num1 = float.Parse(aux);
Console.WriteLine("2do numero: ");
aux = Console.ReadLine();
num2 = float.Parse(aux);


switch (opc)
{
    case 1:
        resultado = num1 + num2;
    break;
    case 2:
        resultado = num1 - num2;
    break;
    case 3:
        resultado = num1 * num2;
    break;
    case 4:
        resultado = num1 / num2;
    break;
    default:
        resultado = 0;
        break;
}

Console.WriteLine($"Resultado de  ={resultado}");

Console.WriteLine($"Quiere realizar otra operacion? S / N");
aux = Console.ReadLine();
if (aux == "n" || aux == "N")
{
    repet++;
}
    
}

Console.WriteLine($"...");








