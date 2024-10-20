// BOJ_1091


int n = int.Parse(Console.ReadLine());

int[] inputp = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int[] inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

int[] receive = new int[n];
int[] origin = new int[n];
int[] temp = new int[n];
bool[,] arr = new bool[n, 3];

for (int i = 0; i < n; i++)
{
	arr[i, inputp[i]] = true;
	receive[i] = i;
	origin[i] = i;
}

int ans = 0;
while (true)
{
	bool check = true;
	for (int i = 0; i < n; i++)
	{
		if (!arr[receive[i], i % 3])
		{
			check = false;
			break;
		}
	}
    if (check)
		break;

	for (int i = 0; i < n; i++)
	{
		temp[inputs[i]] = receive[i];
	}
	receive = (int[])temp.Clone();

    if (receive.SequenceEqual(origin))
	{
		ans = -1;
		break;
	}
    ans++;
}

Console.WriteLine(ans);