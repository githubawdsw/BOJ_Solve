// BOJ_2840


using System.Text;

StringBuilder sb = new StringBuilder();
int[] inputnk = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnk[0];
int k = inputnk[1];

bool[] check = new bool[30];
string[] arr = new string[30];
Array.Fill(arr, "?");
int idx = 0;
for (int i = 0; i < k; i++)
{
    string[] inputInfo = Console.ReadLine().Split();
    int move = int.Parse(inputInfo[0]);
    string target = inputInfo[1];

    int pos = (idx - (move % n) + n) % n;
    if (arr[pos] == target)
    {
        idx = pos;
        continue;
    }
    if (arr[pos] == "?" && !check[char.Parse(target) - 'A'])
    {
        check[char.Parse(target) - 'A'] = true;
        arr[pos] = target;
        idx = pos;
    }
    else
    {
        Console.WriteLine("!");
        return;
    }
}

for (int i = idx; i < n; i++)
{
    sb.Append(arr[i]);
}
for (int i = 0; i < idx; i++)
{
    sb.Append(arr[i]);
}
Console.WriteLine(sb);