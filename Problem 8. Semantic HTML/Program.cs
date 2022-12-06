using System.Text.RegularExpressions;

string input = Console.ReadLine();
string pattern = @"(<div[\s]*id=\W*(\w+)\W*>[\s]*</div>[\s]*<!--[\s]*(\w+)[\s]*-->)";
Regex regex= new Regex(pattern);
if(regex.IsMatch(input))
{
    Console.WriteLine(regex.Replace(input,"<$2> </$3>"));
}