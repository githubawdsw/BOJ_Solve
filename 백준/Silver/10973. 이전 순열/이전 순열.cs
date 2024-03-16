// BOJ_10973


using System.Text;

StringBuilder sb = new StringBuilder();
int n = int.Parse(Console.ReadLine());
int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

int left = n - 1;
while (left > 0 && inputArr[left - 1] < inputArr[left])
{
    left--;
}

if(left == 0)
{
    Console.WriteLine(-1);
    return;
}

int right = n - 1;
while (inputArr[left - 1] < inputArr[right])
{
    right--;
}

(inputArr[left - 1], inputArr[right]) = (inputArr[right], inputArr[left - 1]);
right = n - 1;
while (left < right)
{
    (inputArr[left], inputArr[right]) = (inputArr[right], inputArr[left]);
    left++;
    right--;
}

for (int i = 0; i < n; i++)
{
    sb.Append(inputArr[i] + " ");
}
Console.WriteLine(sb);