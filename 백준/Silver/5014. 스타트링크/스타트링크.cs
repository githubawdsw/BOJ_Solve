// BOJ_5014


int[] count = new int[1000005];
string[] input = Console.ReadLine().Split(' ');
int f = int.Parse(input[0]);
int s = int.Parse(input[1]);
int g = int.Parse(input[2]);
int u = int.Parse(input[3]);
int d = int.Parse(input[4]);

int[] dy = { u, -d };
Queue<int> q = new Queue<int>();

count[s] = 1;
q.Enqueue(s);
while (q.Count!= 0)
{
    int cur = q.Dequeue();
	if (cur == g)
		break;
	for (int i = 0; i < 2; i++)
	{
		int ny = cur + dy[i];
		if (ny <= 0 || ny >f || count[ny] > 0)
			continue;
		count[ny] = count[cur] + 1;
		q.Enqueue(ny);
	}
}
if (count[g] == 0)
    Console.WriteLine("use the stairs");
else
    Console.WriteLine(count[g] - 1);

