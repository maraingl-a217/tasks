int end = 10;
int stolb = 10;
for (int c = 1; c <= 20; c++)
{
    for (int i = c; i <= end; i += stolb)
    {
        for (int j = 1; j <= stolb; j++)
        {
            Console.Write("{0} * {1} = {2}\t", i, j, i * j);
        }
        Console.WriteLine();
    }
}
Console.ReadLine();