// BOJ_15235



int n = int.Parse(Console.ReadLine());
string[] inputarr =Console.ReadLine().Split(' ');

int[] eatAmount = new int[1005];
Queue<int> q = new Queue<int>();
for (int i = 0; i < n; i++)
{
    eatAmount[i] = int.Parse(inputarr[i]);
    q.Enqueue(i);
}

int time = 0;
int[] timeArr = new int[1005];
string ans = "";

while (q.Count > 0)
{
    var cur = q.Dequeue();
    time++;
    eatAmount[cur]--;
    if (eatAmount[cur] != 0)
        q.Enqueue(cur);
    else
        timeArr[cur] = time;
}

for (int i = 0; i < n; i++)
    ans += $"{timeArr[i]} ";

Console.WriteLine(  ans);
