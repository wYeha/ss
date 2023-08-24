int a = new Random().Next(1, 10), b = new Random().Next(1, 10), c = new Random().Next(1, 10), max = a;
string s = $"a, b, c = {a}, {b}, {c}";
Console.WriteLine(s);

if (b > max) max = b;
if (c > max) max = c;

Console.WriteLine("max = " + max);