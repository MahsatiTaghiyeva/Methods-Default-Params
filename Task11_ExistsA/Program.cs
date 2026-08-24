bool existsA(string word){
bool exists = false;
foreach(char letter in word)
{
        if(letter == 'A')
        {
            exists = true;
            break;
        } 
}
if (exists){
    return true;
}else
    return false;
}
Console.WriteLine(existsA("Apple"));