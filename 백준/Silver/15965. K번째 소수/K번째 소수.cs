// BOJ_15965


int k = int.Parse(Console.ReadLine());

bool[] check = new bool[50000005];
check[1] = true;

for (int i = 2; i * i < check.Length; i++)
{
    if (check[i])
        continue;
    for (int j = i; j * i < check.Length; j++)
    {
        check[j * i] = true;
    }
}

int count = 0;
for (int i = 2; i <= check.Length; i++)
{
    if (!check[i])
        count++;

    if (count == k)
    {
        Console.WriteLine(i);
        return;
    }
}