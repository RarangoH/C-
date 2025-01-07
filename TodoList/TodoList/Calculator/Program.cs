

Console.WriteLine("Hello!");
Console.WriteLine("Input the first number: ");

string firstNumber = Console.ReadLine();

int a =  int.Parse(firstNumber);

Console.WriteLine("Input the second number: ");

string secondNumber = Console.ReadLine();

int b = int.Parse(secondNumber);


Console.WriteLine("What do you want to do with those numbers?");
Console.WriteLine("[A]dd");
Console.WriteLine("[S]ubtract");
Console.WriteLine("[M]ultiply");

string operation = Console.ReadLine().ToUpper();


if(operation == "A")
{
    Console.WriteLine(addition(a, b));
    
}else if(operation == "S")
{
    Console.WriteLine(subtraction(a, b));
    
}else if (operation == "M")
{
    Console.WriteLine(multiplication(a, b));
    
}
else
{
    Console.WriteLine("Incorrect Operation");
}
int addition(int first, int second)
{
    return (first + second);
}

int subtraction(int first, int second)
{
    return first - second;

}
int multiplication(int first, int second)
{

    return first * second;
}

Console.Read();
