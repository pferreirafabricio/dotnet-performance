using System.Text;
using BenchmarkDotNet.Attributes;

namespace PerformanceTests;

public class StringConcatVsFormatVsInterpolationVsStringBuilder
{
    public string Greeting = "Hi";
    public string Name = "Fabricio";

    [Benchmark]
    public void Format()
    {
        var message = string.Format("{0}, {1}!", Greeting, Name);
    }

    [Benchmark]
    public void Concat()
    {
        var message = Greeting + ", " + Name + "!";
    }

    [Benchmark]
    public void Interpolation()
    {
        var message = $"{Greeting}, {Name}!"; 
    }

    [Benchmark]
    public void StringBuilder()
    {
        var stringBuilder = new StringBuilder(); 

        stringBuilder.Append(Greeting);
        stringBuilder.Append(", ");
        stringBuilder.Append(Name);
        stringBuilder.Append("!");

        var message = stringBuilder.ToString();
    }
}
