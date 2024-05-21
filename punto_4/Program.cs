// using System;
// string frase1, frase2, aux;
// int numCaracteres = 0,inicio = 0,fin = 0;
// // float num1, a, b, maxim, minim;
// // float resultado;
// // char espacio = ' ';
// Console.WriteLine("Escriba una oracion:");
// frase1 = Console.ReadLine();
// Console.WriteLine("Escriba otra oracion:");
// frase2 = Console.ReadLine();
// aux = frase1.Replace(" ","");
// numCaracteres = aux.Length;

// Console.WriteLine($"La frase '{frase1}' tiene {numCaracteres} caracteres");

// // aux = (string)frase1.Union(frase2);

// // Console.WriteLine($"Las  dos frases concatenadas '{aux}'");
// inicio = (Int32)numCaracteres/2;
// aux = frase1.Substring(inicio,5);

// Console.WriteLine($"Una subcadena de {frase1} es '{aux}'");

// foreach (var item in frase1)
// {
//     if(item != ' ')
//     {
//     Console.Write($"{item}");
//     }
// }


using System;

        
            // Pedir al usuario que ingrese la primera cadena de texto
            Console.WriteLine("Ingrese la primera cadena de texto:");
            string cadena1 = Console.ReadLine();

            // Obtener la longitud de la cadena y mostrar por pantalla
            int longitud = cadena1.Length;
            Console.WriteLine($"La longitud de la cadena es: {longitud}");

            // Pedir al usuario que ingrese la segunda cadena de texto
            Console.WriteLine("Ingrese la segunda cadena de texto:");
            string cadena2 = Console.ReadLine();

            // Concatenar ambas cadenas distintas
            string cadenaConcatenada = cadena1 + cadena2;
            Console.WriteLine($"La cadena concatenada es: {cadenaConcatenada}");

            // Extraer una subcadena de la primera cadena ingresada
            Console.WriteLine("Ingrese el índice inicial para extraer la subcadena:");
            int indiceInicio = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la longitud de la subcadena:");
            int longitudSubcadena = int.Parse(Console.ReadLine());
            string subcadena = cadena1.Substring(indiceInicio, longitudSubcadena);
            Console.WriteLine($"La subcadena extraída es: {subcadena}");

            // Calculadora simple
            Console.WriteLine("Ingrese el primer número:");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número:");
            double num2 = double.Parse(Console.ReadLine());

            // Realizar operaciones
            double suma = num1 + num2;
            double resta = num1 - num2;
            double multiplicacion = num1 * num2;
            double division = num1 / num2;

            // Mostrar resultados
            Console.WriteLine($"La suma de {num1} y {num2} es igual a: {suma}");
            Console.WriteLine($"La resta de {num1} y {num2} es igual a: {resta}");
            Console.WriteLine($"La multiplicación de {num1} y {num2} es igual a: {multiplicacion}");
            Console.WriteLine($"La división de {num1} y {num2} es igual a: {division}");

            // Recorrer la cadena de texto con un ciclo Foreach
            Console.WriteLine("Los caracteres de la cadena son:");
            foreach (char c in cadena1)
            {
                Console.WriteLine(c);
            }

            // Buscar la ocurrencia de una palabra determinada en la cadena ingresada
            Console.WriteLine("Ingrese la palabra a buscar en la cadena:");
            string palabraBuscar = Console.ReadLine();
            bool contienePalabra = cadena1.Contains(palabraBuscar);
            if (contienePalabra)
            {
                Console.WriteLine($"La cadena contiene la palabra \"{palabraBuscar}\".");
            }
            else
            {
                Console.WriteLine($"La cadena no contiene la palabra \"{palabraBuscar}\".");
            }

            // Convertir la cadena a mayúsculas y luego a minúsculas
            string cadenaMayusculas = cadena1.ToUpper();
            string cadenaMinusculas = cadena1.ToLower();
            Console.WriteLine($"Cadena en mayúsculas: {cadenaMayusculas}");
            Console.WriteLine($"Cadena en minúsculas: {cadenaMinusculas}");

            // Ingresar una cadena separada por caracteres determinados y mostrar por pantalla los resultados
            Console.WriteLine("Ingrese una cadena separada por comas:");
            string cadenaSeparada = Console.ReadLine();
            string[] partes = cadenaSeparada.Split(',');
            Console.WriteLine("Las partes de la cadena son:");
            foreach (string parte in partes)
            {
                Console.WriteLine(parte);
            }

            // Resolver una ecuación simple ingresada como cadena de caracteres
            Console.WriteLine("Ingrese una ecuación simple (ej. 582+2):");
            string ecuacion = Console.ReadLine();
            double resultadoEcuacion = ResolverEcuacion(ecuacion);
            Console.WriteLine($"El resultado de la ecuación {ecuacion} es: {resultadoEcuacion}");
        
        
        static double ResolverEcuacion(string ecuacion)
        {
            char[] operadores = { '+', '-', '*', '/' };
            foreach (char operador in operadores)
            {
                string[] partes = ecuacion.Split(operador);
                if (partes.Length == 2)
                {
                    double num1 = double.Parse(partes[0]);
                    double num2 = double.Parse(partes[1]);
                    switch (operador)
                    {
                        case '+':
                            return num1 + num2;
                        case '-':
                            return num1 - num2;
                        case '*':
                            return num1 * num2;
                        case '/':
                            return num1 / num2;
                    }
                }
            }
            throw new InvalidOperationException("Ecuación no válida");
        }
