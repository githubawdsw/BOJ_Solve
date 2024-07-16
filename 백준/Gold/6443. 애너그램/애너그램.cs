// BOJ_6443


using System.Text;

int n = int.Parse(Console.ReadLine());
StringBuilder ans = new StringBuilder();

char[] data = new char[22];
int[] count;
string str;

for (int i = 0; i < n; i++)
{
    str = Console.ReadLine();
    str = string.Concat(str.OrderBy(x => x));

    count = new int[30];
    foreach (var one in str)
    {
        count[one - 'a']++;
    }

    Solve(0, str.Length);
}

Console.WriteLine(ans);


void Solve(int depth, int len)
{
    if (depth == len)
    {
        for (int i = 0; i < len; i++)
        {
            ans.Append(data[i]);
        }
        ans.Append("\n");
        return;
    }

    for (int i = 0; i < 26; i++)
    {
        if (count[i] > 0)
        {
            count[i]--;
            data[depth] = (char)(i + 'a');

            Solve(depth + 1, len);

            count[i]++;
        }
    }
}