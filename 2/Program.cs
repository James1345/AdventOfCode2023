// See https://aka.ms/new-console-template for more information

Console.WriteLine("test");


internal partial class Program
{
    public record Game(int Id, Draw[] Draws)
    {
        public static Game Parse(string input)
        {
            var parts = input.Split(":");
            var id = ParseId(parts.First());
            var draws = ParseDraws(parts.Last());
            return new Game(id, draws);
        }

        private static Draw[] ParseDraws(string input)
        {
            throw new NotImplementedException();
        }

        private static int ParseId(string input)
        {
            throw new NotImplementedException();
        }
    }

    public record Draw(int Red, int Green, int Blue)
    {
        public static Draw Parse(string input)
        {
            int red = 0, green = 0, blue = 0;
            foreach (var cubes in input.Split(","))
            {
                var words = cubes.Trim().Split(" ");
                var count = int.Parse(words.First());
                switch (words.Last())
                {
                    case "red":
                        red = count;
                        break;
                    case "green":
                        green = count;
                        break;
                    case "blue":
                        blue = count;
                        break;
                }
            }
            return new Draw(red, green, blue);
        }
    }
}