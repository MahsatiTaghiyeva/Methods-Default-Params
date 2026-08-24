int countA(string word){
int count = 0;
foreach(char letter in word)
{
        if(letter == 'A')
        {
            count++;;
        }
}
return count;
}
Console.WriteLine(countA("AppleA"));