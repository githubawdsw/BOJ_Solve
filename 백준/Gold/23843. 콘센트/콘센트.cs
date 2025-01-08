// BOJ_23843


int[] inputnm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnm[0];
int m = inputnm[1];

int[] chargeTime = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

List<int> list = new List<int>();
for (int i = 0; i < n; i++)
{
    list.Add(chargeTime[i]);
}
list = list.OrderByDescending(x => x).ToList();

int[] outlet = new int[12];
int idx = 0;
for (int i = 0; i < n; i++)
{
    if (idx == 0)
    {
        outlet[idx] += list[i];
        idx = (idx + 1) % m;
        continue;
    }

    outlet[idx] += list[i];
    if (outlet[idx] == outlet[idx - 1])
        idx = (idx + 1) % m;
}

Console.WriteLine(outlet[0]);