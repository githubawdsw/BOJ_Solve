using System;
using System.Collections.Generic;
using System.Text;
namespace BFS_DFS_Reculsive
{
    
    class Quad_Tree_1992
    {
        static int N;
        static char[,] board = new char[129, 129];
        static StringBuilder sb = new StringBuilder();

        static void Main(string[] args)
        {
            N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                string inputrowcol = Console.ReadLine();
                for (int j = 0; j < N; j++)
                {
                    board[i, j] = inputrowcol[j];
                }
            }

            Reculsion(0,0,N);
            Console.WriteLine(sb);
        }
        public static void Reculsion(int x, int y , int _n)
        {
            if (check(x, y, _n))
            {
                sb.Append(board[x,y]);
                return;
            }

            sb.Append("(");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Reculsion(x + (_n * i / 2), y + (_n * j / 2), _n / 2);
                }
            }

            sb.Append(")");
        }

        public static bool check(int x, int y , int _n)
        {
            for (int i = x; i <x + _n; i++)
            {
                for (int j = y; j <y + _n; j++)
                {
                    if (board[x,y] != board[i,j])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
