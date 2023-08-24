int a = new Random().Next(1,10);
int count = 1;

Console.WriteLine("a = " + a);

while (count <= a)
{
    if (count % 2 == 0) Console.Write(count + " ");
    count++;
}

