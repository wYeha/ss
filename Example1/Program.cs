using Microsoft.VisualBasic;

int max;
int a = new Random().Next(1,100);
int b = new Random().Next(1,100);

Console.Write("a=");
Console.WriteLine(a);
Console.Write("b=");
Console.WriteLine(b);

if (a > b) max = a;
else max = b;

Console.Write("max=");
Console.WriteLine(max);