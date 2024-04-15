// BOJ_14248


int n = int.Parse(Console.ReadLine());
string[] stone = Console.ReadLine().Split(' ');
int start = int.Parse(Console.ReadLine());

bool[] vis = new bool[100005];
Queue<int> q = new Queue<int>();
q.Enqueue(start - 1);
int ans = 1;
vis[start - 1] = true;
while (q.Count > 0)
{
    var cur = q.Dequeue();
    int jump = int.Parse(stone[cur]);


    int left = cur - jump;
    int right = cur + jump;
    if (left >= 0 && !vis[left])
    {
        vis[left] = true;
        ans++;
        q.Enqueue(left);
    }
    if(right < n && !vis[right]) 
    {
        vis[right] = true;
        ans++;
        q.Enqueue(right);
    }
}

Console.WriteLine(ans);
