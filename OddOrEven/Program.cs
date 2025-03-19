Console.WriteLine("Odd or Even");
Console.Write("Please enter a number: ");
int number = int.Parse(Console.ReadLine());

string result = number % 2 == 0 ? "even" : "odd";

Console.WriteLine(number + " is an " + result + " number.");