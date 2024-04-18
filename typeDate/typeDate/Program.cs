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