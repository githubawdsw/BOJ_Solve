// BOJ_1080



int[] inputnm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnm[0];
int m = inputnm[1];

int[,] boardA = new int[55, 55];
int[,] boardB = new int[55, 55];
for (int i = 0; i < n; i++)
{
    string arr = Console.ReadLine();
	for (int j = 0; j < m; j++)
		boardA[i, j] = arr[j] - '0';
}

for (int i = 0; i < n; i++)
{
    string arr = Console.ReadLine();
    for (int j = 0; j < m; j++)
        boardB[i, j] = arr[j] - '0';
}

int y = 0;
int count = 0;
bool correct = true;

if(n <3 || m < 3)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (!check(i, j))
                correct = false;
        }
    }
    if (!correct)
    {
        Console.WriteLine(-1);
        return;
    }
}

while (y < n - 2)
{
    int x = 0;
    while (x < m - 2)
    {
        if (!check(x, y))
        {
            flip(x, y);
            count++;
        }
        x++;
    }

    correct = true;
    for (int i = 0; i < m; i++)
    {
        if(!check(i,y))
            correct = false;
    }
    if (!correct)
    {
        Console.WriteLine( -1 );
        return;
    }
    y++;
}

for (int i = 0; i < m; i++)
{
    for (int j = y; j < n; j++)
    {
        if (!check(i, j))
            correct = false;
    }
}
if (!correct)
{
    Console.WriteLine(-1);
    return;
}

Console.WriteLine(count);


bool check(int x, int y)
{
    return (boardA[y, x] == boardB[y, x]) ? true : false;
}

void flip(int x, int y)
{
    for (int i = y; i < y + 3; i++)
    {
        for (int j = x; j < x + 3; j++)
            boardA[i, j] = boardA[i, j] == 1 ? 0 : 1;
    }
}