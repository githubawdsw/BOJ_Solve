// BOJ_1251


string str = Console.ReadLine();

string[] arr = new string[2];
List<string> list = new List<string>();
for (int i = 0; i < str.Length - 2; i++)
{
	for (int j = i + 1; j < str.Length - 1; j++)
	{
		string front = str.Substring(0, i + 1);
		string mid = str.Substring(i + 1, j - (i));
		string back = str.Substring (j + 1, str.Length - (j + 1));

		front = new string(front.Reverse().ToArray());
		mid = new string(mid.Reverse().ToArray());
		back = new string(back.Reverse().ToArray());
		
		string temp = front + mid + back;
		list.Add(temp);
	}
}
list.Sort();

Console.WriteLine(list[0]);