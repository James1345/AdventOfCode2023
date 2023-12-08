// See https://aka.ms/new-console-template for more information

using System.Text.RegularExpressions;

Console.WriteLine(
    File.ReadAllLines("input.txt").Sum(ScoreLine)
);

int ScoreLine(string line)
{
    var sets = line.Split(':').Last().Split('|').Select(
        it => Regex.Matches(it, @"\d+").Select(it => int.Parse(it.Value))
    ).ToList();
    var matchCount = sets.First().Intersect(sets.Last()).Count();
    return Convert.ToInt32(Math.Pow(2, matchCount - 1));
}