// BOJ_2870


using System.Text;

int n = int.Parse(Console.ReadLine());
List<string> strList = new List<string>();
for (int i = 0; i < n; i++)
{
    string str = Console.ReadLine();

	bool check = false;
	string temp = "";
	for (int j = 0; j < str.Length; j++)
	{
		if (str[j] - '0' < 10)
			check = true;
		else
			check = false;

		if (check)
		{
			if (temp == "" && str[j] == '0' && j+1 < str.Length && str[j+1] - '0' < 10)
				continue;
			temp += str[j];
		}
		else
		{
			if(temp.Length >= 1 && temp != "")
				strList.Add(temp);
			temp = "";
		}
		if(check && j == str.Length-1)
            strList.Add(temp);
    }
}

strList = strList.OrderBy(x =>x.Length).ThenBy(x=>x).ToList();
StringBuilder sb = new StringBuilder();
for (int i = 0; i < strList.Count; i++)
	sb.AppendLine(strList[i].ToString());

Console.WriteLine(	sb);


