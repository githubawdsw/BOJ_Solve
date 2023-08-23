// BOJ_19532



string[] input = Console.ReadLine().Split(' ');
int a = int.Parse(input[0]);
int b = int.Parse(input[1]);
int c = int.Parse(input[2]);    
int d = int.Parse(input[3]);
int e = int.Parse(input[4]);    
int f = int.Parse(input[5]);

for (int i = -999; i <= 999; i++)
{
	for (int j = -999; j <= 999; j++)
	{
		if(a * i + b* j == c && d * i + e* j == f)
		{
            Console.WriteLine($"{i} {j}"	);
			return;
		}
    }
}

