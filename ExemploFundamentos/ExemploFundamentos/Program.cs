// using ExemploFundamentos.Models;

// Person person = new()
// {
//     Name = "Luiz",
//     Age = 20
// };

// DateTime currentDate = DateTime.Now.AddHours(3);
// Console.WriteLine(currentDate.ToString("dd/MM/yyyy HH:mm"));

// person.Introduce();

// string introduction = "Hello, welcome";
// int quantity = 1;
// double height = 1.80;
// decimal price = 1.80M;
// bool condition = true;

// Console.WriteLine(introduction);
// Console.WriteLine($"Value of the \"quantity\" variable: {quantity}");
// Console.WriteLine($"Value of the \"height\" variable: {height:0.00}");
// Console.WriteLine($"Value of the \"price\" variable: {price}");
// Console.WriteLine($"Value of the \"condition\" variable: {condition}");

// int stringToIntConvert = Convert.ToInt32("5");
// int stringToIntParse = int.Parse("5");

// Console.WriteLine($"stringToIntConvert: {stringToIntConvert}");
// Console.WriteLine($"stringToIntParse: {stringToIntParse}");

// try {
//     int stringToIntParseFail = int.Parse("5c");
// } catch (Exception err) {
//     Console.WriteLine($"Failed to convert string \"5c\" to int: {err}");
// }

// int nullToIntConvert = Convert.ToInt32(null);
// // int nullToIntParse = int.Parse(null); throws exception

// Console.WriteLine($"nullToIntConvert: {nullToIntConvert}");

// string intToStringConcat = "" + 5;
// string intToString = 5.ToString();

// Console.WriteLine($"intToStringConcat: {intToStringConcat}");
// Console.WriteLine($"intToString: {intToString}");

// int a = 5;
// double intToDouble = a;
// long intToLong = a;

// Console.WriteLine($"intToDouble: {intToDouble}");
// Console.WriteLine($"intToLong: {intToLong}");

// long b = 5L;
// double c = 5.7D;
// decimal d = 5.70M;
// int longToInt = (int)b;
// int doubleToInt = (int)c;
// int decimalToInt = (int)d;

// Console.WriteLine($"longToInt: {longToInt}");
// Console.WriteLine($"doubleToInt: {doubleToInt}");
// Console.WriteLine($"decimalToInt: {decimalToInt}");

// try {
//     int maxDoubleToInt = Convert.ToInt32(double.MaxValue);
//     Console.WriteLine($"maxDoubleToInt: {maxDoubleToInt}");
// } catch (Exception err) {
//     Console.WriteLine($"Error when converting max double to int: {err}");
// }

// try {
//     int maxLongToInt = Convert.ToInt32(long.MaxValue);
//     Console.WriteLine($"maxLongToInt: {maxLongToInt}");
// } catch (Exception err) {
//     Console.WriteLine($"Error when converting max long to int: {err}");
// }

// try {
//     double maxIntToDouble = int.MaxValue;
//     Console.WriteLine($"maxIntToDouble: {maxIntToDouble}");
// } catch (Exception err) {
//     Console.WriteLine($"Error when converting max int to double: {err}");
// }

// try {
//     long maxIntToLong = int.MaxValue;
//     Console.WriteLine($"maxIntToLong: {maxIntToLong}");
// } catch (Exception err) {
//     Console.WriteLine($"Error when converting max int to long: {err}");
// }

// double division1 = 4 / 2 + 2;
// Console.WriteLine(division1); // 4

// double division2 = 4 / (2 + 2);
// Console.WriteLine(division2); // 1

// int.TryParse("15-", out int stringToIntTryParse);
// Console.WriteLine($"stringToIntTryParse fail: {stringToIntTryParse}"); // 0

// int defaultInt = 9;
// int.TryParse("15-", out defaultInt);
// Console.WriteLine($"defaultInt TryParse fail: {defaultInt}"); // 0

// int defaultInt2 = 9;
// int.TryParse("15", out defaultInt2);
// Console.WriteLine($"defaultInt TryParse success: {defaultInt2}"); // 15

// ---------------------------------

// int stockQuantity = 3;
// int purchaseQuantity = 4;
// bool purchasePossible = purchaseQuantity > 0 && stockQuantity >= purchaseQuantity;

// Console.WriteLine($"Quantity in stock: {stockQuantity}");
// Console.WriteLine($"Quantity being purchased: {purchaseQuantity}");
// Console.WriteLine($"Is the purchase possible? {(purchasePossible ? "Yes, it is" : "No, it isn't")}.\n");

