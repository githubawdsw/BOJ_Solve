// BOJ_2852



int n = int.Parse(Console.ReadLine());
int[] teamCount = new int[3];
int[] teamTime = new int[3];
int beforeTime = -1;
while (n-- > 0)
{
    string[] inputInfo = Console.ReadLine().Split(' ');
    int team = int.Parse(inputInfo[0]);
    string[] time = inputInfo[1].Split(':');
    int min = int.Parse(time[0]);
    int sec = int.Parse(time[1]);

    teamCount[team]++;

    if (beforeTime == -1)
        beforeTime = min * 60 + sec;
    else if (teamCount[1] == teamCount[2])
    {
        if (team == 1)
            teamTime[2] += min * 60 + sec - beforeTime;
        else
            teamTime[1] += min * 60 + sec - beforeTime;
        beforeTime = -1;
    }
}

if (teamCount[1] > teamCount[2])
    teamTime[1] += 48 * 60 - beforeTime;
else if (teamCount[1] < teamCount[2])
    teamTime[2] += 48 * 60 - beforeTime;

string str = "";
if (teamTime[1] / 60 < 10)
    str += "0";
str += $"{teamTime[1] / 60}:";
if (teamTime[1] % 60 < 10)
    str += "0";
str += $"{teamTime[1] % 60}";

Console.WriteLine(str);

str = "";
if (teamTime[2] / 60 < 10)
    str += "0";
str += $"{teamTime[2] / 60}:";
if (teamTime[2] % 60 < 10)
    str += "0";
str += $"{teamTime[2] % 60}";

Console.WriteLine(str);