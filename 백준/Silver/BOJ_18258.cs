// BOJ_18258


using System.Text;

    
StreamReader sr = new StreamReader(Console.OpenStandardInput());
StringBuilder sb = new StringBuilder();

int[] queue = new int[2000005];
int n = int.Parse(sr.ReadLine());

int first = 0;
int last = 0;
while (n > 0)
{
    n--;
    string[] inputCommand = sr.ReadLine().Split(' ');
    string command = inputCommand[0];
    if (command == "push")
        queue[last++] = int.Parse(inputCommand[1]);
              
    else if (command == "pop")
    {
        if (queue[first] == 0)
        {
            sb.AppendLine("-1");
            continue;
        }
        sb.AppendLine(queue[first++].ToString());
    }

    else if (command == "size")
        sb.AppendLine((last - first).ToString());

    else if (command == "empty")
    {
        if (queue[first] == 0)
            sb.AppendLine("1");
        else
            sb.AppendLine("0");
    }

    else if (command == "front")
    {
        if (queue[first] == 0)
            sb.AppendLine("-1");
        else
            sb.AppendLine(queue[first].ToString());
    }
    else if (command == "back")
    {
        if (queue[first] == 0)
            sb.AppendLine("-1");
        else
            sb.AppendLine(queue[last - 1].ToString());
    }
}
Console.WriteLine(sb);
        