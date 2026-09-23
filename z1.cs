/*
int n = int.Parse(Console.ReadLine());
int[] arr = new int[n];
double sr_arifmet = 0;

for (int i = 0; i < n; i++)
{
    arr[i] = i;
    sr_arifmet += i;
}

for (int i = n - 1; i >= 0; i--)
{
    Console.Write($"{arr[i]} ");
}
Console.WriteLine();
sr_arifmet /= n;
double minRaznost = 5;
int blignee = arr[0];
for (int i = 0; i < n; i++)
{
    double raznost = Math.Abs(sr_arifmet - arr[i]);
    if (raznost < minRaznost)
    {
        minRaznost = raznost;
        blignee = arr[i];
    }
}
Console.WriteLine($"Ближнее к ср.:{blignee}");
*/
