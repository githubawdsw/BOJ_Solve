// BOJ_1259


using System.Text;

StringBuilder sb = new StringBuilder();
while (true)
{
    string input = Console.ReadLine();
    if (input == "0")
        break;
    int left = 0;
    int right = input.Length - 1;
    bool check = true;

    while (left < right)
    {
        if (input[left] != input[right]) 
            check = false;
        left++;
        right--;
    }
    if (check)
        sb.AppendLine("yes");
    else
        sb.AppendLine("no");

}
Console.WriteLine(  sb);

