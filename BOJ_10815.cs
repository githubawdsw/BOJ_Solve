//BOJ_10815

using System.Text;

StringBuilder sb = new StringBuilder();

int n = int.Parse(Console.ReadLine());
string[] inputn = Console.ReadLine().Split(' ');
List<int> nlist = new List<int>();

for (int i = 0; i < n; i++)
    nlist.Add(int.Parse(inputn[i]));

int m = int.Parse(Console.ReadLine());
string[] inputm = Console.ReadLine().Split(' ');

int[] countingsort = new int[20000001];
for (int i = 0; i < n; i++)
    countingsort[nlist[i] + 10000000]++;

for (int i = 0; i < m; i++)
    sb.Append($"{countingsort[int.Parse(inputm[i]) + 10000000]} ");

Console.WriteLine(sb);


