// BOJ_1246


int[] inputnm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnm[0];
int m = inputnm[1];

List<int> pirceList = new List<int>();
for (int i = 0; i < m; i++)
{
    int inputPrice = int.Parse(Console.ReadLine());
    pirceList.Add(inputPrice);
}

pirceList.Sort();
int max = 0;
int total = 0;
for (int i = 0; i < m; i++)
{
    if(m - i < n)
    {
        if(pirceList[i] * (m - i) > total)
        {
            max = pirceList[i];
            total = pirceList[i] * (m - i);
        }
    }
    else
    {
        if (pirceList[i] * n > total)
        {
            max = pirceList[i];
            total = pirceList[i] * n;
        }
    }
}

Console.WriteLine($"{max} {total}");
