// BOJ_11576

using System.Text;

StringBuilder sb = new StringBuilder();
int[] inputab = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int a = inputab[0];
int b = inputab[1];

int m = int.Parse(Console.ReadLine());
int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

int value = 0;
for (int i = 0; i < m; i++)
{
    value += inputArr[m - 1 - i] * (int)Math.Pow(a, i);
}

Stack<int> ans = new Stack<int>();
while (value != 0)
{
    ans.Push(value % b);
    value /= b;
}

while(ans.Count > 0)
{
    sb.Append(ans.Pop().ToString() + " ");
}
Console.WriteLine(sb);