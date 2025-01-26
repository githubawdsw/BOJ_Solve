// BOJ_17299


using System.Text;

StringBuilder sb = new StringBuilder();
int n = int.Parse(Console.ReadLine());
int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

Stack<int> s = new Stack<int>();
int[] countArr = new int[1000005];
int[] answer = new int[1000005];
for (int i = 0; i < n; i++)
{
    countArr[inputArr[i]]++;
}

for (int i = n - 1; i >= 0; i--)
{
    while (s.Count > 0 && countArr[s.Peek()] <= countArr[inputArr[i]])
    {
        s.Pop();
    }
    if (s.Count == 0)
        answer[i] = -1;
    else
        answer[i] = s.Peek();
    s.Push(inputArr[i]);
}

for (int i = 0; i < n; i++)
{
    sb.Append($"{answer[i]} ");
}
Console.WriteLine(sb);