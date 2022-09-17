Console.WriteLine("enter first number");
int a = int.Parse(Console.ReadLine()!);

Console.WriteLine("enter second number");
int b = int.Parse(Console.ReadLine()!);

int max = a;
int min = b;

if(b > max) max = b;
if(a < min) min = a;

Console.WriteLine($"max = {max} min = {min}");
