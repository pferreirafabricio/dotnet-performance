using BenchmarkDotNet.Running;
using PerformanceTests;

var summary = BenchmarkRunner.Run<JsonSerialization>();