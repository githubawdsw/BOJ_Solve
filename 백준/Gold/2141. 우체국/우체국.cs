// BOJ_2141


int n = int.Parse(Console.ReadLine());
List<(long, long)> list = new List<(long, long)>();
long totalPeople = 0;
for (int i = 0; i < n; i++)
{
    int[] inputxa = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    int x = inputxa[0];
    int a = inputxa[1];
    totalPeople += a;
    list.Add((x, a));
}

list.Sort();
totalPeople++;
totalPeople /= 2;

long sum = 0;
for (int i = 0; i < n; i++)
{
    sum += list[i].Item2;
    if (sum >= totalPeople)
    {
        Console.WriteLine(list[i].Item1);
        break;
    }
}
