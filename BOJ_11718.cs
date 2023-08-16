// BOJ_11718

using System.Text;

StringBuilder sb = new StringBuilder();
while (true)
{
    string input = Console.ReadLine();
    if (input == null ) 
        break;
    sb.AppendLine($"{input}");
}
Console.WriteLine(  sb);
