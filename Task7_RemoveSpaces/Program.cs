string removeSpaces(string sentence){
string newSentence = "";
foreach (char letter in sentence)
{
    if(letter != ' ')
    {
        newSentence += letter;
    }
}
    return newSentence;
}
Console.WriteLine(removeSpaces("Hello World !"));