string RemoveSpace(string input)
{
    string changed =" ";
    foreach(char letter in input)
    {
        if(letter != ' ')
        { 
            changed += letter;
        }
    }
    return changed;
}
Console.WriteLine(RemoveSpace("He llo World !"));