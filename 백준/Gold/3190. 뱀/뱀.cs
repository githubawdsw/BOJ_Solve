// BOJ_3190


int n = int.Parse(Console.ReadLine());
int k = int.Parse(Console.ReadLine());

int[] dx = { 1, 0, -1, 0 };
int[] dy = { 0, 1, 0, -1 };
bool[,] body = new bool[105, 105];
int[,] board = new int[105, 105];
for (int i = 0; i < k; i++)
{
    int[] applePos = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    board[applePos[0], applePos[1]] = 1;
}

Queue<(int, int)> snake = new Queue<(int, int)>();
snake.Enqueue((1, 1));
(int, int) head = (1, 1);
int time = 0;
int dir = 1;
bool check = false;
body[1, 1] = true;

int l = int.Parse(Console.ReadLine());
for (int i = 0; i < l; i++)
{
    string[] dirInfo = Console.ReadLine().Split(' ');
    int dis = int.Parse(dirInfo[0]);
    char rotate = char.Parse(dirInfo[1]);
    
    while(time < dis)
    {
        time++;
        var tail = snake.Peek();
        head.Item1 += dx[dir];
        head.Item2 += dy[dir];
        if(head.Item1 <= 0 || head.Item2 <= 0 || head.Item1 > n ||head.Item2 > n 
            || body[head.Item1, head.Item2])
        {
            check = true;
            break;
        }
        body[head.Item1, head.Item2] = true;
        snake.Enqueue(head);
        if (board[head.Item1, head.Item2] != 1)
        {
            body[tail.Item1, tail.Item2] = false;
            snake.Dequeue();
        }
        else
        {
            board[head.Item1, head.Item2] = 0;
        }
    }

    if (check)
        break;

    if(rotate == 'D')
    {
        dir--;
        if (dir < 0)
            dir = 3;
    }
    else
    {
        dir++;
        if (dir > 3)
            dir = 0;
    }
}

while (!check)
{
    var tail = snake.Peek();
    head.Item1 += dx[dir];
    head.Item2 += dy[dir];
    time++;
    if (head.Item1 <= 0 || head.Item2 <= 0 || head.Item1 > n || head.Item2 > n
        || body[head.Item1, head.Item2])
    {
        break;
    }
    body[head.Item1, head.Item2] = true;
    snake.Enqueue(head);
    if (board[head.Item1, head.Item2] != 1)
    {
        body[tail.Item1, tail.Item2] = false;
        snake.Dequeue();
    }
}

Console.WriteLine(time);