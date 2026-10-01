{
    Console.WriteLine("Пароль: ");
    string p = Console.ReadLine();
    bool l = p.Length >= 8;
    bool d = p.Any(char.IsDigit);
    bool c = p.Any(char.IsUpper);
    bool s = p.Any(e => !char.IsLetterOrDigit(e));
    if (l & d & c & s)
    {
        Console.WriteLine("Надежный пароль");
    }
    else
    {
        Console.WriteLine("Ненадеждный пароль");
    }
}

{
    Console.WriteLine("Для ромбика цифрку: ");
    int d = int.Parse(Console.ReadLine());
    int m = d / 2;
    for (int i = 0; i <= m; i++)
    {
        int g = m - i;
        int s = 1 + 2 * i;
        Console.WriteLine(new string(' ', g) + new string('*', s));
    }
    for (int i = m - 1; i >= 0; i--)
    {
        int g = m - i;
        int s = 1 + 2 * i;
        Console.WriteLine(new string(' ', g) + new string('*', s));
    }
}

{
    Random g = new Random();
    string play = "yes";
    while (play == "yes")
    {
        int r = g.Next(1, 100);
        int a = 0;
        bool e = false;
        Console.WriteLine("Угадайте число от 1 до 100");
        while (e == false)
        {
            Console.WriteLine("Введите число: ");
            string d = Console.ReadLine();
            int de = int.Parse(d);
            if (de < 1 || de > 100)
            {
                Console.WriteLine("Число должно быть меньше 100 и больше 1");
                continue;
            }
            a++;
            if (de < r)
            {
                Console.WriteLine("Больше!");
            }
            else if (de > r)
            {
                Console.WriteLine("Меньше!");
            }
            else
            {
                Console.WriteLine("Угадали!!");
                Console.WriteLine("Количество попыток: " + a);
                e = true;
            }
        }
        Console.WriteLine("Хотите сыграть еще? (yes/no)");
        play = Console.ReadLine();
    }
}