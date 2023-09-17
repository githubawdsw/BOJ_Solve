// BOJ_2941


string inputstr = Console.ReadLine();
string[] str = { "c=", "c-", "dz=", "d-", "lj", "nj", "s=" , "z=" };
for (int i = 0; i < str.Length; i++)
{
    if (inputstr.Contains(str[i]))
        inputstr = inputstr.Replace(str[i], ".");
}
Console.WriteLine(  inputstr.Length);

