string aux, opera = "";
int opc, repet = 0;
float num1, a, b, maxim, minim;
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
    Console.WriteLine("====================================");

    opc = opcionCorrecta();
    num1 = floatCorrecto();

    switch (opc)
    {
        case 1:
            opera = "El valor absoluto";
            resultado = Math.Abs(num1);
            break;
        case 2:
            opera = "El cuadrado";
            resultado = num1 * num1;
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

Console.WriteLine("Ingrese un numero A:");
a = floatCorrecto();
Console.WriteLine("Ingrese un numero B:");
b = floatCorrecto();

maxim = Math.Max(a, b);
minim = Math.Min(a, b);

Console.WriteLine($"El maximo fue: '{maxim}' y el minimo: '{minim}'");
Console.WriteLine($"...");

static int opcionCorrecta()
{
    bool flag = true;
    int opc = 0;
    while (flag)
    {
        string aux;
        Console.WriteLine("Ingrese una Opcion : ");
        aux = Console.ReadLine();
        if (int.TryParse(aux, out opc) && opc <= 6 && opc >= 1)
        {
            flag = false;
        }
        else
        {
            Console.WriteLine("Opcion incorrecta ");
            flag = true;
        }
    }
    return opc;
}

static float floatCorrecto()
{
    bool flag = true;
    float num = 0;
    while (flag)
    {
        string aux;
        Console.WriteLine("Ingrese un numero: ");
        aux = Console.ReadLine();
        if (float.TryParse(aux, out num))
        {
            flag = false;
        }
        else
        {
            Console.WriteLine("No es un numero!!");
            flag = true;
        }
    }
    return num;

}


float num2; 


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








