// BOJ_23559


int[] inputnx = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnx[0];
int x = inputnx[1];

List<(int, int)> list = new List<(int, int)>();
int sum = 0;
for (int i = 0; i < n; i++)
{
    int[] inputAB = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

    int a = inputAB[0];
    int b = inputAB[1];

    list.Add((a, b));
    sum += b;
    x -= 1000;
}

list.Sort(new MyCompare());

for (int i = 0; i < n; i++)
{
    if(x >= 4000 && list[i].Item1 - list[i].Item2 >= 0)
    {
        x -= 4000;
        sum += list[i].Item1 - list[i].Item2;
    }
}

Console.WriteLine(sum);


class MyCompare : IComparer<(int, int)>
{
    public int Compare((int,int)x, (int,int) y)
    {
        return (y.Item1 - y.Item2) - (x.Item1 - x.Item2);
    }
}