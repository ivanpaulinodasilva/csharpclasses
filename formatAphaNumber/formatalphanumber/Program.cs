/*string first = "Hello";
string second = "World";
string result = string.Format("{0} {1}!", first, second);
Console.WriteLine(result);

decimal price = 123.45m;
int discount = 50;
Console.WriteLine($"Price: {price:C} (Save {discount:C})");

decimal pricete = 67.55m;
decimal salePrice = 59.99m;

string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (pricete - salePrice), price);

yourDiscount += $"A discount of {((price - salePrice)/price):P2}!"; //inserted
Console.WriteLine(yourDiscount);

decimal pricet = 67.55m;
decimal salePricet = 59.99m;

string yourDiscountt = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (pricet - salePricet), price);

Console.WriteLine(yourDiscount);

decimal tax = .36785m;
Console.WriteLine($"Tax rate: {tax:P2}");

decimal measuremente = 123456.78912m;
Console.WriteLine($"Measurement: {measuremente:N4} units");

decimal measurement = 123456.78912m;
Console.WriteLine($"Measurement: {measurement:N} units");

decimal pricee = 123.45m;
int discounte = 50;
Console.WriteLine($"Price: {pricee:C} (Save {discounte:C})");*/

///Exercício – Explorar a interpolação de cadeia de caracteres
/*int invoiceNumber = 1201;
decimal productShares = 25.4568m;
decimal subtotal = 2750.00m;
decimal taxPercentage = .15825m;
decimal total = 3185.19m;

Console.WriteLine($"Invoice Number: {invoiceNumber}");

Console.WriteLine($"   Shares: {productShares:N3} Product");
Console.WriteLine($"     Sub Total: {subtotal:C}");
Console.WriteLine($"           Tax: {taxPercentage:P2}");
Console.WriteLine($"     Total Billed: {total:C}");


//Como trabalhar com cadeias de caracteres preenchidas, 
string input = "Pad this";
 Console.WriteLine(input.PadLeft(12));

 Console.WriteLine(input.PadLeft(12, '-'));
 Console.WriteLine(input.PadRight(12, '-'));


//Adicionar a ID de Pagamento à saída, Adicionar uma linha de números acima da saída para confirmar mais facilmente o resultado
 string paymentId = "769C";
 string payeeName = "Mr. Stephen Ortega";

 var formattedLine = paymentId.PadRight(6);
 formattedLine += payeeName.PadRight(24);

 Console.WriteLine(formattedLine);
 Console.WriteLine("1234567890123456789012345678901234567890");*/

///Exercício – Concluir um desafio em que é preciso aplicar a interpolação de cadeias de caracteres a uma carta-modelo

/*string customerName = "Ms. Barros";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

// Your logic here

Console.WriteLine("Here's a quick comparison:\n");

string comparisonMessage = "";

// Your logic here

Console.WriteLine(comparisonMessage);*/

//O código a seguir é uma solução possível para o desafio da unidade anterior.

string customerName = "Ms. Barros";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

Console.WriteLine($"Dear {customerName},");
Console.WriteLine($"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.\n");
Console.WriteLine($"Currently, you own {currentShares:N} shares at a return of {currentReturn:P}.\n");
Console.WriteLine($"Our new product, {newProduct} offers a return of {newReturn:P}.  Given your current volume, your potential profit would be {newProfit:C}.\n");

Console.WriteLine("Here's a quick comparison:\n");

string comparisonMessage = "";

comparisonMessage = currentProduct.PadRight(20);
comparisonMessage += String.Format("{0:P}", currentReturn).PadRight(10);
comparisonMessage += String.Format("{0:C}", currentProfit).PadRight(20);

comparisonMessage += "\n";
comparisonMessage += newProduct.PadRight(20);
comparisonMessage += String.Format("{0:P}", newReturn).PadRight(10);
comparisonMessage += String.Format("{0:C}", newProfit).PadRight(20);

Console.WriteLine(comparisonMessage);