// if (purchaseQuantity == 0) {
//     Console.WriteLine("Invalid purchase.");
// } else if (purchasePossible) {
//     Console.WriteLine("Purchase completed.");
// } else {
//     Console.WriteLine("Sorry, we don't have enough of this item in stock to complete this purchase.");
// }

// ---------------------------------

// using System.Text.RegularExpressions;

// Console.WriteLine("Type a letter");
// string? letter = Console.ReadLine();

// static bool matchIgnoreCase (string pattern, string value) {
//     return new Regex(pattern, RegexOptions.IgnoreCase).IsMatch(value);
// }

// switch (letter?.Trim()) {
//     case var notNullish when string.IsNullOrWhiteSpace(notNullish):
//         Console.WriteLine("Type something other than white space.");
//         break;
//     case var length when length?.Length > 1:
//         Console.WriteLine("More than one character used.");
//         break;
//     case var isLetter when !matchIgnoreCase("^[a-z]$", isLetter!):
//         Console.WriteLine("This is not a letter.");
//         break;
//     case var a when matchIgnoreCase("^a|e|i|o|u$", a!):
//         await Task.Delay(500);
//         Console.WriteLine("Thanks.");
//         await Task.Delay(1500);
//         Console.WriteLine("Yeah, this is a vowel.");
//         await Task.Delay(1000);
//         break;
//     default:
//         await Task.Delay(500);
//         Console.WriteLine("Thanks.");
//         await Task.Delay(1500);
//         Console.WriteLine("Yeah, this is a consonant.");
//         await Task.Delay(1000);
//         break;
// }

// ---------------------------------

// bool isOfAge = false;
// bool isAuthorizedByLegalGuardian = true;

// if (isOfAge || isAuthorizedByLegalGuardian) {
//     Console.WriteLine("Entrance cleared.");
// } else {
//     Console.WriteLine("Entrance denied.");
// }

// ---------------------------------

// bool hasMinimalAttendance = true;
// double mean = 7.5;

// if (hasMinimalAttendance && mean >= 7) {
//     Console.WriteLine("You passed!");
// } else {
//     Console.WriteLine("You failed.");
// }

// ---------------------------------

// bool itHasRained = true;
// bool itIsLate = true;

// if (!itHasRained && !itIsLate) {
//     Console.WriteLine("Let's ride!");
// } else {
//     Console.WriteLine("I'll ride tomorrow.");
// }

// ---------------------------------

using ExemploFundamentos.Common.Models;

Calculator.Sum(2, 3);
Calculator.Subtract(2, 3);
Calculator.Multiply(2, 3);
Calculator.Divide(2, 3);
Calculator.Increment(2);
Calculator.Decrement(2);
Calculator.Power(2, 3);
Calculator.Remainder(2, 3);
Calculator.Sin(30);
Calculator.Cos(30);
Calculator.Tan(30);
Calculator.SquareRoot(81);

// ---------------------------------

// int number = 10;
// int loops = 10;

// for (int i = 0; i < loops; i++) {
//     int loop = i + 1;
//     Console.WriteLine($"{number} * {loop} = {number * loop}");
// }

// ---------------------------------

// int number = 10;
// int loops = 10;
// int counter = 0;

// while (counter < loops) {
//     counter++;
//     Console.WriteLine($"{number} * {counter} = {number * counter}");

//     if (counter == 5) break;
// }

// ---------------------------------

// int sum = 0, number = 0;

// do {
//     Console.WriteLine("Type a number (0 finishes the sum)");

//     try {
//         number = Convert.ToInt32(Console.ReadLine());
//         sum += number;
//     } catch (Exception) {
//         Console.WriteLine("This is not a number");
//     }
// } while (number != 0);

// Console.WriteLine($"The sum of the numbers typed is: {sum}");

// ---------------------------------

// string? option;
// bool showMenu = true;

// while (showMenu) {
//     Console.Clear();
//     Console.WriteLine("Digite a sua opção");
//     Console.WriteLine("1 - Register customer");
//     Console.WriteLine("2 - Search customer");
//     Console.WriteLine("3 - Delete customer");
//     Console.WriteLine("4 - Exit");

//     option = Console.ReadLine()?.Trim();

//     switch(option) {
//         case "1":
//             Console.WriteLine("Customer registration");
//             break;
//         case "2":
//             Console.WriteLine("Customer search");
//             break;
//         case "3":
//             Console.WriteLine("Customer deletion");
//             break;
//         case "4":
//             Console.WriteLine("Bye!");
//             showMenu = false;
//             break;
//         default:
//             Console.WriteLine("Invalid option");
//             break;
//     }
// }

// Console.WriteLine("You've officially left the menu");
