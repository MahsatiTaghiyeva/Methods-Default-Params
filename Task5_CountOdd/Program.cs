int CountOdd(int n, int m)
{
    int count = 0;
    for(int i = n; i<= m; i++)
    {
        if (i % 2 != 0)
        {
            count++;
        }
    }
    return count;
}
Console.WriteLine(CountOdd(5,7));