// BOJ_15828


using System.Text;

StringBuilder sb = new StringBuilder();
int n = int.Parse(Console.ReadLine());

Queue<string> q = new Queue<string>();
while (true)
{
    string inputinfo = Console.ReadLine();

    if (inputinfo == "-1")
        break;
    if (inputinfo != "0" && q.Count < n)
        q.Enqueue(inputinfo);
    else if (inputinfo == "0")
        q.Dequeue();
}

if(q.Count == 0)
{
    Console.WriteLine(  "empty");
    return;
}


while (q.Count > 0)
{
    sb.Append(q.Dequeue().ToString());
    sb.Append(" ");
}

Console.WriteLine(  sb );
