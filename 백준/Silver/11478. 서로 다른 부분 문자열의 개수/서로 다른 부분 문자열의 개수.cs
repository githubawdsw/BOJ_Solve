using System;
using System.Collections.Generic;
using System.IO;
namespace Hash
{
    
    class BOJ_11478
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
            
            string inputstring = sr.ReadLine();
            HashSet<string> hs = new HashSet<string>();
            for (int i = 0; i < inputstring.Length; i++)
            {
                for (int j = i; j < inputstring.Length; j++)
                {
                    hs.Add(inputstring.Substring(i, j  + 1 - i));
                }
            }
            
            sw.WriteLine(hs.Count);
            sw.Close();
            
        }
    }
    
}
