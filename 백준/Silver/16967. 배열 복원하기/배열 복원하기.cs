// BOJ_16967


using System.Text;

StringBuilder sb = new StringBuilder();
int[] inputhwxy = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int h = inputhwxy[0];
int w = inputhwxy[1];
int x = inputhwxy[2];
int y = inputhwxy[3];

int[,] arrb = new int[605, 605];
for (int i = 0; i < h + x; i++)
{
    int[] inputInfo = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    for (int j = 0; j < w + y; j++)
	{
        arrb[i, j] = inputInfo[j];
	}
}

for (int i = x; i < h; i++)
{
	for (int j = y; j < w; j++)
	{
		arrb[i, j] -= arrb[i - x, j - y];
	}
}

for (int i = 0; i < h; i++)
{
    for (int j = 0; j < w; j++)
    {
        sb.Append($"{arrb[i,j]} ");
    }
    sb.AppendLine();
}

Console.WriteLine(sb);