int SumEven(params int[] array)
{
    int sum = 0;
    foreach (int num in array)
    {
        if (num % 2 == 0)
            sum += num;
    }
    {
        return sum;
    }
}
Console.WriteLine(SumEven(2,5,4,7));