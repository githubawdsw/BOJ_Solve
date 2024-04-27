// BOJ_19539


int n = int.Parse(Console.ReadLine());
int[] inputh = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

int sum = 0;
int twoCount = 0;
for (int i = 0; i < n; i++)
{
	sum += inputh[i];
	twoCount += inputh[i] / 2;
}

if(sum % 3 == 0 && twoCount >= sum / 3)
    Console.WriteLine("YES");
else
    Console.WriteLine("NO");

