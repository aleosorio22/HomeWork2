Console.WriteLine("1. CONVERSION DE TIPOS");
Console.WriteLine("DECIMAL A ENTERO");
Console.WriteLine("Ingrese un número entero: ");
int enteroUsuario = Convert.ToInt32(Console.ReadLine());
decimal decimalResultado = Convert.ToDecimal(enteroUsuario);

Console.WriteLine($"Número entero: {enteroUsuario}");
Console.WriteLine($"Número decimal: {decimalResultado}");
Console.WriteLine("\nPresione Enter para continuar...");
Console.ReadLine();
Console.Clear();

//decimal a flotante 
Console.WriteLine("DECIMAL A FLOTANTE");
Console.WriteLine("Ingrese un número decimal: ");
decimal decimalUsuario = Convert.ToDecimal(Console.ReadLine());
float flotanteResultado = Convert.ToSingle(decimalUsuario);

Console.WriteLine($"Número decimal: {decimalUsuario}");
Console.WriteLine($"Número flotante: {flotanteResultado}");
Console.WriteLine("\nPresione Enter para continuar...");
Console.ReadLine();
Console.Clear();

//flotante a entero
Console.WriteLine("FLOTANTE A ENTERO");
Console.WriteLine("Ingrese un número flotante: ");
float flotanteUsuario = Convert.ToSingle(Console.ReadLine());
int enteroResultado = Convert.ToInt32(flotanteUsuario);

Console.WriteLine($"Número flotante: {flotanteUsuario}");
Console.WriteLine($"Número entero: {enteroResultado}");
Console.WriteLine("\nPresione Enter para continuar...");
Console.ReadLine();
Console.Clear();

//caracter a entero (ASCII)
Console.WriteLine("CARACTER A ENTERO");
Console.WriteLine("Ingrese un carácter: ");
char caracterUsuario = Convert.ToChar(Console.ReadLine());
int valorEntero = Convert.ToInt32(caracterUsuario);

Console.WriteLine($"Carácter: {caracterUsuario}");
Console.WriteLine($"Valor entero en ASCII: {valorEntero}");
Console.WriteLine("\nPresione Enter para continuar...");
Console.ReadLine();
Console.Clear();

//entero a caracter (ASCII)
Console.WriteLine("ENTERO A CARACTER");
Console.WriteLine("Ingrese un número entero: ");
int enteroUsuario1 = Convert.ToInt32(Console.ReadLine());
char caracterResultado = Convert.ToChar(enteroUsuario1);

Console.WriteLine($"Número entero: {enteroUsuario1}");
Console.WriteLine($"Carácter: {caracterResultado}");
Console.WriteLine("\nPresione Enter para continuar...");
Console.ReadLine();
Console.Clear();

//OPERACIONES CON TIPOS DE DATOS
Console.WriteLine("2. OPERACIONES CON TIPOS DE DATOS ");
//suma de dos enteros
Console.WriteLine("SUMA DE DOS ENTEROS");
Console.WriteLine("Ingrese el primer número entero: ");
int numero1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingrese el segundo número entero: ");
int numero2 = Convert.ToInt32(Console.ReadLine());

int suma = numero1 + numero2;

Console.WriteLine($"La suma de {numero1} y {numero2} es: {suma}");
Console.WriteLine("\nPresione Enter para continuar...");
Console.ReadLine();
Console.Clear();

//resta de dos decimales
Console.WriteLine("ESTA DE DOS DECIMALES");
Console.WriteLine("Ingrese el primer número decimal: ");
decimal decimalNumero1 = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Ingrese el segundo número decimal: ");
decimal decimalNumero2 = Convert.ToDecimal(Console.ReadLine());

decimal resta = decimalNumero1 - decimalNumero2;

Console.WriteLine($"La resta de {decimalNumero1} y {decimalNumero2} es: {resta}");
Console.WriteLine("\nPresione Enter para continuar...");
Console.ReadLine();
Console.Clear();

