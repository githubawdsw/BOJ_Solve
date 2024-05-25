// BOJ_12018


int[] inputnm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnm[0];
int m = inputnm[1];

List<int> list = new List<int>();
for (int i = 0; i < n; i++)
{
    string[] inputpl = Console.ReadLine().Split();
    int p = int.Parse(inputpl[0]);
    int l = int.Parse(inputpl[1]);

    int[] inputMileage = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    if(l > p)
    {
        list.Add(1);
        continue;
    }

    inputMileage = inputMileage.OrderByDescending(x => x).ToArray();
    list.Add(inputMileage[l - 1]);
}

int sum = 0;
list.Sort();
for (int i = 0; i < list.Count; i++)
{
    sum += list[i];
    if(sum > m)
    {
        Console.WriteLine(i);
        return;
    }
}

Console.WriteLine(list.Count);