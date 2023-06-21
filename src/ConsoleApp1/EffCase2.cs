public class EffCase2
{
    public static async Task RunAsync()
    {
        var a = 0;

        int Add() 
        {
            return a++;
        }

        var q = from _1 in unitAff
                let f = Eff(Add)
                from _2 in f.Repeat(Schedule.Once | Schedule.repeat(1))
                select unit;

        var r = await q.Run();

        Console.WriteLine($"EffCase2: {a}");
    }
}
