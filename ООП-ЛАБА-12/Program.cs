using System.Text.RegularExpressions;
string pattern = (@"(^[A-Z]{1}[a-z]+\s{1}[A-Z]{1}[a-z]+$)");
var input = Console.ReadLine(); string fullname = string.Empty;
while(!input.Equals("end"))
{
    if(Regex.IsMatch(input,pattern))
    {
        fullname += input + " ";
    }
    input = Console.ReadLine();
}
Console.WriteLine($"{fullname}");

