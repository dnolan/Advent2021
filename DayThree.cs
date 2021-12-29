public class DayThree {
    public async Task Process() {
        
        var rawData = await File.ReadAllTextAsync("D:\\Dev\\Github\\Advent2021\\Data\\daythree.data");
        var instructions = rawData.Split(Environment.NewLine);

        var common = BaseArray();
        var off = BaseArray();
        var on = BaseArray();

        foreach (var instruction in instructions) {
            for (var i = 0; i < instruction.Length; i++) {
                if (instruction[i] == '0') {
                    common[i]--;
                    off[i]++;
                } else {
                    common[i]++;
                    on[i]++;
                }                
            }
        }

        string output = "";
       
        double gamma = 0;
        double epsilon = 0;
        for (var i = 0; i < common.Length; i++) {
            if (common[i] > 0) {
                output += "1";
                Console.WriteLine($"{i},{common.Length},{gamma}");
                gamma += Math.Pow(2, common.Length -1 - i);
            }
            else {
                output += "0";
                epsilon += Math.Pow(2, common.Length -1 - i);
            }
        }

        Console.WriteLine(output);
        Console.WriteLine($"Epsilon {epsilon}");
        Console.WriteLine($"Gamma {gamma}");    
        Console.WriteLine($"Total {gamma*epsilon}");       
        
    }

    public int[] BaseArray() {
        var a = new int[12];
        for (var i = 0; i < a.Length; i++) {
            a[i] = 0;
        }
        return a;
    }
}