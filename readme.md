# Punto 4

#### ¿`string` es un tipo por valor o un tipo por referencia?
`string` en C# es un **tipo por referencia**. Aunque `string` se comporta de manera similar a los tipos por valor debido a su inmutabilidad, en realidad es una referencia a un objeto en el heap.

#### ¿Qué secuencias de escape tiene el tipo `string`?
El tipo `string` en C# soporta las siguientes secuencias de escape:

- `\'` - Comilla simple
- `\"` - Comilla doble
- `\\` - Barra invertida
- `\0` - Carácter nulo
- `\a` - Alerta (campana)
- `\b` - Retroceso
- `\f` - Avance de página
- `\n` - Nueva línea
- `\r` - Retorno de carro
- `\t` - Tabulación horizontal
- `\v` - Tabulación vertical
- `\uFFFF` - Carácter Unicode (donde `FFFF` es un código hexadecimal)
- `\xFF` - Carácter Unicode de 2 dígitos hexadecimales (también puede ser de 4 dígitos si se especifican 4 dígitos hexadecimales)

#### ¿Qué sucede cuando utiliza el carácter `@` y `$` antes de una cadena de texto?
- El carácter `@` antes de una cadena de texto se utiliza para crear **literales de cadena textuales**. Esto significa que las secuencias de escape no se procesan y la cadena puede abarcar múltiples líneas. Ejemplo: `@"Esto es una \cadena literal\ y puede tener \ cualquier carácter"`

- El carácter `$` antes de una cadena de texto se utiliza para **interpolación de cadenas**. Esto permite incluir expresiones dentro de la cadena que serán evaluadas y reemplazadas por sus valores. Las expresiones se colocan dentro de llaves `{}`. Ejemplo: `$"El valor de x es {x}"`

- También es posible combinar `@` y `$` para crear **literales de cadena textuales con interpolación**. Ejemplo: `$@"El valor de x es {x} y esta es una cadena literal multilinea."`


