/*
int[,] matrix = new int[3, 3];
int[,] new_matrix = new int[3, 3];

Console.WriteLine("Введите матрицу:");
for (int i = 0; i < 3; i++)
{
    string[] strok = Console.ReadLine().Split(' ');
    for (int j = 0; j < 3; j++)
        matrix[i, j] = int.Parse(strok[j]);
}
for (int i = 0; i < 3; i++)
    for (int j = 0; j < 3; j++)
        new_matrix[i, j] = matrix[j, i];

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
        Console.Write(new_matrix[i, j] + " ");
    Console.WriteLine();
}
*/