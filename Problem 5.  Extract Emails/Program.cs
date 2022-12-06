using System.Text.RegularExpressions;
string pattern = @"(\s|^)(([A-Z,a-z,0-9])+\W*([A-Z,a-z,0-9])+)@(([A-Z,a-z,0-9]+[_,-]*[A-Z,a-z,0-9]+)\.([A-Z,a-z,0-9]+[_,-]*[A-Z,a-z,0-9]+\.?)*)\w+";
var input = Console.ReadLine().Split();
foreach (var email in input)
{
    if(Regex.IsMatch(email,pattern))
    {
        Console.WriteLine(email);
    }
}