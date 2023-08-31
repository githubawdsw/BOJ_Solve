// BOJ_1543


string n = Console.ReadLine();
string find = Console.ReadLine();

int count = 0;
int idx = 0;
bool flag = false;
for (int i = 0; i < n.Length; i++)
{
    for (int j = i; j < n.Length; j++)
    {
        if (n[j] == find[idx])
            idx++;
        else
        {
            idx = 0;
            break;
        }
        if (idx == find.Length)
        {
            count++;
            flag = true;
            idx = 0;
            break;
        }
    }
    idx = 0;
    if (flag)
    {
        i += find.Length - 1;
        flag = false;
    }
}
Console.WriteLine(count);