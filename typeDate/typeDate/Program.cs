//Ira tornar um erro
/*
int first = 2;
string second = "4";
int result = first + second;
Console.WriteLine(result);


//Jeito certo

int first = 2;
string second = "4";
string result = first + second;
Console.WriteLine(result);

//Coerção
int myInt = 3;
Console.WriteLine($"int: {myInt}");

//dá impotancia neste desenvolvimento
decimal myDecimal = myInt;
Console.WriteLine($"decimal: {myDecimal}");


//SEgundo bloco, mostra como é importante o uso de decimal, 
//pois ele é mais preciso na coerção

decimal myDecimal = 3.14m;
Console.WriteLine($"decimal: {myDecimal}");

//dá impotancia neste desenvolvimento
int myInt = (int)myDecimal;
Console.WriteLine($"int: {myInt}");



//Distinguir entre Decimal e float
decimal myDecimal = 1.23456789m;
float myFloat = (float)myDecimal;

Console.WriteLine($"Decimal: {myDecimal}");
Console.WriteLine($"Float  : {myFloat}");

//ToString() para converter um número em um string

int first = 5;
int second = 7;
string message = first.ToString() + second.ToString();
Console.WriteLine(message);


//string em um int usando o método auxiliar Parse()

string first = "5";
string second = "7";
int sum = int.Parse(first) + int.Parse(second);
Console.WriteLine(sum);

//string em um int usando a classe Convert

string value1 = "5";
string value2 = "7";
int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);
Console.WriteLine(result);


//coerção e a conversão de um decimal em um int

int value = (int)1.5m; // casting truncates
Console.WriteLine(value);

int value2 = Convert.ToInt32(1.5m); // converting rounds up
Console.WriteLine(value2);



//Exercício – Examinar o método TryParse()

//deve ocorrer um erro devido ser um string dentro de uma Int
string name = "Bob";
Console.WriteLine(int.Parse(name));


//método TryParse() para analisar uma cadeia de caracteres como um int
string value = "102";
int result = 0;
if (int.TryParse(value, out result))
{
   Console.WriteLine($"Measurement: {result}");
}
else
{
   Console.WriteLine("Unable to report the measurement.");
}

//usando o valor de int para string
string value = "102";
int result = 0;
if (int.TryParse(value, out result))
{
   Console.WriteLine($"Measurement: {result}");
}
else
{
   Console.WriteLine("Unable to report the measurement.");
}
Console.WriteLine($"Measurement (w/ offset): {50 + result}");


//usando o valor de string para int
string value = "bad";
int result = 2;
if (int.TryParse(value, out result))
{
   Console.WriteLine($"Measurement: {result}");
}
else
{
   Console.WriteLine("Unable to report the measurement.");
}

if (result > 0)
   Console.WriteLine($"Measurement (w/ offset): {50 + result}");

*/

/*Exercício – Concluir um desafio em que é preciso combinar 
valores de matriz de cadeia de caracteres como cadeias de 
caracteres e inteiros.*/

string[] values = { "12.3", "45", "ABC", "11", "DEF" };

decimal total = 0m;
string message = "";

foreach (var value in values)
{
    decimal number; // stores the TryParse "out" value
    if (decimal.TryParse(value, out number))
    {
        total += number;
    } else
    {
        message += value;
    }
}

Console.WriteLine($"Message: {message}");
Console.WriteLine($"Total: {total}");



/*int value1 = 11;
decimal value2 = 6.2m;
float value3 = 4.3f;

// Your code here to set result1
// Hint: You need to round the result to nearest integer (don't just truncate)
Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

// Your code here to set result2
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

// Your code here to set result3
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");


/// SOLUTION

int value1 = 11;
decimal value2 = 6.2m;
float value3 = 4.3f;

// The Convert class is best for converting the fractional decimal numbers into whole integer numbers
// Convert.ToInt32() rounds up the way you would expect.
int result1 = Convert.ToInt32(value1 / value2);
Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

decimal result2 = value2 / (decimal)value3;
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

float result3 = value3 / value1;
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");*/