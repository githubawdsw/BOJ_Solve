// BOJ_9934


using System.Text;

StringBuilder sb = new StringBuilder();
int k = int.Parse(Console.ReadLine());
int[] inputNumber = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
List<int> list = new List<int>() { 0 };
int[] room = new int[1025];
bool[] vis = new bool[1025];
int idx = 0;
int pos = (int)Math.Pow(2, k - 1);

for (int i = 0; i < inputNumber.Length; i++)
{
	list.Add(inputNumber[i]);
}

Dfs(k, pos);

int pow = 2;
for (int i = 1; i <= inputNumber.Length; i++)
{
	if (i % pow == 0)
	{
		pow *= 2;
		sb.AppendLine();
	}
	sb.Append(room[i].ToString() + " ");
}

Console.WriteLine(sb);


void Dfs(int depth, int pos)
{
	if(depth == 0 || depth > k || vis[pos] || idx >= inputNumber.Length)
	{
		return;
	}

	vis[pos] = true;
	Dfs(depth + 1, pos * 2);
	room[pos] = inputNumber[idx++];
    Dfs(depth + 1, pos * 2 + 1);
	Dfs(depth - 1, pos / 2);
}