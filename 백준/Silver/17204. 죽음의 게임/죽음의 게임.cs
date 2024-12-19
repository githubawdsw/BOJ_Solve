// BOJ_17204


int[] inputnk = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnk[0];
int k = inputnk[1];

int[] target = new int[155];
bool[] vis = new bool[155];
for (int i = 0; i < n; i++)
{
    target[i] = int.Parse(Console.ReadLine());
}

int idx = 0;
int ans = 0;
while (!vis[idx] && idx != k)
{
    vis[idx] = true;
    ans++;
    idx = target[idx];
}

if(idx == k)
    Console.WriteLine(ans);
else
    Console.WriteLine(-1);