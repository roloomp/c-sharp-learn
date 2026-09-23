/*
var dict = new Dictionary<string, string>();
while (true)
{
    Console.WriteLine("\nadd / find / view / exit");
    string cmd = Console.ReadLine();
    if (cmd == "exit")
        return;
    else if (cmd == "add")
    {
        Console.WriteLine("Имя:");
        string name = Console.ReadLine();
        Console.WriteLine("Номер:");
        string number = Console.ReadLine();
        dict[name] = number;
    }
    else if (cmd == "find")
    {
        string poisk = Console.ReadLine().ToLower();
        bool found = false;
        foreach (var kvp in dict)
        {
            if (kvp.Key.ToLower() == poisk)
            {
                Console.WriteLine($"Имя: {kvp.Key}, Номер: {kvp.Value}");
                found = true;
                break;
            }
        }
        if (!found) Console.WriteLine("Не найдено");
    }
    else if (cmd == "view")
    {
        foreach (var kvp in dict)
            Console.WriteLine($"Имя: {kvp.Key}, Номер: {kvp.Value}");
    }
    else
    {
        Console.WriteLine("Ошибка ввода");
    }
        
}
*/