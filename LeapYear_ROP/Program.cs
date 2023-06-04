using LeapYear_ROP;

Console.WriteLine("Give me a year please!");
var userInput = Console.ReadLine();
var result = Parser.Convert(userInput)
    .OnSuccess(LeapChecker.IsLeap)
    .OnFailure(Console.WriteLine);

if (result is Success<int> year)
{
    Console.WriteLine($"{year.Value} is a leap year!");
}