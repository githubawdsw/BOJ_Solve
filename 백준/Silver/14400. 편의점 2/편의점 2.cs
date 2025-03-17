// BOJ_14400


int n = int.Parse(Console.ReadLine());

List<int> xlist = new List<int>();
List<int> ylist = new List<int>();
List<(int, int)> houseList = new List<(int, int)>();
for (int i = 0; i < n; i++)
{
    int[] housePos = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    xlist.Add(housePos[0]);
    ylist.Add(housePos[1]);
    houseList.Add((housePos[0], housePos[1]));
}

xlist.Sort();
ylist.Sort();

int x = xlist[n / 2];
int y = ylist[n / 2];
long ans = 0;

for (int i = 0; i < n; i++)
{
    ans += Math.Abs(houseList[i].Item1 - x);
    ans += Math.Abs(houseList[i].Item2 - y);
}

Console.WriteLine(ans);