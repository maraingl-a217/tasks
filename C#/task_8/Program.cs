Console.Write("Введите число-> ");
string str = Console.ReadLine();
int[] mas = new int[str.Length];
int count = 0;
foreach (char ch in str)
{
    mas[count] = int.Parse(ch.ToString());
    count++;
}
Console.WriteLine("Самоя большая цифра в этом числе это {0}", mas.Max());