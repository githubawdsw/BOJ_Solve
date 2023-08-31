// BOJ_2167


using System.Text;

StringBuilder sb = new StringBuilder();
int n, m, k;
int[,] board = new int[302, 302];
int a, b, x, y;

string[] inputNM = Console.ReadLine().Split(' ');
n = int.Parse(inputNM[0]);
m = int.Parse(inputNM[1]);

for (int i = 0; i < n; i++)
{
    string[] rowcol = Console.ReadLine().Split(' ');
    for (int j = 0; j < m; j++)
    {
        board[i, j] = int.Parse(rowcol[j]);
    }
}

k = int.Parse(Console.ReadLine());
for (int i = 0; i < k; i++)
{
    string[] ijxy = Console.ReadLine().Split(' ');
    a = int.Parse(ijxy[0]);
    b = int.Parse(ijxy[1]);
    x = int.Parse(ijxy[2]);
    y = int.Parse(ijxy[3]);
    arraysum();
}

Console.WriteLine(sb);

 void arraysum()
{
    int sum = 0;
    for (int i = a -1; i < x; i++)
        for (int j= b - 1; j < y; j++)
            sum += board[i, j];
    sb.AppendLine(sum.ToString());
}
