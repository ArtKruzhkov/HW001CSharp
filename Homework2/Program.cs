Console.WriteLine("enter first number");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("enter second number");
int b = int.Parse(Console.ReadLine());

Console.WriteLine("enter third number");
int c = int.Parse(Console.ReadLine());

int max = a;

if(b > max) max = b;
if(c > max) max = c;

Console.WriteLine($"max = {max}");