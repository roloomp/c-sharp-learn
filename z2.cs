/*
Console.Write("Студентов: ");
int n = int.Parse(Console.ReadLine());
Console.Write("Предметов: ");
int m = int.Parse(Console.ReadLine());

int[,] arr = new int[n, m];
Random rnd = new Random();

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        arr[i, j] = rnd.Next(2, 6);
    }
}

for (int i = 0; i < n; i++)
{
    double sr = 0;
    for (int j = 0; j < m; j++)
    {
        sr += arr[i, j];
    }
    Console.WriteLine($"Студент {i+1}  Ср. Оценка: {Math.Round(sr / m, 2)}");
}
*/