﻿

string aux,opera = "";
int opc,repet = 0;
float num1; 
float resultado;

while (repet == 0)
{
Console.WriteLine("================MENU================");
Console.WriteLine(" 1 - VALOR ABSOLUTO");
Console.WriteLine(" 2 - CUADRADO");
Console.WriteLine(" 3 - RAIZ");
Console.WriteLine(" 4 - SENO");
Console.WriteLine(" 5 - COSENO");
Console.WriteLine(" 6 - PARTE ENTERA");
Console.WriteLine("===================================");
Console.WriteLine("Ingrese una Opcion : ");
aux = Console.ReadLine();
opc = int.Parse(aux);

Console.WriteLine("Ingrese un numero: ");
aux = Console.ReadLine();
num1 = float.Parse(aux);



switch (opc)
{
    case 1:
        opera = "El valor absoluto";
        if(num1 < 0){
            resultado = num1 * (-1);
        }else{
            resultado = num1;
        }
    break;
    case 2:
        opera = "El cuadrado";
        resultado = num1*num1;
    break;
    case 3:
        opera = "La raiz";
        resultado = (float)Math.Sqrt(num1);
    break;
    case 4:
        opera = "El seno";
        resultado = (float)Math.Sin(num1);
    break;
    case 5:
        opera = "El coseno";
        resultado = (float)Math.Cos(num1);
    break; 
    case 6:
        opera = "La parte enteroa";
        resultado = (float)Math.Floor(num1);
    break;   
    default:
        resultado = 0;
        break;
}

Console.WriteLine($"{opera} de {num1} es : {resultado}");

Console.WriteLine($"Quiere realizar otra operacion? S / N");
aux = Console.ReadLine();
if (aux == "n" || aux == "N")
{
    repet++;
}
    
}

Console.WriteLine($"...");


