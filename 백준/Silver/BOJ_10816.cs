//  BOJ_10816


using System.Text;
    
int N , M;
        
StringBuilder sb = new StringBuilder();
List<int> nlist = new List<int>();
List<int> mlist = new List<int>();
       
N = int.Parse(Console.ReadLine());
string[] inputarr = Console.ReadLine().Split(' ');
for (int i = 0; i < N; i++)
    nlist.Add(int.Parse(inputarr[i]));

M = int.Parse(Console.ReadLine());
inputarr = Console.ReadLine().Split(' ');
for (int i = 0; i < M; i++)
    mlist.Add(int.Parse(inputarr[i]));

int[] countingsort = new int[20000001];
for (int i = 0; i < nlist.Count; i++)
    countingsort[nlist[i] + 10000000]++;

for (int i = 0; i < M; i++)
{
    sb.Append($"{countingsort[mlist[i] + 10000000]} ");
}
Console.WriteLine(sb);
