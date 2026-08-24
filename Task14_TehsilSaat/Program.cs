string tehsilSaat(string tehsil){
switch (tehsil)
{
    case "programming":
        return "400 saat";
    case "design":
        return "250 saat";
    case "system":
        return "200 saat";
    default:
        return "təhsil novu yanlisdir";
}
}
Console.WriteLine("Tehsil novunu secin: ");
string tehsil = Convert.ToString(Console.ReadLine());

Console.WriteLine(tehsilSaat(tehsil));