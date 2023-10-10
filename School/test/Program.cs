int num;
do
{
    Console.WriteLine("introduce un numero entre 1 y 9");
    num = Int32.Parse(Console.ReadLine());

} while (num < 1 || num > 9);
for (int i = 1; i < 10; i++)
    Console.WriteLine("{0}x{1} = {2}", num, i, num * i);