// BOJ_17827


using System.Text;

StringBuilder sb = new StringBuilder();

int[] inputnmv = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnmv[0];
int m = inputnmv[1];
int v = inputnmv[2];

int[] inputInfo = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

for (int i = 0; i < m; i++)
{
    int question = int.Parse(Console.ReadLine());
    if (question >= n)
    {
        int idx = question - v + 1;
        idx %= n - v + 1;
        sb.AppendLine(inputInfo[idx + v - 1].ToString());
    }
    else
        sb.AppendLine(inputInfo[question].ToString());
}

Console.WriteLine(sb);