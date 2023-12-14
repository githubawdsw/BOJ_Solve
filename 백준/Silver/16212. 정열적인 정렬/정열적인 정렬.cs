// BOJ_16212


using System.Text;

StringBuilder sb = new StringBuilder();
int n = int.Parse(Console.ReadLine());
int[] inputarr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
Array.Sort(inputarr);

for (int i = 0; i < n; i++)
    sb.Append($"{inputarr[i]} ");

Console.WriteLine(sb);
