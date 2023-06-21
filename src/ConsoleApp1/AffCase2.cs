public class AffCase4
{
    public static async Task RunAsync()
    {
        var a = 0;

        async Task<int> AddAsync()
        {
            await Task.Delay(0);
            return a++;
        }

        var f = Aff(AddAsync().ToValue);

        var q = from _1 in unitAff
                from _2 in f.Repeat(Schedule.Once | Schedule.repeat(1))
                select unit;

        var r = await q.Run();

        Console.WriteLine($"AffCase4: {a}");
    }
}