//multiplicacion de dos flotantes
Console.WriteLine("MULTIPLICACION DE DOS FLOTANTES");
Console.WriteLine("Ingrese el primer número flotante: ");
float flotanteNumero1 = Convert.ToSingle(Console.ReadLine());

Console.WriteLine("Ingrese el segundo número flotante: ");
float flotanteNumero2 = Convert.ToSingle(Console.ReadLine());

float multiplicacion = flotanteNumero1 * flotanteNumero2;

Console.WriteLine($"La multiplicación de {flotanteNumero1} y {flotanteNumero2} es: {multiplicacion}");

//division de dos numeros
Console.WriteLine("DIVISION DE DOS NUMEROS ENTEROS");
Console.WriteLine("Ingrese el numerador (número entero): ");
int numerador = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingrese el denominador (número entero diferente de cero): ");
int denominador = Convert.ToInt32(Console.ReadLine());

if (denominador != 0)
{
    int division = numerador / denominador;
    Console.WriteLine($"La división de {numerador} entre {denominador} es: {division}");
}
else
{
    Console.WriteLine("Error: No se puede dividir por cero.");
}
Console.WriteLine("\nPresione Enter para continuar...");
Console.ReadLine();
Console.Clear();

//modulo de dos enteros
Console.WriteLine("MODULO DE DOS ENTEROS");
Console.WriteLine("Ingrese el dividendo (número entero): ");
int dividendo = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingrese el divisor (número entero diferente de cero): ");
int divisor = Convert.ToInt32(Console.ReadLine());

if (divisor != 0)
{
    int modulo = dividendo % divisor;
    Console.WriteLine($"El módulo de {dividendo} entre {divisor} es: {modulo}");
}
else
{
    Console.WriteLine("Error: No se puede calcular el módulo con divisor cero.");
}
Console.WriteLine("\nPresione Enter para continuar...");
Console.ReadLine();
Console.Clear();

//USO DE CHAR & STRING
Console.WriteLine("3. USO DE CHAR & STRING");
Console.WriteLine("");

//imprimir  en mayusculas
Console.WriteLine("IMPRIMIR TEXTO EN MAYUSCULAS");
Console.WriteLine("Ingrese una cadena de texto: ");
string cadenaMayusculas = Console.ReadLine().ToUpper();
Console.WriteLine($"Cadena en mayúsculas: {cadenaMayusculas}");

Console.WriteLine("\nPresione Enter para continuar...");
Console.ReadLine();
Console.Clear();

//imprimir en minusculas
Console.WriteLine("IMPRIMIR TEXTO EN MINUSCULAS");
Console.WriteLine("Ingrese una cadena de texto: ");
string cadenaMinusculas = Console.ReadLine().ToLower();
Console.WriteLine($"Cadena en minúsculas: {cadenaMinusculas}");

Console.WriteLine("\nPresione Enter para continuar...");
Console.ReadLine();
Console.Clear();

//cadena al reves
Console.WriteLine("IMPRIMIR LA CADENA AL REVES");
Console.WriteLine("Ingrese una cadena de texto: ");
string cadenaReversa = Console.ReadLine();
char[] arrayCadenaReversa = cadenaReversa.ToCharArray();
Array.Reverse(arrayCadenaReversa);
string cadenaAlReves = new string(arrayCadenaReversa);
Console.WriteLine($"Cadena al revés: {cadenaAlReves}");

Console.WriteLine("\nPresione Enter para continuar...");
Console.ReadLine();
Console.Clear();

//buscar palabra
Console.WriteLine("BUSCAR UNA PALABRA EN LA CADENA");
Console.WriteLine("Ingrese una cadena de texto: ");
string cadenaTexto = Console.ReadLine();
Console.WriteLine("Ingrese la palabra a buscar: ");
string palabraBuscar = Console.ReadLine();
bool contienePalabra = cadenaTexto.Contains(palabraBuscar, StringComparison.OrdinalIgnoreCase);
Console.WriteLine($"La cadena {(contienePalabra ? "sí" : "no")} contiene la palabra '{palabraBuscar}'.");

