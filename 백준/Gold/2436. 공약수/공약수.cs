// BOJ_2436



int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int gcd = input[0];
int lcm = input[1];

int mul = lcm / gcd;
int min = 1;
for (int i = 2; i * i <= mul; i++)
{
	if (mul % i == 0 && GCD(i, mul / i) == 1)
        min = i;
}

Console.WriteLine($"{gcd * min} {gcd * (mul / min)}");



int GCD(int x, int y)
{
	if (y == 0)
		return x; 
	return GCD(y, x % y);
}