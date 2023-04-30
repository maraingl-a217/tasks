Console.WriteLine("Введите поступления на карту");
double obchpost = 0;
double obchspis = 0;
for (int i = 1; i != 4; i++)
{
    Console.Write("->");
    double post = Convert.ToDouble(Console.ReadLine());
    obchpost = post + post;
}
Console.WriteLine("Введите списания с карты");
for (int i = 1; i != 4; i++)
{
    Console.Write("->");
    double spis = Convert.ToDouble(Console.ReadLine());
    obchspis = spis + spis;
}
double ostatok = obchpost - obchspis;
Console.WriteLine("Остаток на карте: {0}", ostatok);