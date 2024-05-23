// BOJ_1756


int[] inputdn = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int d = inputdn[0];
int n = inputdn[1];

int[] diameter = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int[] pizza = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

for (int i = 1; i < d; i++)
{
	diameter[i] = Math.Min(diameter[i], diameter[i - 1]);
}

int depth = d - 1;
int count = 0;
int idx = 0;
while (depth > 0)
{
	if (diameter[depth] >= pizza[idx])
	{
		count++;
		idx++;
	}
	if (count == n)
		break;
	depth--;
}

if(count != n)
    Console.WriteLine(0);
else
	Console.WriteLine(depth + 1);