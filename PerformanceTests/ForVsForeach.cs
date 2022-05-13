using BenchmarkDotNet.Attributes;

namespace PerformanceTests;

public class ForVsForeach
{
    [Params(1000, 10000)]
    public int size;
    public int[] array;
    public IEnumerable<int> enumerable;
    public List<int> list;
    public Random random;

    [GlobalSetup]
    public void Setup()
    {
        array = new int[size];
        list = new List<int>();
        enumerable = list;

        random = new Random();

        for (var index = 0; index < size; index++)
        {
            var number = random.Next(0, 100);

            array[index] = number;
            list.Add(number);
        }
    }

    [Benchmark]
    public void ForArray()
    {
        var sum = 0;

        for (var index = 0; index < size; index++)
           sum += array[index];
    }

    [Benchmark]
    public void ForeachArray()
    {
        var sum = 0;

        foreach (var number in array)
           sum += number;
    }

    [Benchmark]
    public void ForeachIEnumerable()
    {
        var sum = 0;

        foreach (var number in enumerable)
           sum += number;
    }

    [Benchmark]
    public void ForeachList()
    {
        var sum = 0;

        foreach (var number in list)
           sum += number;
    }

    [Benchmark]
    public void ForList()
    {
        var sum = 0;

        for (var index = 0; index < size; index++)
           sum += list[index];
    }
}
