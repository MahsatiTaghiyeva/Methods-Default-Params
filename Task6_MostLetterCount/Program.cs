int mostLetterCount(string word){
int max = 0;
foreach(char letter in word){
    int count = 0;
   
    for(int i = 0; i < word.Length; i++)
        {
            if(letter == word[i])
                {
                count++;
                }
        }
        if(count > max)
            {
                max = count;
            }
    }
    return max;
}
char mostCountLetter(string word){
char l = ' ';
int max =0;
foreach(char letter in word){
    int count = 0;
   
    for(int i = 0; i < word.Length; i++)
        {
            if(letter == word[i])
                {
                count++;
                }
        }
        if(count > max)
            {
                max = count;
                l = letter;                
            }
    }
    return l;
}

    Console.WriteLine(mostLetterCount("kertenkele"));
    Console.WriteLine(mostCountLetter("kertenkele"));