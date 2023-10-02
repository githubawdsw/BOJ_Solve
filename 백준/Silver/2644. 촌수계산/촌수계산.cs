// BOJ_2644


using System.Text;

StringBuilder sb = new StringBuilder();

int n = int.Parse(Console.ReadLine());
string[] rel = Console.ReadLine().Split(' ');
int a = int.Parse(rel[0]);
int b = int.Parse(rel[1]);
int m = int.Parse(Console.ReadLine());

List<int>[] arrList = new List<int>[105];
Queue<int> q = new Queue<int>();
int[] dis = new int[105];

for (int i = 0; i < m; i++)
{
    string[] inputxy = Console.ReadLine().Split(' '); 
    int x = int.Parse(inputxy[0]);
    int y = int.Parse(inputxy[1]);
    if (arrList[x] == null)
        arrList[x] = new List<int>();
    arrList[x].Add(y);
    if (arrList[y] == null)
        arrList[y] = new List<int>();
    arrList[y].Add(x);
}

dis[a] = 1;
q.Enqueue(a);
while (q.Count> 0)
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

if (dis[b] == 0)
    Console.WriteLine(  -1);
else
    Console.WriteLine(dis[b] - 1);