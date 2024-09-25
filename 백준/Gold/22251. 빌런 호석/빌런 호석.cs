// BOJ_22251


int[] inputnkpx = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnkpx[0];
int k = inputnkpx[1];
int p = inputnkpx[2];
int x = inputnkpx[3];

List<int[]> list = new List<int[]>
{
    new int[] { 1,1,1,0,1,1,1 },
    new int[] { 0,0,1,0,0,1,0 },
    new int[] { 1,0,1,1,1,0,1 },
    new int[] { 1,0,1,1,0,1,1 },
    new int[] { 0,1,1,1,0,1,0 },
    new int[] { 1,1,0,1,0,1,1 },
    new int[] { 1,1,0,1,1,1,1 },
    new int[] { 1,0,1,0,0,1,0 },
    new int[] { 1,1,1,1,1,1,1 },
    new int[] { 1,1,1,1,0,1,1 }
};

int nl = n.ToString().Length;
string xs = x.ToString();
string target = "";
for (int i = 0; i < nl - xs.Length; i++)
{
    target += '0';
}
target += xs;

int ans = 0;
for (int i = 1; i <= n; i++)
{
    if (i == x)
        continue;

    string compare = i.ToString();
    while (compare.Length < target.Length)
    {
        compare = compare.Insert(0, "0");
    }
    int count = 0;
    for (int j = 0; j < target.Length; j++)
    {
        for (int l = 0; l < 7; l++)
        {
            if (list[target[j] - '0'][l] != list[compare[j] - '0'][l])
                count++;
        }
    }
    if (count <= p)
        ans++;
}
Console.WriteLine(ans);

