// BOJ_17413



string input = Console.ReadLine();
int start = 0;
int end = 0;
bool check = false;
List<string> strList = new List<string>();

while (end < input.Length)
{
    if (input[start] == '<')
        check = true;
    else
        check = false;

    if (input[end] == '>')
    {
        strList.Add(input.Substring(start, end - start + 1));
        start = end + 1;
    }
    else if ((input[end] == ' ' && !check ) || (input[end] == '<'))
    {
        strList.Add(new string(input.Substring(start, end - start).Reverse().ToArray()));
        if (input[end] == '<')
            start = end;
        else
        {
            strList.Add(input[end].ToString());
            start = end + 1;
        }
    }
    
    end++;
}
if (input[end - 1] != '>')
{
    strList.Add(new string(input.Substring(start, end  - start).Reverse().ToArray()));
}
string ans = "";
for (int i = 0; i < strList.Count; i++)
{
    ans += strList[i];
}
Console.WriteLine(  ans);