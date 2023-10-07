// BOJ_18111

using System.Text;

StringBuilder sb = new StringBuilder();
int N , M , B;
int[,] board = new int[501, 501];
List<int> nlist = new List<int>();
List<int> mlist = new List<int>();

string[] inputArr = Console.ReadLine().Split(' ');
N = int.Parse(inputArr[0]);
M = int.Parse(inputArr[1]);
B = int.Parse(inputArr[2]);

int maxHeight = int.MinValue;
int minHeight = int.MaxValue;

for (int i = 0; i < N; i++)
{
    string[] inputheight = Console.ReadLine().Split(' ');
    for (int j = 0; j < M; j++)
    {
        board[i, j] = int.Parse(inputheight[j]);
        maxHeight = Math.Max(maxHeight, board[i, j]);
        minHeight = Math.Min(minHeight, board[i, j]);
    }
}

int height = 0;
int ans = int.MaxValue;
for (int k = minHeight; k <= maxHeight; k++)
{    
    int sum = 0;
    int bag = B;
    for (int i = 0; i < N; i++)
    {
        for (int j = 0; j < M; j++)
        {
            if (board[i, j] < k)
            {
                sum += k - board[i, j];
                bag -= k - board[i, j];
            }
            else if (board[i, j] > k)
            {
                sum += 2 * (board[i, j] - k);
                bag += board[i, j] - k;
            }
        }
    }
    if (bag >= 0)
    {
        ans = Math.Min( sum , ans);
        if( sum == ans)
            height = k;
    }
}

if (ans == int.MaxValue)
{
    ans = 0;
    height = board[0, 0];
}

Console.WriteLine(  $"{ans} {height}");
