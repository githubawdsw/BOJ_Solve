// BOJ_14246



int n = int.Parse(Console.ReadLine());
string[] inputNum = Console.ReadLine().Split(' ');
int k = int.Parse(Console.ReadLine());

int left = 0;
int right = 0;
long count = 0;
long sum = 0;

while (true)
{
    if (sum > k)
    {
        count += n - right + 1;
        sum -= long.Parse(inputNum[left]);
        left++;
    }
    else if (right == n)
        break;
    else
    {
        sum += long.Parse(inputNum[right]);
        right++;
    }
}

Console.WriteLine(count);
