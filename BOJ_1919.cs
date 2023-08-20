// BOJ_1919


string one = Console.ReadLine();
string two = Console.ReadLine();
int[] onearr = new int[30];
int[] twoarr = new int[30];

foreach (var i in one)
    onearr[i - 'a']++;
foreach (var i in two)
    twoarr[i - 'a']++;

int ans = 0;
for (int i = 0; i < 26; i++)
    ans += Math.Abs(onearr[i] - twoarr[i]);

Console.WriteLine(ans);