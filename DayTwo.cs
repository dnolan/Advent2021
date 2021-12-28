public class DayTwo
{
    public async Task Process()
    {
        var rawData = await File.ReadAllTextAsync("D:\\Dev\\Github\\Advent2021\\Data\\daytwo.data");
        var instructions = rawData.Split(Environment.NewLine);

        var horizontal = 0;
        var depth = 0;
        var aim = 0;

        foreach (var instruction in instructions)
        {
            var split = instruction.Split(' ');
            var units = Convert.ToInt32(split[1]);
            switch (split[0])
            {
                case "forward":
                    horizontal += units;
                    depth = depth + (aim * units);
                    Console.WriteLine($"{instruction} horiz={horizontal}, depth={depth}");
                    break;
                case "down":
                    aim += units;
                    Console.WriteLine($"{instruction} aim={aim}");
                    break;
                case "up":
                    aim -= units;
                    Console.WriteLine($"{instruction} depth={aim}");
                    break;
            }
        }

        Console.WriteLine(horizontal*depth);
    }
}