// BOJ_17472

int[,] board =  new int[15,15];
int[] dx = { 1, 0, -1, 0 };
int[] dy = { 0, 1, 0, -1 };
Queue<Tuple<int, int>> q = new Queue<Tuple<int, int>>();
List<Tuple<int, int, int>> tupleList = new List<Tuple<int, int, int>>();
Queue<Tuple<int, int>> ffq= new Queue<Tuple<int, int>>();
bool[,] vis = new bool[15, 15];
int[] par = new int[10];
string[] inputnm = Console.ReadLine().Split(' ');

int n = int.Parse(inputnm[0]);
int m = int.Parse(inputnm[1]);

for (int i = 0; i < n; i++)
{
    string[] inputarr = Console.ReadLine().Split(' ');
	for (int j = 0; j < m; j++)
	{
		board[i, j] = int.Parse(inputarr[j]);
		if (board[i, j] == 1)
		{
			q.Enqueue(new Tuple<int, int>(i, j));
		}
	}
}

int maxnum = 0;
int number = 2;
for (int i = 0; i < n; i++)
{
	for (int j = 0; j < m; j++)
	{
		if (board[i, j] != 1)
			continue;
        ffq.Enqueue(new Tuple<int, int>(i, j));

        while (ffq.Count!= 0)
		{
			var cur = ffq.Dequeue();
			if (vis[cur.Item1, cur.Item2])
				continue;
			board[cur.Item1, cur.Item2] = number;
			vis[cur.Item1, cur.Item2] = true;
			for (int k = 0; k < 4; k++)
			{
				int nx = cur.Item1 + dx[k];
				int ny = cur.Item2 + dy[k];
				if (nx < 0 || ny < 0 || nx >= n || ny >= m || vis[nx,ny] || board[nx,ny] == 0)
					continue;
				ffq.Enqueue(new Tuple<int, int>(nx, ny));
			}
		}
		maxnum = Math.Max(maxnum, number);
		number++;
	}
}


while (q.Count!= 0)
{
	var cur = q.Dequeue();
    int bridgecount = 0;
	Tuple<int, int, int> info = null;
    for (int i = 0; i < 4; i++)
	{
		int nx = cur.Item1 + dx[i];
		int ny = cur.Item2 + dy[i];
		info = bridge(nx, ny, dx[i], dy[i], 0);
        bridgecount = info.Item1;
		if(bridgecount != 0)
			tupleList.Add(new Tuple<int, int, int>
				(bridgecount, board[cur.Item1,cur.Item2], board[info.Item2, info.Item3]));
	}
}


tupleList.Sort();
int ans = 0;
int count = 0;
for (int i = 0; i < tupleList.Count; i++)
{
	if (!union(tupleList[i].Item2, tupleList[i].Item3))
		continue;
	ans += tupleList[i].Item1;
	count++;
	if (count == maxnum - 2)
		break;
}

for (int i = 2; i <= maxnum; i++)
{
	for (int j = i+1; j <= maxnum; j++)
	{
		if (find(i) != find(j))
		{
            Console.WriteLine(	-1 );
            return;
		}
	}
}

if(ans != 0)
	Console.WriteLine(	ans );
else
    Console.WriteLine(-1 );

Tuple<int,int, int> bridge(int x, int y, int nx, int ny, int count)
{
	if (x <0 || y< 0 || x >= n || y>= m || (board[x, y] > 1 && count < 2))
		return new Tuple<int, int, int>(0 , x, y);
	else if (board[x, y] > 1 && count >= 2)
		return new Tuple<int, int, int>(count, x, y); 
	return bridge(x + nx, y + ny, nx, ny, count + 1);
}

bool union(int a, int b)
{
	a = find(a); b = find(b);
	if(a == b) 
		return false;
	if (par[a] == par[b])
		par[a]--;
	if (par[a] < par[b])
		par[b] = a;
	else
		par[a] = b;
	return true;
}

int find(int x)
{
	if (par[x] <= 0)
		return x;
	return par[x] = find(par[x]);
}