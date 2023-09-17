// BOJ_1032

using System.Text;

StringBuilder sb = new StringBuilder();
int n = int.Parse(Console.ReadLine());

string[] inputValue = new string[n];
for (int i = 0; i < n; i++)
    inputValue[i] = Console.ReadLine();

sb.Append(inputValue[0]);
split(inputValue);

Console.WriteLine(sb);
        
void split(string[] word)
{
    int len = sb.Length;
    char[] validchar = new char[len];
    for (int i = 0; i < n - 1; i++)
    {
        for (int j = 0; j < len; j++)
        {
            if (sb[j] == word[i + 1][j])
                validchar[j] = sb[j];
            else
                validchar[j] = '?';
        }
        sb.Clear();
        sb.Append(validchar);
    }
}