# ⚡Testing performance on .NET

<p align="left">
  This project aims to test some aspects of .NET and C# most used features, like strings, iterations, serializations and etc.
  <br><br>
  <!-- License -->
  <a>
    <img alt="license url" src="https://img.shields.io/badge/license%20-MIT-1C1E26?style=for-the-badge&labelColor=1C1E26&color=61ffca">
  </a>
</p>

## :open_book: About 
``` ini
BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22616
Intel Core i5-8250U CPU 1.60GHz (Kaby Lake R), 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.300
  [Host]     : .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
  DefaultJob : .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```

## ⚗️ Results

### MD5 vs SHA256

| Method | ByteArraySize |      Mean |      Error |     StdDev |     Median |
|------- |-------------- |----------:|-----------:|-----------:|-----------:|
| **Sha256** |          **1000** |  **9.607 μs** |  **1.3063 μs** |  **3.8518 μs** |  **12.250 μs** |
|    Md5 |          1000 |  2.256 μs |  0.0252 μs |  0.0223 μs |   2.250 μs |
| **Sha256** |         **10000** | **96.301 μs** | **12.3469 μs** | **36.4051 μs** | **116.123 μs** |
|    Md5 |         10000 | 20.502 μs |  0.1869 μs |  0.1657 μs |  20.444 μs |

### Json Serialization

|                    Method |        Mean |      Error |     StdDev |      Median |
|-------------------------- |------------:|-----------:|-----------:|------------:|
| JsonSerializerDeserialize |    947.0 ns |   103.9 ns |   306.4 ns |  1,072.6 ns |
| NewtonsoftJsonDeserialize | 32,968.8 ns | 2,650.5 ns | 7,519.1 ns | 31,100.0 ns |

### For vs Foreach

|             Method |  size |         Mean |        Error |       StdDev |      Median |
|------------------- |------ |-------------:|-------------:|-------------:|------------:|
|           **ForArray** |  **1000** |   **1,280.0 ns** |    **143.18 ns** |    **422.18 ns** |  **1,489.4 ns** |
|       ForeachArray |  1000 |     868.9 ns |    111.77 ns |    329.55 ns |  1,063.6 ns |
| ForeachIEnumerable |  1000 |  14,843.6 ns |  1,647.84 ns |  4,858.71 ns | 17,164.3 ns |
|        ForeachList |  1000 |   2,916.4 ns |    381.80 ns |  1,125.74 ns |  3,504.2 ns |
|            ForList |  1000 |     692.7 ns |     11.35 ns |     10.06 ns |    689.9 ns |
|           **ForArray** | **10000** |  **10,303.5 ns** |  **1,424.66 ns** |  **4,200.64 ns** |  **6,838.1 ns** |
|       ForeachArray | 10000 |   4,465.2 ns |     84.00 ns |     74.46 ns |  4,432.2 ns |
| ForeachIEnumerable | 10000 | 119,238.6 ns | 17,432.41 ns | 51,399.86 ns | 90,412.1 ns |
|        ForeachList | 10000 |  27,568.3 ns |  4,209.92 ns | 12,413.04 ns | 28,291.6 ns |
|            ForList | 10000 |  12,643.5 ns |  1,680.58 ns |  4,955.22 ns | 16,449.0 ns |

### Strings Comparision

|                Method |     Mean |    Error |    StdDev |    Median |
|---------------------- |---------:|---------:|----------:|----------:|
|   EqualityWithToLower | 58.05 ns | 8.259 ns | 24.352 ns | 42.576 ns |
|   EqualityWithToUpper | 53.49 ns | 7.740 ns | 22.820 ns | 37.118 ns |
| CompareWithIgnoreCase | 19.47 ns | 0.378 ns |  0.388 ns | 19.345 ns |
|      EqualsIgnoreCase | 13.72 ns | 2.323 ns |  6.849 ns |  8.637 ns |

### Strings concatenation

|        Method |     Mean |     Error |    StdDev |   Median |
|-------------- |---------:|----------:|----------:|---------:|
|        Format | 78.44 ns |  1.579 ns |  1.551 ns | 78.12 ns |
|        Concat | 45.88 ns |  6.374 ns | 18.793 ns | 40.66 ns |
| Interpolation | 45.04 ns |  7.037 ns | 20.749 ns | 31.71 ns |
| StringBuilder | 71.95 ns | 10.842 ns | 31.967 ns | 84.46 ns |

### Casting

|           Method | Length |      Mean |     Error |    StdDev |    Median |
|----------------- |------- |----------:|----------:|----------:|----------:|
|    **CastWithParse** |   **1000** |  **25.20 μs** |  **3.494 μs** | **10.302 μs** |  **25.55 μs** |
|  CastWithConvert |   1000 |  23.78 μs |  3.284 μs |  9.683 μs |  20.17 μs |
| CastWithTryParse |   1000 |  22.31 μs |  3.110 μs |  9.169 μs |  16.24 μs |
|    **CastWithParse** |  **10000** | **228.18 μs** | **31.921 μs** | **94.121 μs** | **158.12 μs** |
|  CastWithConvert |  10000 | 145.90 μs |  2.831 μs |  2.649 μs | 145.37 μs |
| CastWithTryParse |  10000 | 147.93 μs |  1.254 μs |  0.979 μs | 147.63 μs |

## 🏄‍♂️ Quick Start
 1. Clone this repository `git clone https://github.com/pferreirafabricio/dotnet-performance.git`;
 2. Enter in the project's folder: `cd dotnet-performance`
 3. Enter in the solution: `cd PerformanceTests`
 4. Change on `Program.cs` file to use the class that you want to test
 5. Finally run `dotnet run --configuration Release` 😃

## :bricks: This project was built with: 
- [.NET](https://dotnet.microsoft.com/en-us/)
- [BenchmarkDotNet](https://benchmarkdotnet.org/index.html)
