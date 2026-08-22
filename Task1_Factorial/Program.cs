int[] factorialArray(params int[] numbers){
for( int i = 0; i < numbers.Length; i++)
{
    int factorial = 1;
    for(int j = 1; j <= numbers[i]; j++)
    {
        factorial *= j;
    }
    numbers[i] = factorial;
}
return numbers;
}
int[] result = factorialArray(5,4,6);
foreach(int number in result)
{
    Console.WriteLine(number);
}