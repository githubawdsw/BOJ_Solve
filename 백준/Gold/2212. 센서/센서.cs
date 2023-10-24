// BOJ_17140


int n = int.Parse(Console.ReadLine());
int k  = int.Parse(Console.ReadLine());
string[] inputPos = Console.ReadLine().Split(' ');

if(n == k)
{
    Console.WriteLine(  0 );
    return;
}

List<int> list = new List<int>();
for (int i = 0; i < n; i++)
    list.Add(int.Parse(inputPos[i]));
list.Sort();

List<int> section = new List<int>();
for (int i = 1; i < n; i++)
    section.Add(list[i] - list[i-1]);
section.Sort();

for (int i = 0; i < k-1 ; i++)
    section.Remove(section.LastOrDefault());

Console.WriteLine(  section.Sum());
