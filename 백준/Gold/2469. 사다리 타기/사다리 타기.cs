// BOJ_2469


using System.Text;

StringBuilder sb = new StringBuilder();

int k = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());

string finalSeq =  Console.ReadLine();

char[,] board = new char[1005, 30];
int targetLine = 0;
for (int i = 0; i < n; i++)
{
	string inputHorizontalLine = Console.ReadLine();
	for (int j = 0; j < k - 1; j++)
	{
		board[i, j] = inputHorizontalLine[j];
		if (board[i, j] == '?')
			targetLine = i;
	}
}

char[] start = new char[30];
char[] final = new char[30];
for (int i = 0; i < k; i++)
{
	start[i] = (char)(i + 'A');
    final[i] = finalSeq[i];
}

for (int i = 0; i < targetLine; i++)
{
    for (int j = 0; j < k - 1; j++)
    {
        if(board[i, j] == '-')
		{
			(start[j], start[j + 1]) = (start[j + 1], start[ j]);
		}	
    }
}

for (int i = n - 1; i > targetLine; i--)
{
    for (int j = 0; j < k - 1; j++)
    {
        if (board[i, j] == '-')
        {
            (final[j], final[j + 1]) = (final[j + 1], final[j]);
        }
    }
}

bool[] ansCheck = new bool[30];
bool isComplete = true;
for (int i = 0; i < k - 1; i++)
{
    if (start[i] != final[i])
    {
        (start[i], start[i + 1]) = (start[i + 1], start[i]);
        ansCheck[i] = true;
        if (start[i + 1] != final[i + 1])
        {
            isComplete = false;
            break;
        }
    }
}

if (!isComplete)
{
    for (int i = 0; i < k - 1; i++)
    {
        sb.Append('x');
    }
}
else
{
    for (int i = 0; i < k - 1; i++)
    {
        if (ansCheck[i])
            sb.Append('-');
        else
            sb.Append('*');
    }
}

Console.WriteLine(sb);