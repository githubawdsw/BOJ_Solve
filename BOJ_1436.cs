// BOJ_1436



int n = int.Parse(Console.ReadLine());

int count = 0;
for (int i = 666; i < 2700000; i++)
{
    if (i.ToString().Contains("666"))
        count++;
    if (count == n)
    {
        Console.WriteLine(i);
        break;
    }
}

