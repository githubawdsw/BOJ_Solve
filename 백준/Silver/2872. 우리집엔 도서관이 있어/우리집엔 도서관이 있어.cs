// BOJ_2872


int n = int.Parse(Console.ReadLine());
List<int> list = new List<int>();
for (int i = 0; i < n; i++)
{
    list.Add(int.Parse(Console.ReadLine()));
}

int count = n;
int idx = n - 1;
while (idx >= 0)
{
    if (list[idx--] == count)
        count--;
}


Console.WriteLine(count);