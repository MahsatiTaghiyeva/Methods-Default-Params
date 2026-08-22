string[] list = {"apple", "banana", "watermelon", "orange"};
int countOfLettera(string[] list){
char find = 'a';
int count = 0;
foreach(string word in list)
{
    for(int i =0; i < word.Length; i++)
    {
        if(word[i] == find)
        {
            count ++;
        }
    }
}
return count;

}
Console.WriteLine(countOfLettera(list));