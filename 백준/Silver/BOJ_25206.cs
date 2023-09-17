// BOJ_25206


double avSum = 0;
double gradeSum = 0;
for (int i = 0; i < 20; i++)
{
    string[] inputinfo = Console.ReadLine().Split(' ');
    if (inputinfo[2] == "A+")
        avSum += (double.Parse(inputinfo[1]) * 4.5);
    else if (inputinfo[2] == "A0")
        avSum += (double.Parse(inputinfo[1]) * 4.0);
    else if (inputinfo[2] == "B+")
        avSum += (double.Parse(inputinfo[1]) * 3.5);
    else if (inputinfo[2] == "B0")
        avSum += (double.Parse(inputinfo[1]) * 3.0);
    else if (inputinfo[2] == "C+")
        avSum += (double.Parse(inputinfo[1]) * 2.5);
    else if (inputinfo[2] == "C0")
        avSum += (double.Parse(inputinfo[1]) * 2.0);
    else if (inputinfo[2] == "D+")
        avSum += (double.Parse(inputinfo[1]) * 1.5);
    else if (inputinfo[2] == "D0")
        avSum += (double.Parse(inputinfo[1]) * 1.0);
    else if (inputinfo[2] == "F")
        avSum += (double.Parse(inputinfo[1]) * 0.0);
    else if (inputinfo[2] == "P")
        continue;
    gradeSum += double.Parse(inputinfo[1]);
}
Console.WriteLine( avSum / gradeSum );

