int[] removeMin(params int[] numbers){
int[] newnumbers = new int[numbers.Length-1];
int min = numbers[0];
for(int i = 0; i < numbers.Length; i++)
{
    if(numbers[i]< min)
    {
        min = numbers[i];
    }
}
int index = 0;
foreach(int number in numbers)
{
    
    if(number == min)
    {
        continue;
    }
    newnumbers[index] = number;
    index++;
    
}
return newnumbers;
}

int[] result =  removeMin(7, 12, 5, 8);
foreach(int number in result)
{
    Console.WriteLine(number);
}