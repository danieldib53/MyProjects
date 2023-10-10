int num1;
int num2;
string math;

Console.WriteLine("Please introduce your first number:");
num1 = Int32.Parse(Console.ReadLine());

Console.WriteLine("Please introduce your second number: ");
num2 = Int32.Parse(Console.ReadLine());

Console.WriteLine("type \n- to subtract\n+ to add\n/ to divide\n* to multiply\n% to get the remainder\nSelect and operator: ");
math = Console.ReadLine();

if (math == "-")
{
    Console.Write("The answer is : " + (num1 - num2));
}
else if (math == "+")
{
    Console.Write("The answer is : " + (num1 + num2));
}
else if (math == "/")
{
    Console.Write("The answer is : " + (num1 / num2));
}else if (math == "*")
{
    Console.Write("The answer is : " + (num1 * num2));
}
else
{
    Console.Write("The answer is : " + (num1 % num2));
}