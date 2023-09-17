using System.Text;

namespace StackAndQueue
{

    class BOJ_10828
    {
        static void Main(string[] args)
        {
            int N;
            N = int.Parse( Console.ReadLine());
            Stack<int> S = new Stack<int>();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < N; i++)
            {
                string[] str = Console.ReadLine().Split(' ');
                if (str[0] == "push")
                    S.Push(int.Parse(str[1]));

                else if(str[0] == "pop")
                {
                    if (S.Count == 0)
                        sb.AppendLine("-1");
                    else
                    {
                        sb.Append(S.Peek() + "\n");
                        S.Pop();
                    }
                }

                else if (str[0] == "size")
                    sb.Append(S.Count + "\n");

                else if (str[0] == "empty")
                {
                    if (S.Count == 0)
                        sb.AppendLine("1");
                    else
                        sb.AppendLine("0");
                }

                else if (str[0] == "top")
                {
                    if (S.Count == 0)
                        sb.AppendLine("-1");
                    else
                        sb.Append(S.Peek() + "\n");
                }
            }
            Console.WriteLine(sb);
        }
    }
}