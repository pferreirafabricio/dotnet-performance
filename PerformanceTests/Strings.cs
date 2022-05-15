using BenchmarkDotNet.Attributes;

namespace PerformanceTests;

public class Strings
{
    public string lowerCaseName = "Fabricio";
    public string upperCaseName = "FABRICIO";

    [Benchmark]
    public bool EqualityWithToLower() =>
        lowerCaseName == upperCaseName.ToLower();

    [Benchmark]
    public bool EqualityWithToUpper() =>
        lowerCaseName.ToUpper() == upperCaseName;
    
    [Benchmark]
    public bool CompareWithIgnoreCase() =>
        string.Compare(lowerCaseName, upperCaseName, StringComparison.OrdinalIgnoreCase) == 0;

    [Benchmark]
    public bool EqualsIgnoreCase() =>
        lowerCaseName.Equals(upperCaseName, StringComparison.OrdinalIgnoreCase);
}
