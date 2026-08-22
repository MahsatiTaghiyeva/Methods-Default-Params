bool isPrime(int a)
{
    if (a < 0)
        return false;
    for(int i =2; i< a; i++)
    {
        if (a % i == 0)
            return false;
    }
    return true;
}
Console.WriteLine(isPrime(5));