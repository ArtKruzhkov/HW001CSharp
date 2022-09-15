Console.WriteLine("enter number");
int n = int.Parse(Console.ReadLine());
int x = 2;

while(x <= n)
{
    if(x % 2 == 0)
    {
        Console.Write(x+" ");

    }
    x++;
}