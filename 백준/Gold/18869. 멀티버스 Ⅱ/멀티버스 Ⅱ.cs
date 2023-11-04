using System;
using System.Collections.Generic;
using System.Linq;
namespace Binary_Search
{
    
    class BOJ_18869
    {
        static void Main(string[] args)
        {
            string[] nm = Console.ReadLine().Split(' ');
            int m = int.Parse(nm[0]);
            int n = int.Parse(nm[1]);

            List<int[]> planetArr = new List<int[]>();
            for (int i = 0; i < m; i++)
            {
                string[] inputPlanet = Console.ReadLine().Split(' ');
                planetArr.Add(new int[10005]);
                for (int j = 0; j < n; j++)
                    planetArr[i][j] = int.Parse(inputPlanet[j]);
                planetArr[i] = compress(planetArr[i], n);
            }

            int ans = 0;
            for (int i = 0; i < m - 1; i++)
            {
                for (int j = i + 1; j < m; j++)
                {
                    bool check = false;
                    for (int k = 0; k < n; k++)
                    {
                        if (planetArr[i][k] != planetArr[j][k])
                        {
                            check = false;
                            break;
                        }
                        check = true;
                    }
                    if(check)
                        ans += 1;
                }
            }
            Console.WriteLine(ans);
        }
        static int[] compress(int[] arr , int n)
        
        {
            int idx = 0;
            List<int> compList = new List<int>();
            for (int i = 0; i < n; i++)
                compList.Add(arr[i]);
            compList.Sort();
            compList = compList.Distinct().ToList();

            List<int> returnlist = new List<int>();
            while (idx < n)
            {
                int start = 0;
                int end = compList.Count - 1;
                int mid;
                while (start <= end)
                {
                    mid = (start + end) / 2;
                    if (compList[mid] == arr[idx])
                    {
                        returnlist.Add(mid);
                        break;
                    }
                    else if (compList[mid] < arr[idx])
                        start = mid + 1;
                    else
                        end = mid-1;
                }

                idx++;
            }
            return returnlist.ToArray();
        }
    }
    
}
