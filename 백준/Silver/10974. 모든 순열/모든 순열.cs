// BOJ_10974


using System.Text;

StringBuilder sb = new StringBuilder();

int n = int.Parse(Console.ReadLine());

int[] ansArr = new int[10];
bool[] check = new bool[10];

backtracking(0);
Console.WriteLine( sb );


void backtracking(int count)
{
    if(count == n)
    {
        for (int i = 0; i < n; i++)
            sb.Append($"{ansArr[i]} ");
        sb.AppendLine();
        return;
    }

    for (int i = 0; i < n; i++)
    {
        if (check[i])
            continue;
        check[i] = true;
        ansArr[count] = i + 1;
        backtracking(count + 1);
        check[i] = false;
    }
}

