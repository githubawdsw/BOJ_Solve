// BOJ_5545


int n = int.Parse(Console.ReadLine());

int[] inputcost = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int dough = inputcost[0];
int topping = inputcost[1];

int doughCalory = int.Parse(Console.ReadLine());

List<int> list = new List<int>();
for (int i = 0; i < n; i++)
{
    list.Add(int.Parse(Console.ReadLine()));
}

list = list.OrderByDescending(x => x).ToList();

int ans = doughCalory / dough;
int sum = doughCalory;
for (int i = 0; i < list.Count; i++)
{
    sum += list[i];
    int cost = dough + topping * (i + 1);

    if (ans < sum / cost)
        ans = sum / cost;
}

Console.WriteLine(ans);