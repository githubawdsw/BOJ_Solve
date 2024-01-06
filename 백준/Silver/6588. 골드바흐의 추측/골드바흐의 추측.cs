// BOJ_6588


using System.Text;

StringBuilder sb = new StringBuilder();

bool[] notPrimeCheck = new bool[1000005];
for (int i = 2; i * i <= 1000000; i++)
{
    if (notPrimeCheck[i])
        continue;
    for (int j = i + i; j <= 1000000; j += i)
        notPrimeCheck[j] = true;
}

int input;
while (true)
{
    input = int.Parse(Console.ReadLine());
    if (input == 0)
        break;

    for (int i = 3; i <= input; i++)
    {
        if (!notPrimeCheck[i] && !notPrimeCheck[input - i])
        {
            sb.AppendLine($"{input} = {i} + {input - i}");
            break;
        }
    }
}

Console.WriteLine(sb);
