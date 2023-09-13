using System.Runtime.CompilerServices;

int First;
int Second;
int Result = 0;
string Opperator;
Console.Write("Enter First: ");
First = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter Second: ");
Second = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter Opperator: ");
Opperator = Console.ReadLine();
switch (Opperator)
{
    case "+":
        Result = First + Second;
        break;
    case "-":
        Result = First - Second;
        break;
    case "*":
        Result = First * Second;
        break;
    case "/":
        Result = First / Second;
        break;
    default: Console.Write("Invalid Operator");
        Result = 0;
        break;
}

Console.WriteLine(Result.ToString());