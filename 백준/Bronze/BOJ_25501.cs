//BOJ_25501


using System.Text;

int t = int.Parse(Console.ReadLine());
int count;
StringBuilder sb = new StringBuilder();
while (t-- > 0)
{
    count = 0;
    string input = Console.ReadLine();
    int val = recursion(input, 0, input.Length - 1) ;
    sb.AppendLine($"{val} {count}");
}
Console.WriteLine(  sb);

int recursion(string str, int l, int r)
{
    count++;

    if (l >= r) 
        return 1;
    else if (str[l] != str[r]) 
        return 0;
    else
        return recursion(str, l + 1, r - 1);
    
}


