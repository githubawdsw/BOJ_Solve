// BOJ_2309


using System.Text;

List<int> list = new List<int>();
bool[] check = new bool[9];
int ans = 0;

for (int i = 0; i < 9; i++)
    list.Add(int.Parse(Console.ReadLine()));

list.Sort();
for (int i = 0; i < 9; i++)
{
    check = new bool[9];
     backtracking(i , 1 , 0);
    
    if (ans == 100)
        break;
}

StringBuilder sb = new StringBuilder();
for (int i = 0; i < 9; i++)
{
    if (check[i])
        sb.AppendLine(list[i].ToString());
}
Console.WriteLine(sb);


void backtracking(int idx , int count, int sum)
{
    sum += list[idx];
    check[idx] = true;
    if (count == 7 || sum >= 100)
    {
        if(sum ==  100)
            ans = sum;
        return;
    }
    for (int i = idx; i < list.Count; i++)
    {
        if (check[i])
            continue;
        backtracking(i, count + 1 , sum);
        if (ans == 100)
            return;
        check[i] = false;
    }
}

