using BenchmarkDotNet.Attributes;

namespace PerformanceTests
{
    public class Casting
    {
        [Params(1000, 10000)]
        public int Length { get; set; }

        public string[] Numbers { get; set; }

        [GlobalSetup]
        public void Setup()
        {
            Numbers = new string[Length];

            for (var index = 0; index < Length; index++)
                Numbers[index] = index.ToString();
        }

        [Benchmark]
        public void CastWithParse()
        {
            for (var index = 0; index < Length; index++)
            {
                var num = int.Parse(Numbers[index]);
            }
        }

        [Benchmark]
        public void CastWithConvert()
        {
            for (var index = 0; index < Length; index++)
            {
                var num = Convert.ToInt32(Numbers[index]);
            }
        }

        [Benchmark]
        public void CastWithTryParse()
        {
            for (var index = 0; index < Length; index++)
            {
                int.TryParse(Numbers[index], out int num);
            }
        }
    }
}