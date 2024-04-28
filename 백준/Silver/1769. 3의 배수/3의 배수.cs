// BOJ_1769


string x = Console.ReadLine();

int count = 0;
while (x.Length > 1)
{
    int length = x.Length;
    int sum = 0;
    for (int i = 0; i < length; i++)
    {
        sum += x[i] - '0';
    }

    count++;
    x = sum.ToString();
}

Console.WriteLine(count);

if (x == "3" || x == "6" || x == "9")
    Console.WriteLine("YES");
else
    Console.WriteLine("NO");