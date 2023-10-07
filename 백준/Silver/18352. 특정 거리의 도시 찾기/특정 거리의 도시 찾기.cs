// BOJ_18352

using System.Text;

StringBuilder sb = new StringBuilder();

string[] inputnmkx = Console.ReadLine().Split(' ');
int n = int.Parse(inputnmkx[0]);
int m = int.Parse(inputnmkx[1]);
int k  = int.Parse(inputnmkx[2]);
int x = int.Parse(inputnmkx[3]);

List<int>[] arrList = new List<int>[300005];
int[] dis = new int[300005];

for (int i = 0; i < m; i++)
{
    string[] inputAB = Console.ReadLine().Split(" ");
    int a = int.Parse(inputAB[0]);
    int b = int.Parse(inputAB[1]);
    if (arrList[a] == null)
        arrList[a] = new List<int>();
    arrList[a].Add(b);
}

dis[x] = 1;
Queue<int> q = new Queue<int>();
q.Enqueue(x);
while (q.Count > 0)
{
    var cur = q.Dequeue();
    if (arrList[cur] == null)
        continue;
    foreach (var one in arrList[cur])
    {
        if (dis[one] > 0)
            continue;
        dis[one] = dis[cur] + 1;
        q.Enqueue(one);
    }
}

List<int> ansList = new List<int>();
for (int i = 0; i <= n; i++)
{
    if (dis[i] == k + 1)
        ansList.Add(i);
}

if(ansList.Count == 0)
    Console.WriteLine(  -1);
else
    for (int i = 0; i < ansList.Count; i++)
        sb.AppendLine(ansList[i].ToString());

Console.WriteLine(  sb );