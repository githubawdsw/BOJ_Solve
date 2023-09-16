// BOJ_24499


string[] inputnk = Console.ReadLine().Split(' ');
int n = int.Parse(inputnk[0]);
int k = int.Parse(inputnk[1]);

string[] inputarr = Console.ReadLine().Split(' ');

int sum = 0;
for (int i = 0; i < k; i++)
    sum += int.Parse(inputarr[i]);

int ans = sum;
int left = 0;
int right = k;
while (left < inputarr.Length)
{
    if (right >= inputarr.Length)
        right = 0;

    sum += int.Parse(inputarr[right]) - int.Parse(inputarr[left]);
    ans = Math.Max(ans, sum);
    left++;
    right++;
}

Console.WriteLine(  ans );
