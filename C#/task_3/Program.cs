Console.Write("Введите число – > ");
int a = Convert.ToInt32(Console.ReadLine());
int a1 = a % 10;
string[] dv = { "двадцать ", "тридцать ", "сорок "};
string[] ch = {"одно", "два", "три", "четыре", "пять", "шесть", "семь", "восемь", "девять"};
string[] z = { " учебных задания", " учебных заданий", " учебное задание" };
string[] s = { "одиннадцать", "двенадцать", "тринадцать", "четырнадцать", "пятнадцать", "шестнадцать", "семнадцать", "восемнадцать", "девятнадцать" };
//нахождение первой цифры числа
int a2 = a;
while (a >= 10)
{
    a /= 10;
}
//составление слова 23-двадцатьтри
void chz()
{
    switch (a1)
    {
        case 1:
            Console.WriteLine(ch[0] + z[2]);
            break;
        case 2:
            Console.WriteLine(ch[1] + z[0]);
            break;
        case 3:
            Console.WriteLine(ch[2] + z[0]);
            break;
        case 4:
            Console.WriteLine(ch[3] + z[0]);
            break;
        case 5:
            Console.WriteLine(ch[4] + z[1]);
            break;
        case 6:
            Console.WriteLine(ch[5] + z[1]);
            break;
        case 7:
            Console.WriteLine(ch[6] + z[1]);
            break;
        case 8:
            Console.WriteLine(ch[7] + z[1]);
            break;
        case 9:
            Console.WriteLine(ch[8] + z[1]);
            break;

    }
}
if (a == 2 && a1 !=0)
{
    Console.Write(dv[0]);
    chz();
    
}else if (a == 2 && a1 == 0)
{
    Console.Write(dv[0] + z[1]);
}
else if (a==3 && a1 != 0)
{
    Console.Write(dv[1]);
    chz();
}else if (a == 3 && a1 == 0)
{
    Console.Write(dv[1] + z[1]);
}else if (a == 4 && a1 == 0)
{
    Console.Write(dv[2] + z[1]);
}else if (a == 1)
{
    switch (a2)
    {
        case 11:
            Console.WriteLine(s[0] + z[1]);
            break;
        case 12:
            Console.WriteLine(s[1] + z[1]);
            break;
        case 13:
            Console.WriteLine(s[2] + z[1]);
            break;
        case 14:
            Console.WriteLine(s[3] + z[1]);
            break;
        case 15:
            Console.WriteLine(s[4] + z[1]);
            break;
        case 16:
            Console.WriteLine(s[5] + z[1]);
            break;
        case 17:
            Console.WriteLine(s[6] + z[1]);
            break;
        case 18:
            Console.WriteLine(s[7] + z[1]);
            break;
        case 19:
            Console.WriteLine(s[8] + z[1]);
            break;
    }
}else
{
    Console.Write("Столько заданий нет");
}

Console.ReadLine();