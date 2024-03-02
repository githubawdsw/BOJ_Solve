// BOJ_15961


int[] inputndkc = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputndkc[0];
int d = inputndkc[1];
int k = inputndkc[2];
int c = inputndkc[3];

int[] kind = new int[3005];
List<int> number =  new List<int>();
for (int i = 0; i < n; i++)
{
    number.Add(int.Parse(Console.ReadLine()));
}

for (int i = 0; i < n; i++)
{
    number.Add(number[i]);
    if (i > 3000)
        break;
}

int ans = 0;
int sum = 0;
int start = 0;
int end = 0;
while (start < n)
{
    if(end - start >= k)
    {
        if (kind[number[start]] == 1)
            sum--;
        kind[number[start++]]--;
    }

    if (kind[number[end]] == 0)
        sum++;
    kind[number[end]]++;

    if(ans <= sum)
    {
        ans = sum;
        if (kind[c] == 0)
            ans++;
    }
    end++;
}

Console.WriteLine(ans);
