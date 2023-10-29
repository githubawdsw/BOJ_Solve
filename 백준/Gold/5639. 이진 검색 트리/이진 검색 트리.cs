// BOJ_5639



using System.Text;

StringBuilder sb = new StringBuilder();

int[] tree = new int[10005];
string input;
int treeidx = 0;
while (true)
{
    input = Console.ReadLine();
    if (input == null)
        break;
    tree[treeidx++] = int.Parse(input);
}
postorder(0, treeidx);

Console.WriteLine(  sb);


void postorder(int l , int r)
{
    if(l >= r)
        return;
    
    if (l == r - 1)
    {
        sb.AppendLine(tree[l].ToString());
        return;
    }

    int poidx = l + 1;
    while (poidx < r)
    {
        if (tree[l] < tree[poidx])
            break;
        poidx++;
    }

    postorder(l + 1, poidx);
    postorder(poidx, r);
    sb.AppendLine(tree[l].ToString());
}
