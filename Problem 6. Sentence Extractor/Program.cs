using System.Text.RegularExpressions;

string word = Console.ReadLine();
string pattern = $@"({word}(.)?[\s|-]*(.)*[?,\.,!]$)|((.)+[\s|-]*{word}(.)?[\s|-]*(.)*[?,\.,!]$)|((.)+[\s|-]*\w*[\s|-]*{word}[?,\.,!]$)";
string input = Console.ReadLine();
Regex regex = new Regex(pattern);
var matches = regex.Matches(input);
foreach (Match match in matches)
{
    Console.WriteLine(match.Value);
}
