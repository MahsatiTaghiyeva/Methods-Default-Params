string deleteFirstSpace(string sentence){
string newSentence = "";
bool check = false;
for(int i = 0; i < sentence.Length; i++)
{
    if(sentence[i] != ' ')
    {
        check = true;
    }
    if (check)
    {
        newSentence += sentence[i];
    }   
}
return newSentence;
}

Console.WriteLine(deleteFirstSpace("   salam necesen?   "));