Console.Write("Введите пароль: ");
string pass = Console.ReadLine();
for (int i = 0; i != 5; i++)
{
    Console.Write("Введите пароль повторно: ");
    string passxs = Console.ReadLine();
    if (pass == passxs)
    {
        Console.WriteLine("ВХОД в систему произведен");
        break;
    }
    else {
        Console.WriteLine("пароли не совпадают");
    }
}
Console.WriteLine("Пароль введен неправильно, попробуйте позже");
Console.ReadLine();