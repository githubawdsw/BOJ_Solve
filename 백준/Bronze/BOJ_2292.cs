// BOJ_2292


int sector = 1;
int count = 0;
int n = int.Parse(Console.ReadLine());
for (int i = 0;  sector < n; i++)
{
    sector += i * 6;
    count++;
}
if (n ==1)
{
    Console.Write(1);
}
else
Console.Write(count);

