/*
const int size = 10;
int[] arr = new int[size];
Random rnd = new Random();
int count = 0;
bool found = false;

while (count < size)
{
    int buff = rnd.Next(1, size);

    for (int i = 0; i < count; i++)
    {
        if (arr[i] == buff)
        {
            found = true;
            break;
        }
    }

    arr[count] = buff;
    count++;
    if (found) break;
}

for (int i = 0; i < size; i++)
    Console.Write($"{arr[i]} ");
*/