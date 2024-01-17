// BOJ_12891


int[] inputsp = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int s = inputsp[0];
int p = inputsp[1];
string str = Console.ReadLine();
int[] acgtCount = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int[] countArr = new int[5];
for (int i = 0; i < p; i++)
{
    if (str[i] == 'A')
        countArr[0]++;
    else if (str[i] == 'C')
        countArr[1]++;
    else if (str[i] == 'G')
        countArr[2]++;
    else
        countArr[3]++;
}

int ans = 0;
if (countArr[0] >= acgtCount[0] && countArr[1] >= acgtCount[1] && countArr[2] >= acgtCount[2] && countArr[3] >= acgtCount[3])
    ans++;

for (int i = p; i < s; i++)
{
    if (str[i] == 'A')
        countArr[0]++;
    else if (str[i] == 'C')
        countArr[1]++;
    else if (str[i] == 'G')
        countArr[2]++;
    else
        countArr[3]++;

    if (str[i - p] == 'A')
        countArr[0]--;
    else if (str[i - p] == 'C')
        countArr[1]--;
    else if (str[i - p] == 'G')
        countArr[2]--;
    else
        countArr[3]--;

    if (countArr[0] >= acgtCount[0] && countArr[1] >= acgtCount[1] && countArr[2] >= acgtCount[2] && countArr[3] >= acgtCount[3])
        ans++;
}

Console.WriteLine(ans);