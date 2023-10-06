// BOJ_16113


using System.Text;

int n = int.Parse(Console.ReadLine());
string str = Console.ReadLine();


string four = "###....#..#####";
string five = "###.##.#.##.###";
string six = "######.#.##.###";
string seven = "#....#....#####";
string eight = "######.#.######";
string nine = "###.##.#.######";

StringBuilder sb = new StringBuilder();
int share = n / 5;
bool check = false;
for (int i = 0; i < share; i++)
{
    if (str[i] == '#')
        check = true;
    string s = "";
    while (check && i <share)
    {
        string temp = "";
        for (int j = 0; j < 5; j++)
		    temp += str[i + share * j];
        s += temp;

        if (s == "######...######")
            sb.Append("0");
        else if (s == "#####" && (i+1 >= share || ( i+1 < share && str[i+1] == '.')))
        {
            sb.Append("1");
            check = false;
            break;
        }
        else if (s == "#.####.#.####.#")
            sb.Append("2");
        else if (s == "#.#.##.#.######")
            sb.Append("3");
        else if (s == "###....#..#####")
            sb.Append("4");
        else if (s == "###.##.#.##.###")
            sb.Append("5");
        else if (s == "######.#.##.###")
            sb.Append("6");
        else if (s == "#....#....#####")
            sb.Append("7");
        else if (s == "######.#.######")
            sb.Append("8");
        else if (s == "###.##.#.######")
            sb.Append("9");
        i++;
        if (temp == "....." )
        {
            check = false;
            i--;
            break;
        }
    }
}

Console.WriteLine(  sb);