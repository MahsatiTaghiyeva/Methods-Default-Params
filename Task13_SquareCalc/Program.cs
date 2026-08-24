int squareEvenPositive(int n){
while(n%2!=0 || n < 0)
{
    Console.WriteLine("Musbet ve cut reqem daxil et: ");
    n = Convert.ToInt32(Console.ReadLine());
}
n = n*n;
return n;
}
Console.WriteLine("Musbet ve cut reqem daxil et: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(squareEvenPositive(num));