using System;

int a = 0;
int b = 0;

Console.Write("Escribe el primer numero: ");
a = Int32.Parse(Console.ReadLine());


Console.Write("Escribe el segundo numero: ");
b = Int32.Parse(Console.ReadLine());

if (a > b)
{
    Console.Write("A es mayor");
}else if (a < b)
{
    Console.Write("B es Mayor");
}else
{
    Console.Write("Son iguales.");
}
