// BOJ_20437


using System.Text;

StringBuilder sb = new StringBuilder();
int t = int.Parse(Console.ReadLine());
while (t-- > 0)
{
    string w = Console.ReadLine();
    int k = int.Parse(Console.ReadLine());

    int[] counting = new int[30];
    int shortLen = int.MaxValue;
    int longLen = 0;

    for (int i = 0; i < w.Length; i++)
    {
        if(++counting[w[i] - 'a'] >= k)
        {
            int count = 0;
            int j = i;
            while (j >= 0)
            {
                if (w[i] == w[j])
                    count++;

                if(count == k && w[i] == w[j])
                {
                    shortLen = Math.Min(i - j + 1, shortLen);
                    longLen = Math.Max(i - j + 1, longLen);
                    break;
                }
                j--;
            }
            
            
        }
    }

    if (shortLen == int.MaxValue)
        sb.AppendLine("-1");
    else
        sb.AppendLine($"{shortLen} {longLen}");
}


Console.WriteLine(sb);
