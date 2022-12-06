using System.Text.RegularExpressions;
string str = Console.ReadLine();
Regex regex = new Regex(@"(.)\1+");
Console.WriteLine(regex.Replace(str,"$1"));