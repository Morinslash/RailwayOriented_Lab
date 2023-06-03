// See https://aka.ms/new-console-template for more information

using BasicExample;

Console.WriteLine("Hello, Railway Oriented Programming!");

var goodCalculation = Calculator.Add(5,3) //we are starting from first invocation of Add method on the Calculator -> returns Success<double> with Value 8
    .OnSuccess(sum => Calculator.Add(sum, 2)) // on Success<double> from line above we invoke OnSuccess and pass into it Calculator.Add as Func with parameters of Value(8) and 2 -> return Success<double> with Value 10
    .OnSuccess(sum => Calculator.Divide(sum, 5)) // on Success<double> from line above we invoke OnSuccess and pass into it Calculator.Divide as Func with parameters of Value(10) and 5 -> return Success<double> with Value 2
    .OnFailure(message => Console.WriteLine($"An Error Occurred: {message}")); // on Success<double> from previous line we invoke OnFailure and it will return the same object -> returns Success<double> with Value 2

if (goodCalculation is Success<double> s) // checking if the result is type Success
{
    Console.WriteLine($"The result is: {s.Value}"); // we are printing the Value 2 to the console
}

var badCalculation = Calculator.Add(5,3) //we are starting from first invocation of Add method on the Calculator -> returns Success<double> with Value 8
    .OnSuccess(sum => Calculator.Add(sum, 2)) // on Success<double> from line above we invoke OnSuccess and pass into it Calculator.Add as Func with parameters of Value(8) and 2 -> return Success<double> with Value 10
    .OnSuccess(sum => Calculator.Divide(sum, 0)) // on Success<double> from line above we invoke OnSuccess and pass into it Calculator.Divide as Func with parameters of Value(10) and 0 -> return Failure<message> with Message "Attempt to divide by zero". from the thrown exception
    .OnFailure(message => Console.WriteLine($"An Error Occurred: {message}")); // on Failure<string message> we are invoking the OnFailure method passing in it action of Console.WriteLine to print out the error that occured during calculations 

if (badCalculation is Success<double> fail) // checking if the result is type Success
{
    Console.WriteLine($"The result is: {fail.Value}"); // we skip this step
}