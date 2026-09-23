

var dict = new Dictionary<string, int>();

while (true)
{
    Console.WriteLine("\nexit or text");
    string cmd = Console.ReadLine();
    if (cmd == "exit")
        return;
    if (dict.ContainsKey(cmd))
        dict[cmd] += 1;
    else
        dict[cmd] = 1;
    foreach (var kvp in dict)
        Console.WriteLine($"{kvp.Key} : {kvp.Value}");
}