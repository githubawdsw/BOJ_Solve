// BOJ_3019


int[] inputcp = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int c = inputcp[0];
int p = inputcp[1];

int[] inputHeight = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

int ans = 0;
switch (p)
{
    case 1:
        ans += c;
        for (int i = 3; i < c; i++)
        {
            if (inputHeight[i - 3] == inputHeight[i - 2] && inputHeight[i - 3] == inputHeight[i - 1] && inputHeight[i - 3] == inputHeight[i])
                ans++;
        }
        break;

    case 2:
        for (int i = 1; i < c; i++)
        {
            if (inputHeight[i - 1] == inputHeight[i])
                ans++;
        }
        break;

    case 3:
        for (int i = 2; i < c; i++)
        {
            if (inputHeight[i - 2] == inputHeight[i - 1] && inputHeight[i - 2] + 1 == inputHeight[i])
                ans++;
        }
        for (int i = 1; i < c; i++)
        {
            if (inputHeight[i - 1] == inputHeight[i] + 1)
                ans++;
        }
        break;

    case 4:
        for (int i = 2; i < c; i++)
        {
            if (inputHeight[i - 2] == inputHeight[i - 1] + 1 && inputHeight[i - 2] == inputHeight[i] + 1)
                ans++;
        }
        for (int i = 1; i < c; i++)
        {
            if (inputHeight[i - 1] + 1 == inputHeight[i])
                ans++;
        }
        break;

    case 5:
        for (int i = 2; i < c; i++)
        {
            if (inputHeight[i - 2] == inputHeight[i - 1] && inputHeight[i - 2] == inputHeight[i])
                ans++;
            if (inputHeight[i - 2] == inputHeight[i - 1] + 1 && inputHeight[i - 2] == inputHeight[i])
                ans++;
        }
        for (int i = 1; i < c; i++)
        {
            if (inputHeight[i - 1] == inputHeight[i] + 1)
                ans++;
            if (inputHeight[i - 1] + 1 == inputHeight[i])
                ans++;
        }
        break;

    case 6:
        for (int i = 2; i < c; i++)
        {
            if (inputHeight[i - 2] == inputHeight[i - 1] && inputHeight[i - 2] == inputHeight[i])
                ans++;
        }
        for (int i = 1; i < c; i++)
        {
            if (inputHeight[i - 1] == inputHeight[i])
                ans++;
        }
        for (int i = 2; i < c; i++)
        {
            if (inputHeight[i - 2] + 1 == inputHeight[i - 1] && inputHeight[i - 2] + 1 == inputHeight[i])
                ans++;
        }
        for (int i = 1; i < c; i++)
        {
            if (inputHeight[i - 1] == inputHeight[i] + 2)
                ans++;
        }
        break;

    case 7:
        for (int i = 2; i < c; i++)
        {
            if (inputHeight[i - 2] == inputHeight[i - 1] && inputHeight[i - 2] == inputHeight[i])
                ans++;
        }
        for (int i = 1; i < c; i++)
        {
            if (inputHeight[i - 1] == inputHeight[i])
                ans++;
        }
        for (int i = 2; i < c; i++)
        {
            if (inputHeight[i - 2] == inputHeight[i - 1] && inputHeight[i - 2] == inputHeight[i] + 1)
                ans++;
        }
        for (int i = 1; i < c; i++)
        {
            if (inputHeight[i - 1] + 2== inputHeight[i])
                ans++;
        }
        break;

    default:
        break;
}

Console.WriteLine(ans);