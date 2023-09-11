using System.Text;

namespace StackAndQueue
{

    class BOJ_10845
    {
        static void Main(string[] args)
        {
            int N;
            N = int.Parse( Console.ReadLine());
            Queue<int> Q = new Queue<int>();
            StringBuilder sb = new StringBuilder();
            int QbackIndex;

            for (int i = 0; i < N; i++)
            {
                string[] str = Console.ReadLine().Split(' ');
                if (str[0] == "push")
                    Q.Enqueue(int.Parse(str[1]));

                else if(str[0] == "pop")
                {
                    if (Q.Count == 0)
                        sb.AppendLine("-1");
                    else
                    {
                        sb.Append(Q.Peek() + "\n");
                        Q.Dequeue();
                    }
                }

                else if (str[0] == "size")
                    sb.Append(Q.Count + "\n");

                else if (str[0] == "empty")
                {
                    if (Q.Count == 0)
                        sb.AppendLine("1");
                    else
                        sb.AppendLine("0");
                }

                else if (str[0] == "front")
                {
                    if (Q.Count == 0)
                        sb.AppendLine("-1");
                    else
                        sb.Append(Q.Peek() + "\n");
                }

                else if (str[0] == "back")
                {
                    if (Q.Count == 0)
                        sb.AppendLine("-1");
                    else
                    {
                        QbackIndex = Q.Count - 1;
                        sb.Append(Q.Last() + "\n");
                    }
                }
            }
            Console.WriteLine(sb);
        }
    }

}