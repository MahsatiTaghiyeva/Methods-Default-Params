char usedOnceLetter(string word){
foreach(char letter in word){
    int count = 0;
    for(int i = 0; i < word.Length; i++)
        {
            if(letter == word[i])
                {
                count++;
                }
        }
        if(count == 1)
            {
                return letter;
            }
    }   
    return '\0';
}

char result = usedOnceLetter("kertenkele");
Console.WriteLine(result);