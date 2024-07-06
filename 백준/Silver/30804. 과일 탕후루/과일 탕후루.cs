// BOJ_30804



int n = int.Parse(Console.ReadLine());
int[] inputS = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

int[] count = new int[10];

int ans = 0;
int left = 0;
int right = 0;
int kind = 0;

while ( right < n )
{
    if (count[inputS[right]] == 0)
        kind++;
    count[inputS[right++]]++;

    if (kind <= 2)
    {
        ans = Math.Max(right - left, ans);
    }
    
    while (kind > 2)
    {
        count[inputS[left]]--;
        if (count[inputS[left]] == 0)
            kind--;
        left++;
    }
}


Console.WriteLine(ans);

