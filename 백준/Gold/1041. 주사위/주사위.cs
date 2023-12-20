// BOJ_1041


long n = int.Parse(Console.ReadLine());
int[] info = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

if(n == 1)
{
    Array.Sort(info);
    int sumSide = info.Sum();
    sumSide -= info.Last();
    Console.WriteLine(sumSide);
    return;
}

long sum = int.MaxValue;
long ans = 0;
// 3면
sum = Math.Min(Math.Min(info[0], info[5]) + Math.Min(info[1], info[4]) + Math.Min(info[2], info[3]), sum);
ans = sum;
ans *= 4;

// 2면
sum = int.MaxValue;
List<long> list = new List<long>();
for (int i = 0; i < 3; i++)
    list.Add(Math.Min(info[i], info[5 - i]));
list.Sort();
sum = list[0] + list[1];

long count = 0;
count += 2 * (n - 2);
count += 2 * (n - 1);
count *= 2;

for (int i = 0; i < count; i++)
    ans += sum;

// 1면
sum = int.MaxValue;
for (int i = 0; i < 6; i++)
    sum = Math.Min(info[i], sum);
ans += (((n - 2) * (n - 2)) + (4 * (n - 1) * (n - 2))) * sum;


Console.WriteLine(ans);
