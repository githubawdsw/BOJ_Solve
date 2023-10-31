// BOJ_1052


int[] inputnk = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnk[0];
int k  = inputnk[1];

int ans = 0;
while (true)
{
    string binary = Convert.ToString(n, 2);
	int count = 0;
	for (int i = 0; i < binary.Length; i++)
	{
		if (binary[i] == '1')
			count++;
		if (count > k)
			break;
	}
	if (count <= k)
		break;
	n++;
	ans++;
}

Console.WriteLine(	ans );
