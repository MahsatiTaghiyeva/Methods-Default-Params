bool DevidedBy3And7(int n)
{
    if(n%3== 0 && n % 7 == 0)
    {
        return true;
    }
    return false;
}

Console.WriteLine(DevidedBy3And7(15));