using System.Text;

namespace Baekjoon2
{
    
    class BOJ_10866
    {
        static StreamReader sr = new StreamReader(Console.OpenStandardInput());
        static StringBuilder sb = new StringBuilder();

        static void Main(string[] args)
        {
            int[] deque = new int[100005];
            int n = int.Parse(sr.ReadLine());
            int idx = 0;
            while (n > 0)
            {
                n--;
                string[] inputCommand = sr.ReadLine().Split(' ');
                string command = inputCommand[0];
                if(command == "push_back")
                {
                    int val = int.Parse(inputCommand[1]);
                    deque[idx++] = val;
                }
                else if (command == "push_front")
                {
                    int val = int.Parse(inputCommand[1]);
                    for (int i = idx; i > 0; i--)
                        deque[i] = deque[i - 1];
                    deque[0] = val;
                    idx++;
                    
                }
                else if (command == "pop_back")
                {
                    if (deque[0] == 0)
                    {
                        sb.AppendLine("-1");
                        continue;
                    }
                    sb.AppendLine(deque[--idx].ToString());
                    deque[idx] = 0;
                }
                else if (command == "pop_front")
                {
                    if (deque[0] == 0)
                    {
                        sb.AppendLine("-1");
                        continue;
                    }
                    sb.AppendLine(deque[0].ToString());
                    for (int i = 0; i < idx - 1 ; i++)
                        deque[i] = deque[i + 1];

                    idx--;
                    deque[idx] = 0;
                }
                else if (command == "size")
                    sb.AppendLine(idx.ToString());
                else if(command == "empty")
                {
                    if (deque[0] == 0)
                        sb.AppendLine("1");
                    else
                        sb.AppendLine("0");
                }    
                else if(command == "front")
                {
                    if (deque[0] == 0)
                        sb.AppendLine("-1");
                    else
                        sb.AppendLine(deque[0].ToString());
                }
                else if (command == "back")
                {
                    if (deque[0] == 0)
                        sb.AppendLine("-1");
                    else
                        sb.AppendLine(deque[idx-1].ToString());
                }
            }
            Console.WriteLine(sb);
        }
    }
    
}
