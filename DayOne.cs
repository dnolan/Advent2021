public class DayOne
{

    public int[] Data { get; set; } = new int[0];

    public async Task Process()
    {
        var rawData = await File.ReadAllTextAsync("D:\\Dev\\Github\\Advent2021\\Data\\dayone.data");

        var splitData = rawData.Split(Environment.NewLine);
        Data = new int[splitData.Length];
        for (var i = 0; i < splitData.Length; i++)
        {
            Data[i] = Convert.ToInt32(splitData[i]);
        }

        var prev = 0;
        var increases = 0;
        for (var i = 0; i < Data.Length; i++)
        {
            Console.Write(Data[i]);
            if (i == 0)
            {
                Console.WriteLine(" (N/A)");
            }
            else if (Data[i] > prev)
            {
                increases++;
                Console.WriteLine(" (increased)");
            }
            else
            {
                Console.WriteLine(" (decreased)");
            }

            prev = Data[i];
        }

        Console.WriteLine(increases);
    }

    public async Task ProcessPartTwo()
    {
        var rawData = await File.ReadAllTextAsync("D:\\Dev\\Github\\Advent2021\\Data\\dayone.data");

        var splitData = rawData.Split(Environment.NewLine);
        Data = new int[splitData.Length];
        for (var i = 0; i < splitData.Length; i++)
        {
            Data[i] = Convert.ToInt32(splitData[i]);
        }

        var prev = 0;
        var increases = 0;
        for (var i = 0; i < Data.Length; i++)
        {
            if (i == Data.Length - 2)             {
                break;
            }
            var total = Data[i]+Data[i+1]+Data[i+2];

            Console.Write(total);
            if (i == 0)
            {
                Console.WriteLine(" (N/A)");
            }
            else if (total > prev)
            {
                increases++;
                Console.WriteLine(" (increased)");
            }
            else
            {
                Console.WriteLine(" (decreased)");
            }

            prev = total;
        }

        Console.WriteLine(increases);
    }


}