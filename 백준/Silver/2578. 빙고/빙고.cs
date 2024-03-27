// BOJ_2578


int[,] board = new int[7, 7];
bool[,] check = new bool[7, 7];
Queue<int> sequence = new Queue<int>();
for (int i = 0; i < 5; i++)
{
	int[] inputInfo = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
	for (int j = 0; j < 5; j++)
	{
		board[i,j] = inputInfo[j];
	}
}

for (int i = 0; i < 5; i++)
{
    int[] inputSequence = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    for (int j = 0; j < 5; j++)
	{
		sequence.Enqueue(inputSequence[j]);
    }
}

while (sequence.Count > 0)
{
	var cur = sequence.Dequeue();
    for (int i = 0; i < 5; i++)
    {
        for (int j = 0; j < 5; j++)
        {
            if (board[i, j] == cur)
                check[i, j] = true;
        }
    }

    int count = 0;
    bool isBingo;
    for (int i = 0; i < 5; i++)
    {
        isBingo = true;
        for (int j = 0; j < 5; j++)
        {
            if (!check[i, j])
                isBingo = false;
        }

        if (isBingo)
            count++;

        isBingo = true;
        for (int j = 0; j < 5; j++)
        {
            if (!check[j,i])
                isBingo = false;
        }

        if (isBingo)
            count++;
    }

    isBingo = true;
    for (int i = 0; i < 5; i++)
    {
        if (!check[i, i])
            isBingo = false;
    }
    if (isBingo)
        count++;

    isBingo = true;
    for (int i = 0; i < 5; i++)
    {
        if (!check[i, 4 - i])
            isBingo = false;
    }
    if (isBingo)
        count++;

    if (count >= 3)
    {
        Console.WriteLine(25 - sequence.Count);
        return;
    }
}