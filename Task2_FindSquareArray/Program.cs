int[] FindSquareArray(params int[] array)
{
    int[] newnums = new int[array.Length];
    for(int i =0;i<array.Length; i++)
    {
        int square = array[i] * array[i];
        newnums[i] = square;
    }
    return newnums;
}
foreach(int num in FindSquareArray(2, 3, 4, 5))
{
    Console.WriteLine(num);
}