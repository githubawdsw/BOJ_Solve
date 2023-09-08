// BOJ_2435


string[] inputnk = Console.ReadLine().Split(' ');   
int n = int.Parse(inputnk[0]);
int k = int.Parse(inputnk[1]);

string[] inputarr = Console.ReadLine().Split(" ");

int ans = -20000;
int start = 0;
int end = k;
while (end <= n)
{
	int sum = 0;
	for (int i = start; i < end; i++)
		sum += int.Parse(inputarr[i]);
	ans = Math.Max(ans, sum);
	start++;
	end++;
}
Console.WriteLine(	ans);

