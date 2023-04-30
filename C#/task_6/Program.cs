int n = 10000;
while (n > 9999 && n < 99999)
{
    if ((n - n / 1000 * 1000) / 100 % 2 != 0 && n % 2 == 0)
    {
        int a = n, sum = 0;
        while (a > 0)
        {
            sum += a % 10;
            a /= 10;
        }

        if (sum % 4 == 0)
            Console.WriteLine("{0}", n);
    }
    n++;
}
Console.ReadLine();