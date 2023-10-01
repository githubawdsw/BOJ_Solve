// BOJ_2304


int n = int.Parse(Console.ReadLine());

Stack<Tuple<int,int>> sl = new Stack<Tuple<int,int>>();
Stack<Tuple<int,int>> sr = new Stack<Tuple<int,int>>();
List<Tuple<int,int>> tupleList = new List<Tuple<int,int>>();
int standard = 0;
int sPos = 0;
for (int i = 0; i < n; i++)
{
    string[] inputlh = Console.ReadLine().Split(' ');
    int l = int.Parse(inputlh[0]);
    int h = int.Parse(inputlh[1]);
    tupleList.Add(new Tuple<int, int>(l, h));
    if (h > standard)
        standard = h;
}
tupleList.Sort();

int lpos = 0;
int lheight = 0;
for (int i = 0; i < n; i++)
{
    if(lheight < tupleList[i].Item2)
    {
        lpos = tupleList[i].Item1;
        lheight = tupleList[i].Item2;
        sl.Push(new Tuple<int, int>(lpos, lheight));
    }
}

int rpos = 0;
int rheight = 0;
for (int i = n-1; i >= 0; i--)
{
    if (rheight <= tupleList[i].Item2)
    {
        rpos = tupleList[i].Item1;
        rheight = tupleList[i].Item2;
        sr.Push(new Tuple<int, int>(rpos, rheight));
    }
}

int ans = 0;
Tuple<int, int> slTuple = sl.Pop();
while (sl.Count != 0)
{
    Tuple<int, int> cur = sl.Pop();
    ans += (slTuple.Item1 - cur.Item1) * cur.Item2;
    slTuple = cur;
}

Tuple<int, int> srTuple = sr.Pop();
while (sr.Count != 0)
{
    Tuple<int, int> cur = sr.Pop();
    ans += ( cur.Item1 - srTuple.Item1) * cur.Item2;
    srTuple = cur;
}

Console.WriteLine(  ans + standard);