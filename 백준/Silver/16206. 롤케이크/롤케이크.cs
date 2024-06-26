// BOJ_16206


using System.Runtime.ConstrainedExecution;

string[] inputnm = Console.ReadLine().Split(' ');
int n = int.Parse(inputnm[0]);
int m = int.Parse(inputnm[1]);

string[] inputA = Console.ReadLine().Split(' ');
List<int> list1 = new List<int>();
List<int> list2 = new List<int>();

for (int i = 0; i < n; i++)
{
    int value = int.Parse(inputA[i]);
    if (value % 10 == 0)
        list1.Add(value);
    else
        list2.Add(value);
}

int ans = 0;
list1.Sort();
list2.Sort();

for (int i = 0; i < list1.Count; i++)
{
    var cur = list1[i];
    while (cur > 10 && m > 0)
    {
        cur -= 10;
        ans++;
        m--;
    }
    if (cur == 10)
        ans++;
}

for (int i = 0; i < list2.Count; i++)
{
    var cur = list2[i];
    while (cur > 10 && m > 0)
    {
        cur -= 10;
        ans++;
        m--;
    }
    if (cur == 10)
        ans++;
}

Console.WriteLine(ans);

