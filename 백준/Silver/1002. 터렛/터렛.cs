using System;
using System.Text;

namespace MathAlgorithm
{
    
    class BOJ_1002
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            int t = int.Parse(Console.ReadLine());
            while (t-- > 0)
            {
                string[] inputVal = Console.ReadLine().Split(' ');
                int jox = int.Parse(inputVal[0]);
                int joy = int.Parse(inputVal[1]);
                int jor = int.Parse(inputVal[2]);
                int baekx = int.Parse(inputVal[3]);
                int baeky = int.Parse(inputVal[4]);
                int baekr = int.Parse(inputVal[5]);

                if(jox == baekx &&  joy == baeky && jor == baekr)
                {
                    sb.AppendLine("-1");
                    continue;
                }

                bool isOut = false;
                double maxR = Math.Max(jor, baekr);
                double dis = Math.Pow( jox - baekx , 2) + Math.Pow(joy - baeky, 2);
                if(dis >= Math.Pow(maxR, 2))
                    isOut = true;

                if (isOut)
                {
                    double sumR = Math.Pow(jor + baekr, 2);
                    if (dis > sumR)
                        sb.AppendLine("0");
                    else if (dis < sumR)
                        sb.AppendLine("2");
                    else
                        sb.AppendLine("1");
                }
                else
                {
                    double sumR = Math.Pow(jor - baekr, 2);
                    if (dis > sumR)
                        sb.AppendLine("2");
                    else if (dis < sumR)
                        sb.AppendLine("0");
                    else
                        sb.AppendLine("1");
                }

            }

            Console.WriteLine(  sb );
        }
    }
    
}
