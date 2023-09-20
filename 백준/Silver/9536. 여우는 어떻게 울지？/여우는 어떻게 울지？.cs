// BOJ_9536

using System.Text;

StringBuilder sb = new StringBuilder();
int t = int.Parse(Console.ReadLine());
while (t-- > 0)
{
    string inputcry = Console.ReadLine();
    List<string> list = new List<string>();
    while (true)
    {
        string inputtype = Console.ReadLine();
        if (inputtype == "what does the fox say?")
            break;
        string[] split = inputtype.Split(' ');
        list.Add(split[2]);
    }
    string[] str = inputcry.Split(" ");


    for (int i = 0; i < str.Length; i++)
    {
        if (!list.Contains(str[i]))
            sb.Append($"{str[i]} ");
    }
    
}
Console.WriteLine(  sb);

