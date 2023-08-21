// BOJ_2798


string[] inputnm = Console.ReadLine().Split(' ');
int n = int.Parse(inputnm[0]);
int m = int.Parse(inputnm[1]);

string[] inputNarr = Console.ReadLine().Split(" ");

int ans = 0;
for (int i = 0; i < n; i++)
	for (int j = i+1; j < n; j++)
		for (int k = j+1; k < n; k++)
			if (int.Parse(inputNarr[i]) + int.Parse(inputNarr[j]) + int.Parse(inputNarr[k]) <= m)
				ans = Math.Max(ans, int.Parse(inputNarr[i]) + int.Parse(inputNarr[j]) + int.Parse(inputNarr[k]));
		

Console.WriteLine(	ans);
