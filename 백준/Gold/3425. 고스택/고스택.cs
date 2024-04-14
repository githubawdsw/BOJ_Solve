// BOJ_3425


using System.Text;

StringBuilder sb = new StringBuilder();
Stack<long> s = new Stack<long>();
while (true)
{
    List<string[]> list = new List<string[]>();
    bool lineBreak = false;
    bool end = false;
    while (true)
    {
        string[] str = Console.ReadLine().Split();
        if (str[0] == "END")
            break;
        if(str[0] == "QUIT")
        {
            end = true;
            break;
        }
        if (str[0] == "")
        {
            lineBreak = true;
            break;
        }
        else
            list.Add(str);
    }
    if (lineBreak == true)
    {
        sb.AppendLine();
        continue;
    }
    if (end == true)
        break;

    int n = int.Parse(Console.ReadLine());
    for (int i = 0; i < n; i++)
    {
        s.Push(int.Parse(Console.ReadLine()));
        bool check = false;
        for (int j = 0; j < list.Count; j++)
        {
            if (list[j][0] == "NUM")
            {
                s.Push(long.Parse(list[j][1]));
            }
            else if (list[j][0] == "POP")
            {
                if (s.Count < 1)
                {
                    check = true;
                    break;
                }
                s.Pop();
            }
            else if (list[j][0] == "INV")
            {
                if (s.Count < 1)
                {
                    check = true;
                    break;
                }
                s.Push(s.Pop() * -1);
            }
            else if (list[j][0] == "DUP")
            {
                if (s.Count < 1)
                {
                    check = true;
                    break;
                }
                s.Push(s.Peek());
            }
            else if (s.Count < 2)
            {
                check = true;
                break;
            }
            else if (list[j][0] == "SWP")
            {
                long temp1 = s.Pop();
                long temp2 = s.Pop();
                s.Push(temp1);
                s.Push(temp2);
            }
            else if (list[j][0] == "ADD")
            {
                long temp1 = s.Pop();
                long temp2 = s.Pop();
                if (temp1 + temp2 <= 1000000000 && temp1 + temp2 >= -1000000000)
                    s.Push(temp1 + temp2);
                else
                {
                    check = true;
                    break;
                }
            }
            else if (list[j][0] == "SUB")
            {
                long temp1 = s.Pop();
                long temp2 = s.Pop();
                if (temp2 - temp1 <= 1000000000 && temp2 - temp1 >= -1000000000)
                    s.Push(temp2 - temp1);
                else
                {
                    check = true;
                    break;
                }
            }
            else if (list[j][0] == "MUL")
            {
                long temp1 = s.Pop();
                long temp2 = s.Pop();
                if (temp2 * temp1 <= 1000000000 && temp2 * temp1 >= -1000000000)
                    s.Push(temp2 * temp1);
                else
                {
                    check = true;
                    break;
                }
            }
            else if (list[j][0] == "DIV")
            {
                long temp1 = s.Pop();
                long temp2 = s.Pop();
                if ((temp2 >= 0 && temp1 > 0) || (temp2 <= 0 && temp1 < 0))
                    s.Push(Math.Abs(temp2) / Math.Abs(temp1));
                else if ((temp2 >= 0 && temp1 < 0) || (temp2 <= 0 && temp1 > 0))
                    s.Push((Math.Abs(temp2) / Math.Abs(temp1)) * -1);
                else
                {
                    check = true;
                    break;
                }
            }
            else if (list[j][0] == "MOD")
            {
                long temp1 = s.Pop();
                long temp2 = s.Pop();
                if (temp2 >= 0 && temp1 != 0)
                    s.Push(Math.Abs(temp2) % Math.Abs(temp1));
                else if (temp2 < 0 && temp1 != 0)
                    s.Push((Math.Abs(temp2) % Math.Abs(temp1)) * -1);
                else
                {
                    check = true;
                    break;
                }
            }
        }
        if (check || s.Count != 1)
            sb.AppendLine("ERROR");
        else
            sb.AppendLine(s.Peek().ToString());

        s.Clear();
    }

}


Console.WriteLine(sb);
