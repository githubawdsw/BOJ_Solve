// BOJ_7571


int[] inputnm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnm[0];
int m = inputnm[1];

List<(int, int)> list = new List<(int, int)>();
List<int> sumx = new List<int>();
List<int> sumy = new List<int>();
for (int i = 0; i < m; i++)
{
    int[] inputxy = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
	list.Add((inputxy[0], inputxy[1]));
	sumx.Add(inputxy[0]);
	sumy.Add(inputxy[1]);
}

sumx.Sort();
sumy.Sort();
int x = sumx[m / 2];
int y = sumy[m / 2];

int ans = int.MaxValue;
int sum = 0;
for (int i = 0; i < m; i++)
{
	sum += Math.Abs(x - list[i].Item1) + Math.Abs(y - list[i].Item2);
}
ans = Math.Min(sum, ans);
Console.WriteLine(ans);