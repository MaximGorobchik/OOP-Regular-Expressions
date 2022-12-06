using System;
using System.Text.RegularExpressions;
string input = "<ul> <li> <a href=\"http://softuni.bg\">SoftUni</a> </li> </ul>";
string pattern = @"<a[\s]{1}href=\W((\W|\w)+)\W>[\s]?(.*)[\s]?<\/a>";
Regex regex = new Regex(pattern);
string result = regex.Replace(input, "[URL href=$1>$3[/URL]");
Console.WriteLine(result);