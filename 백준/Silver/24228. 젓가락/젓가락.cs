// BOJ_24228


long[] inputnr = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
long n = inputnr[0];
long r = inputnr[1];


Console.WriteLine(r * 2 + n - 1);