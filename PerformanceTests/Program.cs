using BenchmarkDotNet.Running;
using PerformanceTests;

// var summary = BenchmarkRunner.Run<ForVsForeach>();
// var summary = BenchmarkRunner.Run<Strings>();
// var summary = BenchmarkRunner.Run<StringConcatVsFormatVsInterpolationVsStringBuilder>();
var summary = BenchmarkRunner.Run<Casting>();