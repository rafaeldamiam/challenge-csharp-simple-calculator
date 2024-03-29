// See https://aka.ms/new-console-template for more information

using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;
using System.Runtime.InteropServices;

string askOperation()
{
    Console.Write("Enter the operation (+, -, x, /): ");
    string operation = Console.ReadLine();

    return operation;
}

string askNumber()
{
    Console.Write("Enter the number: ");
    string number = Console.ReadLine();

    return number;
}

string addition(float n1, float n2)
{
    float plus = n1 + n2;

    return Convert.ToString(plus);
}
string subtraction(float n1, float n2)
{
    float minus = n1 - n2;

    return Convert.ToString(minus);
}
string multiplication(float n1, float n2)
{
    float times = n1 * n2;

    return Convert.ToString(times);
}
string division(float n1, float n2)
{
    float divide = n1 / n2;

    return Convert.ToString(divide);
}

float numberOne = float.Parse(askNumber());
string operation = askOperation();
float numberTwo = float.Parse(askNumber());
string result = " ";


switch(operation)
{
    case "+":
        result = addition(numberOne, numberTwo);
        break;
    case "-":
        result = subtraction(numberOne, numberTwo);
        break;
    case "x":
        result = multiplication(numberOne, numberTwo);
        break;
    case "/":
        result = division(numberOne, numberTwo);
        break;
    default:
        Console.WriteLine();
        break;
    }


Console.WriteLine("The operation calculed: {0} {1} {2} = {3}", numberOne, operation, numberTwo, result);
