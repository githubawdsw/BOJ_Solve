
static StreamReader sr = new StreamReader(Console.OpenStandardInput());
string s = sr.ReadLine();
string alphabet = "abcdefghijklmnopqrstuvwxyz";

Dictionary<char, int> dic = new Dictionary<char, int>();
StringBuilder sb = new StringBuilder();

for (int i = 0; i < alphabet.Length; i++)
dic.Add(alphabet[i], 0);
for (int i = 0; i < s.Length; i++)
dic[s[i]]++;

foreach (var one in dic)
sb.Append( $"{  one.Value} " );
Console.Write(sb);