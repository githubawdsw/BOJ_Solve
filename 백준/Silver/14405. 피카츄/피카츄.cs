// BOJ_14405


string str = Console.ReadLine();
str = str.Replace("pi", " ");
str = str.Replace("ka", " ");
str = str.Replace("chu", " ");
str = str.Replace(" ", "");

if(str == "")
    Console.WriteLine("YES");
else
    Console.WriteLine("NO");
