// BOJ_10867

using System.Text;
    
StringBuilder sb = new StringBuilder();

int n = int.Parse(Console.ReadLine());
string[] inputArr = Console.ReadLine().Split(' ');
List<int> arrList = new List<int>();

for (int i = 0; i < n; i++)
{
    int val = int.Parse(inputArr[i]);
    if (!arrList.Contains(val))
        arrList.Add(val);
}

arrList.Sort();
for (int i = 0; i < arrList.Count; i++)
    sb.Append($"{arrList[i]} ");

Console.WriteLine(sb);