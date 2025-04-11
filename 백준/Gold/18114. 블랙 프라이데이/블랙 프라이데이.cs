// BOJ_18114


int[] inputnc = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnc[0];
int c = inputnc[1];

int[] inputw = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
bool check = false;

Array.Sort(inputw);

for (int i = 0; i < n - 1; i++)
{
    int value = c - inputw[i];
    if (value == 0 || check)
    {
        check = true;
        break;
    }

    int left = i + 1;
    int right = n - 1;
    while (left < right && right < n)
    {
        if (inputw[left] + inputw[right] > value)
            right--;

        else if (inputw[left] + inputw[right] < value)
            left++;

        else
        {
            check = true;
            break;
        }
    }
}

for (int i = 0; i < n - 1; i++)
{
    for (int j = i + 1; j < n; j++)
    {
        if (inputw[i] + inputw[j] == c)
        {
            check = true;
            break;
        }
    }
}

if (inputw[n - 1] == c)
    check = true;

Console.WriteLine(check == true ? 1 : 0);