// BOJ_2082


using System.Text;

StringBuilder sb = new StringBuilder();
char[,] zero = { { '#' , '#' ,'#' },
                 { '#' , '.' ,'#' },
                 { '#' , '.' ,'#' },
                 { '#' , '.' ,'#' },
                 { '#' , '#' ,'#' }};

char[,] one = { { '.' , '.' ,'#' },
                { '.' , '.' ,'#' },
                { '.' , '.' ,'#' },
                { '.' , '.' ,'#' },
                { '.' , '.' ,'#' }};

char[,] two = { { '#' , '#'  , '#' },
                { '.' , '.'  , '#' },
                { '#' , '#'  , '#' },
                { '#' , '.'  , '.' },
                { '#' , '#'  , '#' }};

char[,] three = { { '#' , '#'  , '#' },
                  { '.' , '.'  , '#' },
                  { '#' , '#'  , '#' },
                  { '.' , '.'  , '#' },
                  { '#' , '#'  , '#' }};

char[,] four = { { '#' , '.' , '#' },
                 { '#' , '.' , '#' },
                 { '#' , '#' , '#' },
                 { '.' , '.' , '#' },
                 { '.' , '.' , '#' }};

char[,] five = { { '#' , '#' , '#' },
                 { '#' , '.' , '.' },
                 { '#' , '#' , '#' },
                 { '.' , '.' , '#' },
                 { '#' , '#' , '#' }};

char[,] six = { { '#' , '#' , '#' },
                { '#' , '.' , '.' },
                { '#' , '#' , '#' },
                { '#' , '.' , '#' },
                { '#' , '#' , '#' }};

char[,] seven = { { '#' , '#'  , '#' },
                  { '.' , '.'  , '#' },
                  { '.' , '.'  , '#' },
                  { '.' , '.'  , '#' },
                  { '.' , '.'  , '#' }};

char[,] eight = { { '#' , '#'  , '#' },
                  { '#' , '.'  , '#' },
                  { '#' , '#'  , '#' },
                  { '#' , '.'  , '#' },
                  { '#' , '#'  , '#' }};

char[,] nine = { { '#' , '#'  , '#' },
                 { '#' , '.'  , '#' },
                 { '#' , '#'  , '#' },
                 { '.' , '.'  , '#' },
                 { '#' , '#'  , '#' }};

Dictionary<int, char[,]> dict = new Dictionary<int, char[,]>
{
    { 0, zero },
    { 1, one },
    { 2, two },
    { 3, three },
    { 4, four } ,
    { 5, five },
    { 6, six },
    { 7, seven },
    { 8, eight },
    { 9, nine}
};

List<char[,]> list = new List<char[,]>();
for (int i = 0; i < 4; i++)
    list.Add(new char[5, 3]);

for (int i = 0; i < 5; i++)
{
    string[] input = Console.ReadLine().Split(' ');
    for (int j = 0; j < input.Length; j++)
    {
        for (int k = 0; k < 3; k++)
        {
            list[j][i, k] = input[j][k];

        }
    }
}


for (int i = 0; i < 4; i++)
{
    if(i == 2)
        sb.Append(":");

    Dictionary<int, bool> possible = new Dictionary<int, bool>();
    for (int j = 0; j < 10; j++)
    {
        var cur = dict[j];
        bool isPoss = true;
        for (int k = 0; k < 5; k++)
        {
            for (int l = 0; l < 3; l++)
            {
                if (cur[k, l] != list[i][k, l] && list[i][k, l] == '#')
                    isPoss = false;
            }
            if (!isPoss)
                break;
        }
        possible.Add(j, isPoss);
    }

    foreach (var di in possible)
    {
        if (di.Value)
        {
            sb.Append($"{di.Key}");
            break;
        }
    }
}

Console.WriteLine(sb);