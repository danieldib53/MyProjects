
int a = 0;
int b = 0;
int c = 0;

Console.Write("Introduce el valor de a :");
a = Int32.Parse(Console.ReadLine());

Console.Write("Introduce el valor de b :");
b = Int32.Parse(Console.ReadLine());

Console.Write("Introduce el valor de c :");
c = Int32.Parse(Console.ReadLine());

if (a > b && a > c)
{
    Console.Write("A es mayor");
}else if ( b > a && b > c)
{
    Console.Write("B es mayor");
}else if ( c > b && c > a)
{
    Console.Write("C es mayor");
} else
{
    Console.Write("No se puede introducir numeros iguales");
    Console.ReadLine();
}
    
