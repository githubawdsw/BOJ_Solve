// BOJ_20125


using System.Text;

StringBuilder sb = new StringBuilder();
int n = int.Parse(Console.ReadLine());

char[,] board = new char[1005,1005];

Tuple<int, int> heart = null;
bool isHeart = false;
for (int i = 0; i < n; i++)
{
	string input = Console.ReadLine();
	for (int j = 0; j < n; j++)
	{
		if (input[j] =='*' && !isHeart)
		{
            isHeart = true;
            heart = new (i + 1, j);
			sb.AppendLine($"{heart.Item1 + 1} {heart.Item2 + 1}");
		}
		board[i, j] = input[j];
	}
}

int idx = heart.Item2;
int leftarm = 0;
while ( idx - 1 >= 0 && board[heart.Item1, idx - 1] == '*'  )
{
	leftarm++;
	idx--;
}

idx = heart.Item2;
int rightarm = 0;
while (board[heart.Item1,idx + 1] == '*' && idx + 1 < n)
{
    rightarm++;
    idx++;
}

idx = heart.Item1;
int waist = 0;
while (board[idx + 1 , heart.Item2] == '*')
{
    waist++;
    idx++;
}

int temp = idx;
int leftleg = 0;
while (board[idx + 1, heart.Item2 - 1] == '*' && idx + 1 < n)
{
    leftleg++;
    idx++;
}

idx = temp;
int rightleg = 0;
while (board[idx + 1, heart.Item2 + 1] == '*' && idx + 1 < n)
{
    rightleg++;
    idx++;
}

sb.AppendLine($"{leftarm} {rightarm} {waist} {leftleg} {rightleg}");

Console.WriteLine(sb);