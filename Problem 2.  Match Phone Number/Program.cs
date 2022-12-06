using System.Text.RegularExpressions;
string pattern = @"(^\+359)([\s]{1}2{1}[\s]{1}\d{3}[\s]{1}\d{4}$)|([-]{1}2{1}[-]{1}\d{3}[-]{1}\d{4}$)";
var input = Console.ReadLine(); string phones = "";
while (!input.Equals("end"))
{
    input = Console.ReadLine();
    if(Regex.IsMatch(input,pattern))
    {
        phones += input + " ";
    }
}
Console.WriteLine($"{phones}");