Console.WriteLine("\nPresione Enter para continuar...");
Console.ReadLine();
Console.Clear();

//contar vocales
Console.WriteLine("CONTAR LAS VOCALES DE LA CADENA");
Console.WriteLine("Ingrese una cadena de texto: ");
string cadenaVocales = Console.ReadLine();
int contadorVocales = 0;

foreach (char caracter in cadenaVocales)
{
    if ("aeiouAEIOU".Contains(caracter))
    {
        contadorVocales++;
    }

}
Console.WriteLine($"Número de vocales en la cadena: {contadorVocales}");

Console.WriteLine("\nPresione Enter para continuar...");
Console.ReadLine();
Console.Clear();

//USO DE TIPO DE DATOS NUMERICOS
Console.WriteLine("4. USO DE TIPO DE DATOS");

//area de un triangulo
Console.WriteLine("AREA DE UN TRIANGUOLO");
Console.WriteLine("Ingrese la base del triángulo:");
float baseTriangulo = float.Parse(Console.ReadLine());

Console.WriteLine("Ingrese la altura del triángulo:");
float alturaTriangulo = float.Parse(Console.ReadLine());

float areaTriangulo = 0.5f * baseTriangulo * alturaTriangulo;

Console.WriteLine($"El área del triángulo es: {areaTriangulo}");

Console.WriteLine("\nPresione Enter para continuar...");
Console.ReadLine();
Console.Clear();

//volumen esfera
Console.WriteLine("VOLUME DE UNA ESFERA");
Console.WriteLine("Ingrese el radio de la esfera:");
double radioEsfera = double.Parse(Console.ReadLine());

double volumenEsfera = (4.0 / 3.0) * Math.PI * Math.Pow(radioEsfera, 3);

Console.WriteLine($"El volumen de la esfera es: {volumenEsfera}");

Console.WriteLine("\nPresione Enter para continuar...");
Console.ReadLine();
Console.Clear();

//distancia entre puntos
Console.WriteLine("DISTANCIA ENTRE DOS PUNTOS");
Console.WriteLine("Ingrese las coordenadas (x1, y1) del primer punto:");
double x1 = double.Parse(Console.ReadLine());
double y1 = double.Parse(Console.ReadLine());

Console.WriteLine("Ingrese las coordenadas (x2, y2) del segundo punto:");
double x2 = double.Parse(Console.ReadLine());
double y2 = double.Parse(Console.ReadLine());

double distancia = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

Console.WriteLine($"La distancia entre los dos puntos es: {distancia}");

Console.WriteLine("\nPresione Enter para continuar...");
Console.ReadLine();
Console.Clear();

//celcius a fahrenheit
Console.WriteLine("CELSIUS A FAHRENHEIT");
Console.WriteLine("Ingrese la temperatura en grados Celsius:");
double temperaturaCelsius = double.Parse(Console.ReadLine());

double temperaturaFahrenheit = (temperaturaCelsius * 9 / 5) + 32;

Console.WriteLine($"La temperatura en grados Fahrenheit es: {temperaturaFahrenheit}");

Console.WriteLine("\nPresione Enter para continuar...");
Console.ReadLine();
Console.Clear();

//fahrenheit a celsius
Console.WriteLine("FAHRENHEIT A CELSIUS");
Console.WriteLine("Ingrese la temperatura en grados Fahrenheit:");
double temperaturaFahrenheit1 = double.Parse(Console.ReadLine());

double temperaturaCelsius1 = (temperaturaFahrenheit1 - 32) * 5 / 9;

Console.WriteLine($"La temperatura en grados Celsius es: {temperaturaCelsius1}");

Console.WriteLine("\nEl programa finalizo. Enter para continuar...");
Console.ReadLine();
Console.Clear();