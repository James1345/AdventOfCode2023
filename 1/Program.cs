// See https://aka.ms/new-console-template for more information

using System.Text.RegularExpressions;

string[] lines = File.ReadAllLines("./input.txt");

Console.WriteLine(lines.Sum(SelectDigits));

Console.WriteLine(lines.Sum(SelectDigits2));


int SelectDigits(string line)
{
    var matches = Regex.Matches(line, @"\d");
    return int.Parse($"{matches.First()}{matches.Last()}");
}

int SelectDigits2(string line) =>
    SelectDigits(
        ReplaceMap.Aggregate(
            line,
            (it, map) => it.Replace(map.Key, map.Value)
        )
    );

internal partial class Program
{
    private static readonly Dictionary<string, string> ReplaceMap = new()
    {
        {"one", "o1ne"},
        {"two", "t2wo"},
        {"three", "th3ree"},
        {"four", "f4our"},
        {"five", "f5ive"},
        {"six", "s6ix"},
        {"seven", "se7ven"},
        {"eight", "ei8ght"},
        {"nine", "ni9ne"}
    };
}