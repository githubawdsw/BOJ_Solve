// BOJ_1244


using System.Text;


int sw , student;
string[] swArr;
StreamReader sr = new StreamReader(Console.OpenStandardInput());

sw = int.Parse(sr.ReadLine());
swArr = sr.ReadLine().Split(' ');
student = int.Parse(sr.ReadLine());
StringBuilder sb = new StringBuilder();
for (int i = 0; i < student; i++)
{
    string[] stinfo = sr.ReadLine().Split(' ');
    int gender = int.Parse(stinfo[0]);
    int swnum = int.Parse(stinfo[1]);

    if (gender == 1)
        boy(swnum);
    if (gender == 2)
        girl(swnum);

}
            
for (int i = 1; i <= sw; i++)
{
    sb.Append($"{swArr[i - 1]} ");
    if (i % 20 == 0 && i != 0)
        sb.AppendLine();

}
Console.Write(sb);
            

void boy(int num)
{
    for (int i = num; i - 1 < sw; i+= num)
    {
        if (swArr[i - 1] == "1")
            swArr[i - 1] = "0";
        else
            swArr[i - 1] = "1";
    }
}

void girl(int num)
{
    int count = 1;
    if (swArr[num - 1] == "1")
        swArr[num - 1] = "0";
    else
        swArr[num - 1] = "1";
            
    while (num - 1 + count <sw && num - 1 -count >= 0)
    {
        if (swArr[num - 1 + count] != swArr[num - 1 - count])
            return;

        if (swArr[num - 1 + count] == "1")
            swArr[num - 1 + count] = "0";
        else
            swArr[num - 1 + count] = "1";

        if (swArr[num - 1 - count] == "1")
            swArr[num - 1 - count] = "0";
        else
            swArr[num - 1 - count] = "1";

        count++;
    }
}