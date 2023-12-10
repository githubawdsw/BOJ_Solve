// BOJ_14500


int[] inputnm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnm[0];
int m = inputnm[1];
int[,] board = new int[505, 505];

for (int i = 0; i < n; i++)
{
	string[] inputInfo = Console.ReadLine().Split();
	for (int j = 0; j < m; j++)
		board[i,j] = int.Parse(inputInfo[j]);
}

List<int[,]> shapeList = new List<int[,]>()
{
    new int[2, 2] { { 1, 1 }, { 1, 1 } },
    new int[1, 4] { { 1, 1 , 1, 1 } },
    new int[4, 1] { { 1 }, { 1 } ,{ 1 },{ 1 } },

    new int[2,3]{ { 1, 1, 1 }, { 1, 0, 0 } },
    new int[2,3]{ { 1, 0, 0 }, { 1, 1, 1 } },
    new int[2,3]{ { 0, 0, 1 }, { 1, 1, 1 } },
    new int[2,3]{ { 1, 1, 1 }, { 0, 0, 1 } },

    new int[3,2]{ { 1, 1 }, { 1, 0 }, { 1, 0 } },
    new int[3,2]{ { 1, 0 }, { 1, 0 }, { 1, 1 } },
    new int[3,2]{ { 0, 1 }, { 0, 1 }, { 1, 1 } },
    new int[3,2]{ { 1, 1 }, { 0, 1 }, { 0, 1 } },

    new int[2,3]{ { 1, 1, 0 }, { 0, 1, 1 } },
    new int[2,3]{ { 0, 1, 1 }, { 1, 1, 0 } },
    new int[3,2]{ { 1, 0 }, { 1, 1 }, { 0, 1 } },
    new int[3,2]{ { 0, 1 }, { 1, 1 }, { 1, 0 } },

    new int[2,3]{ { 1, 1, 1 }, { 0, 1, 0 } },
    new int[2,3]{ { 0, 1, 0 }, { 1, 1, 1 } },
    new int[3,2]{ { 0, 1 }, { 1, 1 }, { 0, 1 } },
    new int[3,2]{ { 1, 0 }, { 1, 1 }, { 1, 0 } }
};

int ans = 0;
for (int i = 0; i < shapeList.Count; i++)
{
    int x = shapeList[i].GetLength(0);
    int y = shapeList[i].GetLength(1);
    for (int j = 0; j < n - (x - 1); j++)
        for (int k = 0; k < m - (y - 1); k++)
        {
            int sum = 0;
            for (int a = j; a < j + x; a++)
                for (int b = k; b < k + y; b++)
                    if (shapeList[i][a - j,b - k] == 1)
                        sum += board[a, b];
            if(sum > ans)
                ans = sum;
        }
}

Console.WriteLine(ans);

