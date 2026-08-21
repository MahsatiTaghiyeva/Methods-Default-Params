using System.IO.Pipelines;

int[] AddElement(int element, params int[] array)
{
    int[] newArray = new int[array.Length+1];
    for(int i = 0;i< array.Length; i++)
    {
        newArray[i] = array[i];
    }
    newArray[newArray.Length-1] = element;
    return newArray;
}
int[] result = AddElement(64,45,36,91,11);
foreach( int num in result)
{
    Console.WriteLine(num);
}
