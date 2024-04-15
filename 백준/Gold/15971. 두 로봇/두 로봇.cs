// BOJ_17140


int[] inputNRobot = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputNRobot[0];
int start = inputNRobot[1];
int end = inputNRobot[2];

if(start == end)
{
    Console.WriteLine(0);
    return;
}
List<(int, int)>[] list = new List<(int, int)>[100005];
int[] dis = new int[100005];
for (int i = 0; i < n - 1; i++)
{
    int[] inputRoomRel= Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    int room1 = inputRoomRel[0];
    int room2 = inputRoomRel[1];
    int path = inputRoomRel[2];

    if (list[room1] == null)
        list[room1] = new List<(int, int)>();
    list[room1].Add((room2, path));

    if (list[room2] == null)
        list[room2] = new List<(int, int)>();
    list[room2].Add((room1, path));
}

Queue<(int, int)> q = new Queue<(int, int)>();
q.Enqueue((start, 0));
while (q.Count > 0)
{
    var cur = q.Dequeue();
    foreach (var one in list[cur.Item1])
    {
        if (dis[one.Item1] != 0)
            continue;

        if(one.Item1 == end)
        {
            int max = Math.Max(one.Item2, cur.Item2);
            dis[one.Item1] = dis[cur.Item1] + one.Item2 - max;
            continue;
        }
        dis[one.Item1] = dis[cur.Item1] + one.Item2;

        q.Enqueue((one.Item1, Math.Max(one.Item2, cur.Item2)));
    }
}

Console.WriteLine(dis[end]);