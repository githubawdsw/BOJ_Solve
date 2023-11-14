// BOJ_1461



int[] inputnm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnm[0];
int m = inputnm[1];

int[] inputarr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

List<int> pn = new List<int>();
List<int> nn = new List<int>();
for (int i = 0; i < n; i++)
{
    if (inputarr[i] > 0)
        pn.Add(inputarr[i]);
    else
        nn.Add(inputarr[i]);
}
pn = pn.OrderByDescending(x => x).ToList();
nn.Sort();


int left = 0;
int right = 0;
if (pn.Count > 0)
    right = pn[0];
if (nn.Count > 0)
    left = nn[0] * -1;


int move = 0;
for (int i = 0; i * m < pn.Count; i++)
    move += 2 * pn[i * m];
for (int i = 0; i * m < nn.Count; i++)
    move += 2 * Math.Abs(nn[i * m]);

if (left > right)
    move -= left;
else
    move -= right;

Console.WriteLine(move);
