// BOJ_1990


using System.Text;

StringBuilder sb= new StringBuilder();
int[] inputab = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int a = inputab[0];
int b = inputab[1];

if (b > 10000000)
	b = 10000000;

bool[] notPrimeCheck = new bool[10000005];
for (int i = 2; i * i <= b; i++)
{
	if (notPrimeCheck[i])
		continue;
	for (int j = i * i; j <= b; j += i)
	{
		notPrimeCheck[j] = true;
	}
}

for (int i = a; i <= b; i++)
{
	if (notPrimeCheck[i])
		continue;
	if (i == int.Parse(i.ToString().Reverse().ToArray()))
		sb.AppendLine(i.ToString());
}
sb.AppendLine("-1");

Console.WriteLine(sb);